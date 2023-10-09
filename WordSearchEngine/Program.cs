namespace WordSearchEngine;

internal class Program
{
    static void Main(string[] rules)
    {
        if (rules.Length == 0)
        {
            Console.WriteLine("Please provide rules for word search.");
            return;
        }

        // Load the word list from a file
        var wordReader = new WordReader();
        var words = wordReader.ReadWordsFromWordList();

        var service = new WordSearchService(words);

        var result = service.Search(rules);

        foreach (var word in result)
        {
            Console.WriteLine(word);
        }
    }
}