using WordSearchEngine;

namespace WordSearch.Tests
{
    public class PalindromeRuleTests
    {
        private readonly PalindromeRule _rule = new PalindromeRule();

        [Fact]
        public void ApplyRule_Returns_Palindromes()
        {
            // Arrange
            List<string> words = new List<string> { "madam", "hello", "radar", "level" };

            // Act
            var result = _rule.ApplyRule(words);

            // Assert
            Assert.Collection(result,
                item => Assert.Equal("madam", item),
                item => Assert.Equal("radar", item),
                item => Assert.Equal("level", item)
            );
        }

        // More tests for different cases
    }
}