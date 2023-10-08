using Shouldly;
using WordSearchEngine;

namespace WordSearch.Tests;

public class IsogramRuleTests
{
    private readonly IsogramRule _rule = new();

    [Fact]
    public void ApplyRule_Returns_Isograms()
    {
        // Arrange
        List<string> words = new() { "word", "hello", "banana", "Madam", "AAbb", "isogram", "aabBcCd" };

        // Act
        var result = _rule.ApplyRule(words);

        // Assert
        result.Count.ShouldBe(2); // exact number of Isograms

        result.ShouldContain("word");
        result.ShouldContain("isogram");
    }

    // More tests for different cases
}