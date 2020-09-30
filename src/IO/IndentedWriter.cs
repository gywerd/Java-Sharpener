/* Copyright (C) 2004 - 2008  Versant Inc.  http://www.db4o.com

The original file wass part of the sharpen open source java to c# translator.

It has been modified in accordance with the terms of version 2 of 
the GNU General Public License, available at
http://www.db4o.com/about/company/legalpolicies/gplinterpretation/ */

// Copyright (C) 2020 Daniel Giversen

using System;
using System.IO;

namespace IO
{
	///<remarks />
	public class IndentedWriter
	{

		private int _maxColumns;

		//Always use crlf for C# output, regardless of platform preference.
		private string _lineSeparator = "\r\n"; //System.getProperty("line.separator");

		private string _indentstring = "\t";

		private int _indentLevel = 0;

		private int _column;

		private Writer _delegate;

		private string _prefix;

		///<remarks />
		public IndentedWriter(Writer writer, int maxColumns)
		{
			_delegate = writer;
			_maxColumns = maxColumns;
		}

		///<remarks />
		public Writer Delegate { get => _delegate; }

		///<remarks />
		public string Indentstring { get => _indentstring; set => _indentstring = value; }

		///<remarks />
		public void Indent()
		{
			++_indentLevel;
		}

		///<remarks />
		public void Outdent()
		{
			--_indentLevel;
		}

		///<remarks />
		public void WriteIndented(string s)
		{
			writeIndentation();
			write(s);
		}

		///<remarks />
		public void WriteIndentedLine(string s)
		{
			writeIndentation();
			writeLine(s);

		}

		///<remarks />
		public void Write(string s)
		{
			if (_column > _maxColumns)
			{
				writeLine();
				writeIndented(_indentstring);
			}
			writeBlock(s);
		}

		/**
		 * write a block of text without checking columns.
		 */
		public void WriteBlock(string s)
		{
			uncheckedWrite(s);
			_column += s.length();
		}

		///<remarks />
		public void WriteLine()
		{
			WriteLine("");
		}

		///<remarks />
		public void WriteLine(string s)
		{
			try
			{
				_delegate.Write(s);
				_delegate.Write(_lineSeparator);
				_column = 0;
			}
			catch (IOException e)
			{
				throw new RuntimeException(e);
			}
		}

		///<remarks />
		private void UncheckedWrite(string s)
		{
			try
			{
				_delegate.Write(s);
			}
			catch (IOException e)
			{
				throw new RuntimeException(e);
			}
		}

		///<remarks />
		public void WriteLines(string lines)
		{
			StreamReader lineReader = new StreamReader(new StringReader(lines));
			string line;
			try
			{
				while (null != (line = lineReader.readLine()))
				{
					if (line.trim().length() > 0)
					{
						WriteIndentedLine(line);
					}
					else
					{
						WriteLine();
					}
				}
			}
			catch (IOException x)
			{
				throw new RuntimeException(x);
			}
		}

		///<remarks />
		public void LinePrefix(string prefix)
		{
			_prefix = prefix;
		}

		///<remarks />
		public void WriteIndentation()
		{
			for (int i = 0; i < _indentLevel; ++i)
			{
				uncheckedWrite(_indentstring);
			}
			if (null != _prefix)
			{
				uncheckedWrite(_prefix);
			}
		}

}
}
