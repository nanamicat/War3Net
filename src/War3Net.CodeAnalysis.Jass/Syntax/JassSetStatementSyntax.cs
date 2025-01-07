// ------------------------------------------------------------------------------
// <copyright file="JassSetStatementSyntax.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using War3Net.CodeAnalysis.Jass.Extensions;

namespace War3Net.CodeAnalysis.Jass.Syntax
{
    public class JassSetStatementSyntax : IStatementSyntax, IStatementLineSyntax
    {
        public JassSetStatementSyntax(JassIdentifierNameSyntax identifierName, IExpressionSyntax? indexer, JassEqualsValueClauseSyntax value)
        {
            IdentifierName = identifierName;
            Indexer = indexer;
            Value = value;
        }

        public JassIdentifierNameSyntax IdentifierName { get; set; }

        public IExpressionSyntax? Indexer { get; set; }

        public JassEqualsValueClauseSyntax Value { get; set; }

        public bool Equals(IStatementSyntax? other)
        {
            return other is JassSetStatementSyntax setStatement
                && IdentifierName.Equals(setStatement.IdentifierName)
                && Indexer.NullableEquals(setStatement.Indexer)
                && Value.Equals(setStatement.Value);
        }

        public bool Equals(IStatementLineSyntax? other)
        {
            return other is JassSetStatementSyntax setStatement
                && IdentifierName.Equals(setStatement.IdentifierName)
                && Indexer.NullableEquals(setStatement.Indexer)
                && Value.Equals(setStatement.Value);
        }

        public override string ToString()
        {
            return Indexer is null
                ? $"{JassKeyword.Set} {IdentifierName} {Value}"
                : $"{JassKeyword.Set} {IdentifierName}{JassSymbol.LeftSquareBracket}{Indexer}{JassSymbol.RightSquareBracket} {Value}";
        }
    }
}