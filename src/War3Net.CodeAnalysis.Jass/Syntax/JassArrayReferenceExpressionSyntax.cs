// ------------------------------------------------------------------------------
// <copyright file="JassArrayReferenceExpressionSyntax.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

namespace War3Net.CodeAnalysis.Jass.Syntax
{
    public class JassArrayReferenceExpressionSyntax : IExpressionSyntax
    {
        public JassArrayReferenceExpressionSyntax(JassIdentifierNameSyntax identifierName, IExpressionSyntax indexer)
        {
            IdentifierName = identifierName;
            Indexer = indexer;
        }

        public JassIdentifierNameSyntax IdentifierName { get; set; }

        public IExpressionSyntax Indexer { get; set; }

        public bool Equals(IExpressionSyntax? other)
        {
            return other is JassArrayReferenceExpressionSyntax arrayReferenceExpression
                && IdentifierName.Equals(arrayReferenceExpression.IdentifierName)
                && Indexer.Equals(arrayReferenceExpression.Indexer);
        }

        public override string ToString() => $"{IdentifierName}{JassSymbol.LeftSquareBracket}{Indexer}{JassSymbol.RightSquareBracket}";
    }
}