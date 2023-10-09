namespace WordSearchEngine;

public class WordReader
{
    public List<string> ReadWordsFromWordList()
    {
        var words = new List<string>();

        try
        {
            var filePath = "wordlist.txt"; // Relative path to the file

            if (File.Exists(filePath))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Add each line (word) to the list
                foreach (var line in lines)
                {
                    words.Add(line.Trim());
                }
            }
            else
            {
                Console.WriteLine("The file 'wordlist.txt' does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading the wordlist: " + ex.Message);
        }

        return words;
    }
}