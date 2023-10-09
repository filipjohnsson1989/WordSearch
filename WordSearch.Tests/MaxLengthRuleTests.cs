using Shouldly;

namespace WordSearch.Tests;

public class MaxLengthRuleTests
{
    [Fact]
    public void ApplyRule_Returns_WordsWithMaxLength()
    {
        // Arrange
        List<string> words = new List<string> { "Isogram", "semordnilap", "god", "dog", "deified", "repaid", "reward", "drawer", "diaper", "Palindromes" };
        int maxLength = 7;
        MaxLengthRule rule = new(maxLength);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.Count.ShouldBe(8); // exact number of words with max length

        result.ShouldContain("Isogram");
        result.ShouldContain("god");
        result.ShouldContain("dog");
        result.ShouldContain("deified");
        result.ShouldContain("repaid");
        result.ShouldContain("reward");
        result.ShouldContain("drawer");
        result.ShouldContain("diaper");

    }

    [Fact]
    public void ApplyRule_Returns_NoWordsWithMaxLength()
    {
        // Arrange
        List<string> words = new List<string> { "Isogram", "semordnilap", "god", "dog", "deified", "repaid", "reward", "drawer", "diaper", "Palindromes" };
        int maxLength = 2;
        MaxLengthRule rule = new(maxLength);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.ShouldBeEmpty();
    }
}

public class MaxLengthRule
{
    private readonly int _maxLength;

    public MaxLengthRule(int maxLength)
    {
        this._maxLength = maxLength;
    }

    public List<string> ApplyRule(List<string> words)
    {
        throw new NotImplementedException();
    }
}
