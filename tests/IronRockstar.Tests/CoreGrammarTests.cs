
using Irony.Parsing;

namespace IronRockstar.Tests
{
    using Xunit;

    public class CoreGrammarTests
    {
        [Fact]
        public void BracketedTermsShouldBeTreatedAsComments()
        {
            var parser = new Parser(new RockstarGrammar());
            var tree = parser.Parse("(This is a comment)");
            Assert.True(tree.Tokens.Count ==1, "Parsed tree contains no tokens");
            var token = tree.Tokens[0];
            Assert.Equal(TokenCategory.Comment, token.Category);

        }
    }
}
