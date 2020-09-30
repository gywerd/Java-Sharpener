/* Copyright (C) 2004 - 2008  Versant Inc.  http://www.db4o.com

This file is part of the sharpen open source java to c# translator.

sharpen is free software; you can redistribute it and/or modify it under
the terms of version 2 of the GNU General Public License as published
by the Free Software Foundation and as clarified by db4objects' GPL 
interpretation policy, available at
http://www.db4o.com/about/company/legalpolicies/gplinterpretation/
Alternatively you can write to db4objects, Inc., 1900 S Norfolk Street,
Suite 350, San Mateo, CA 94403, USA.

sharpen is distributed in the hope that it will be useful, but WITHOUT ANY
WARRANTY; without even the implied warranty of MERCHANTABILITY or
FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
for more details.

You should have received a copy of the GNU General Public License along
with this program; if not, write to the Free Software Foundation, Inc.,
59 Temple Place - Suite 330, Boston, MA  02111-1307, USA. */

using System;
using System.Collections;
using System.IO;

namespace IO
{
	/// <remarks />
	public static class IO
	{
		/// <remarks />
		public static void WriteFile(string filePath, string contents) => File.WriteAllText(filePath, contents);

		/// <remarks />
		public static string ReadFile(string filePath) => File.ReadAllText(filePath);

		/// <summary>
		/// Collects lines from <paramref name="reader"/>.
		/// </summary>
		/// <param name="reader"><see cref="StreamReader"/></param>
		/// <returns></returns>
		public static ArrayList CollectLines(StreamReader reader)
		{
			ArrayList result = new ArrayList();
			string line = string.Empty;

			while (line != null)
			{
				line = reader.ReadLine();
				line = line.Trim();
				if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
				{
					foreach (string arg in line.Split("\\s+"))
					{
						lines.Add(arg);
					}
				}
			}

			return result;

		}

		/// <remarks />
		public static string[] LinesFromFile(String fname) => File.ReadAllLines(fname);

	}

}

