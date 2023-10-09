using Shouldly;

namespace WordSearch.Tests;

public class SemordnilapRuleTests
{
    [Fact]
    public void ApplyRule_Returns_Semordnilaps()
    {
        // Arrange
        List<string> words = new() { "Isogram", "semordnilap", "god", "dog", "deified", "repaid", "reward", "drawer", "diaper", "Palindromes" };

        // Act
        List<string> result = new();

        // Assert
        result.Count.ShouldBe(8); // exact number of Semordnilaps

        result.ShouldContain("semordnilap");
        result.ShouldContain("Palindromes");
        result.ShouldContain("god");
        result.ShouldContain("dog");
        result.ShouldContain("reward");
        result.ShouldContain("drawer");
        result.ShouldContain("repaid");
        result.ShouldContain("diaper");
    }

    // More tests for different cases
}