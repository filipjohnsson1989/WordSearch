using Shouldly;
using WordSearchEngine;

namespace WordSearch.Tests;

public class WordSearchServiceIntegrationTests
{
    [Fact]
    public void Search_Returns_CorrectWords()
    {
        // Arrange
        var words = new List<string> { "hello", "world", "hi", "madam", "level", "radar" };
        var service = new WordSearchService(words);

        // Act
        var rules = new[] { "class=palindrome", "maxlength=6" };
        var result = service.Search(rules);

        // Assert
        result.Count.ShouldBe(3);
        result[0].ShouldBe("madam");
        result[1].ShouldBe("level");
        result[2].ShouldBe("radar");
    }


    [Fact]
    public void Search_Should_Throw_Exception_InvalidRule()
    {
        // Arrange
        List<string> words = new() { "Isogram", "semordnilap", "god", "dog", "deified", "repaid", "reward", "drawer", "diaper", "Palindromes" };
        var service = new WordSearchService(words);

        // Act & Assert
        Should.Throw<ArgumentOutOfRangeException>(() => service.Search(new[] { "invalidrule" }));
    }

    [Fact]
    public void Search_Should_Throw_Exception_UnknownRule()
    {
        // Arrange
        List<string> words = new() { "Isogram", "semordnilap", "god", "dog", "deified", "repaid", "reward", "drawer", "diaper", "Palindromes" };
        var service = new WordSearchService(words);

        // Act & Assert
        Should.Throw<ArgumentException>(() => service.Search(new[] { "unknownrule=something" }));
    }
}