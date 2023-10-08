using Shouldly;
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
            result.Count.ShouldBe(3); // exact number of Palindromes

            result.ShouldContain("madam");
            result.ShouldContain("radar");
            result.ShouldContain("level");
        }

        // More tests for different cases
    }
}