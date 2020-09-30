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
using System.Collections.Generic;

namespace Ast 
{
	///<remarks />
	public abstract class CSNode
	{


		private int _startPosition;

		private HashSet<string> _enclosingIfDefs = new HashSet<String>();

		private CSNode _parent;

		///<remarks />
		public CSNode()
		{
			_startPosition = UNKNOWN_START_POSITION;
		}

		public CSNode(int startPosition)
		{
			_startPosition = startPosition;
		}

		///<remarks />
		public HashSet<String> EnclosingIfDefs { get => _enclosingIfDefs; }

		///<remarks />
		public CSNode parent { get => _parent; set => _parent = value; }

		///<remarks />
		public int StartPosition { get => _startPosition; set => _startPosition = value; }

		///<remarks />
		public static int UNKNOWN_START_POSITION { get; } = int.MinValue;

		///<remarks />
		public abstract void Accept(CSVisitor visitor);

		///<remarks />
		public void AddEnclosingIfDef(string expression)
		{
			_enclosingIfDefs.Add(expression);
		}

	}
}

