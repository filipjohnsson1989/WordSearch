namespace WordSearchEngine;

public class IsogramRule
{
    public List<string> ApplyRule(List<string> words) => words.Where(word => IsIsogram(word)).ToList();

    private bool IsIsogram(string word)
    {
        // Convert the word to lowercase to ignore case
        word = word.ToLower();

        // Create a HashSet to store seen characters
        var seenCharacters = new HashSet<char>();

        foreach (char character in word)
        {
            // If the character is not a space and it's already seen, it's not an isogram
            if (character != ' ' && seenCharacters.Contains(character))
                return false;

            // Add the character to the set
            seenCharacters.Add(character);
        }

        return true;
    }
}