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

/*
 * Created on Jan 20, 2005
 *
 */
package sharpen.core.csharp.ast;

public class CSVisitor {
	
	protected <T extends CSNode> void VisitList(Iterable<T> nodes) {
		for (CSNode node : nodes) {
			node.accept(this);
		}
	}

	public void Visit(CSCompilationUnit node) {
	}

	public void Visit(CSUsing node) {
	}
	
	public void Visit(CSClass node) {
	}
	
	public void Visit(CSMethod node) {
	}

	public void Visit(CSField node) {
	}

	public void Visit(CSInterface node) {		
	}
	
	public void Visit(CSStruct node) {
	}

	public void Visit(CSVariableDeclaration node) {
	}

	public void Visit(CSConstructor node) {
	}

	public void Visit(CSReturnStatement node) {
	}

	public void Visit(CSNumberLiteralExpression node) {		
	}

	public void Visit(CSNullLiteralExpression node) {
	}

	public void Visit(CSReferenceExpression node) {
	}
	
	public void Visit(CSMemberReferenceExpression node) {
	}

	public void Visit(CSThisExpression node) {
	}

	public void Visit(CSMethodInvocationExpression node) {
	}
	
	public void Visit(CSConstructorInvocationExpression node) {
	}

	public void Visit(CSExpressionStatement node) {
	}

	public void Visit(CSInfixExpression node) {
	}

	public void Visit(CSStringLiteralExpression node) {
	}

	public void Visit(CSCastExpression node) {
	}

	public void Visit(CSDeclarationStatement node) {
	}

	public void Visit(CSBoolLiteralExpression node) {
	}

	public void Visit(CSDestructor node) {
	}

	public void Visit(CSIfStatement node) {
	}

	public void Visit(CSBlock node) {
	}

	public void Visit(CSThrowStatement node) {
	}

	public void Visit(CSWhileStatement node) {
	}
	
	public void Visit(CSDoStatement node) {
	}

	public void Visit(CSPrefixExpression node) {
	}

	public void Visit(CSPostfixExpression node) {
	}

	public void Visit(CSConditionalExpression node) {
	}

	public void Visit(CSParenthesizedExpression node) {
	}

	public void Visit(CSLockStatement node) {
	}

	public void Visit(CSTryStatement node) {
	}

	public void Visit(CSCatchClause node) {
	}

	public void Visit(CSBaseExpression node) {
	}

	public void Visit(CSIndexedExpression node) {
	}

	public void Visit(CSArrayCreationExpression node) {
	}

	public void Visit(CSArrayInitializerExpression node) {
	}

	public void Visit(CSForStatement node) {
	}

	public void Visit(CSTypeofExpression node) {
	}

	public void Visit(CSSwitchStatement node) {
	}

	public void Visit(CSCaseClause node) {
	}

	public void Visit(CSBreakStatement node) {
	}

	public void Visit(CSDeclarationExpression node) {
	}

	public void Visit(CSCharLiteralExpression node) {
	}

	public void Visit(CSContinueStatement node) {
	}

	public void Visit(CSAttribute node) {
	}

	public void Visit(CSDocTagNode node) {
	}

	public void Visit(CSDocTextNode node) {
	}
	
	public void Visit(CSDocTextOverlay node) {
	}

	public void Visit(CSDocAttributeNode node) {
	}

	public void Visit(CSUncheckedExpression node) {
	}

	public void Visit(CSEvent node) {		
	}

	public void Visit(CSDelegate node) {
	}

	public void Visit(CSProperty node) {
	}

	public void Visit(CSTypeParameter node) {
	}

	public void Visit(CSTypeReference node) {
	}

	public void Visit(CSForEachStatement node) {
	}

	public void Visit(CSArrayTypeReference node) {
	}

	public void Visit(CSEnum node) {
	}

	public void Visit(CSEnumValue node) {
	}

	public void Visit(CSLineComment node) {
	}

	public void Visit(CSBlockComment node) {
	}

	public void Visit(CSRemovedExpression node) {
    }

	public void Visit(CSMacroExpression node) {
    }

	public void Visit(CSMacro node) {
    }

	public void Visit(CSMacroTypeReference node) {
    }

	public void Visit(CSLabelStatement node) {
	}

	public void Visit(CSGotoStatement node) {
	}

	public void Visit(CSUsingStatement node) {
	}
}
