using Shouldly;

namespace WordSearch.Tests;

public class IsogramRuleTests
{
    [Fact]
    public void ApplyRule_Returns_Isograms()
    {
        // Arrange
        List<string> words = new List<string> { "word", "hello", "banana", "Madam", "AAbb", "isogram", "aabBcCd" };

        // Act
        List<string> result = new();

        // Assert
        result.Count.ShouldBe(2); // exact number of Isograms

        result.ShouldContain("word");
        result.ShouldContain("isogram");
    }

    // More tests for different cases
}