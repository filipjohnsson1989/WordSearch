using Shouldly;

namespace WordSearch.Tests;

public class StartWithRuleTests
{
    [Fact]
    public void ApplyRule_Returns_WordsStartWith()
    {
        // Arrange
        List<string> words = new List<string> { "BAnana", "semordnilap", "god", "dog", "bath" };
        string startWith = "bA";
        StartWithRule rule = new(startWith);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.Count.ShouldBe(2); // exact number of words with max length

        result.ShouldContain("BAnana");
        result.ShouldContain("bath");

    }

    [Fact]
    public void ApplyRule_Returns_NoWordsStartWith()
    {
        // Arrange
        List<string> words = new List<string> { "god", "dog", "deified", "repaid", "reward", "drawer"};
        string startWith = "az";
        StartWithRule rule = new(startWith);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.ShouldBeEmpty();
    }
}

public class StartWithRule
{
    private readonly string _startWith;

    public StartWithRule(string startWith)
    {
        this._startWith = startWith;
    }

    public List<string> ApplyRule(List<string> words) => new(); //TODO: Implement StartWith check logic
}