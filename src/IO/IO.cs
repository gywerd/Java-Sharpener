/* Copyright (C) 2004 - 2008  Versant Inc.  http://www.db4o.com

The original file wass part of the sharpen open source java to c# translator.

It has been modified in accordance with the terms of version 2 of 
the GNU General Public License, available at
http://www.db4o.com/about/company/legalpolicies/gplinterpretation/ */

// Copyright (C) 2020 Daniel Giversen

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
		/// <returns><see cref="ArrayList"/></returns>
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
						result.Add(arg);
					}
				}
			}

			return result;

		}

		/// <remarks />
		public static string[] LinesFromFile(String fname) => File.ReadAllLines(fname);

	}

}

