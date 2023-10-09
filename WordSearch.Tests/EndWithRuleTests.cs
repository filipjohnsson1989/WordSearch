using Shouldly;
using WordSearchEngine.Rules;

namespace WordSearch.Tests;

public class EndWithRuleTests
{
    [Fact]
    public void ApplyRule_Returns_WordsEndWith()
    {
        // Arrange
        List<string> words = new List<string> { "123abc", "aaabc", "god", "dog", "bc" };
        string endWith = "abc";
        EndWithRule rule = new(endWith);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.Count.ShouldBe(2); // exact number of words with max length

        result.ShouldContain("123abc");
        result.ShouldContain("aaabc");

    }

    [Fact]
    public void ApplyRule_Returns_NoWordsEndWith()
    {
        // Arrange
        List<string> words = new List<string> { "goda", "dogs", "deified", "repaid", "reward", "drawer"};
        string endWith = "as";
        EndWithRule rule = new(endWith);

        // Act
        var result = rule.ApplyRule(words);

        // Assert
        result.ShouldBeEmpty();
    }
}