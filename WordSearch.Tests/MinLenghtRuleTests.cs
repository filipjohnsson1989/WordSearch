using Shouldly;
using WordSearchEngine;

namespace WordSearch.Tests;

public class MinLengthRuleTests
{
    [Fact]
    public void ApplyRule_Returns_WordsWithMinLength()
    {
        // Arrange
        List<string> words = new List<string> { "Isogram", "semordnilap", "god", "dog", "deified", "repaid", "reward", "drawer", "diaper", "Palindromes" };
        int minLength = 6;
        MinLengthRule rule = new(minLength);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.Count.ShouldBe(8); // exact number of words with min length

        result.ShouldContain("Isogram");
        result.ShouldContain("semordnilap");
        result.ShouldContain("deified");
        result.ShouldContain("repaid");
        result.ShouldContain("reward");
        result.ShouldContain("drawer");
        result.ShouldContain("diaper");
        result.ShouldContain("Palindromes");

    }

    [Fact]
    public void ApplyRule_Returns_NoWordsWithMinLength()
    {
        // Arrange
        List<string> words = new List<string> { "Isogram", "semordnilap", "god", "dog", "deified", "repaid", "reward", "drawer", "diaper", "Palindromes" };
        int minLength = 12;
        MinLengthRule rule = new(minLength);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.ShouldBeEmpty();
    }
}