namespace WordSearch.Tests
{
    public class PalindromeRuleTests
    {
        [Fact]
        public void ApplyRule_Returns_Palindromes()
        {
            // Arrange
            List<string> words = new List<string> { "madam", "hello", "radar", "level" };

            // Act
            List<string> result = new(); //TODO: Act

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