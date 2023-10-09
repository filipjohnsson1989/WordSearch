using Shouldly;
using WordSearchEngine.Rules;

namespace WordSearch.Tests;

public class ContainOnlyRuleTests
{
    [Fact]
    public void ApplyRule_Returns_WordsContainOnly()
    {
        // Arrange
        List<string> words = new List<string> { "bad", "reward", "god", "dog", "decade" };
        string containOnly = "abcde";
        ContainOnlyRule rule = new(containOnly);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.Count.ShouldBe(2); // exact number of words with max length

        result.ShouldContain("bad");
        result.ShouldContain("decade");

    }

    [Fact]
    public void ApplyRule_Returns_NoWordsContainOnly()
    {
        // Arrange
        List<string> words = new List<string> { "god", "dog", "deified", "repaid", "reward", "drawer" };
        string containOnly = "ks";
        ContainOnlyRule rule = new(containOnly);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.ShouldBeEmpty();
    }
}