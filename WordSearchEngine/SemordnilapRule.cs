namespace WordSearchEngine;

public class SemordnilapRule
{
    public List<string> ApplyRule(List<string> words) => words.Where(word => IsSemordnilap(word, words)).ToList();

    private bool IsSemordnilap(string word, List<string> words)
    {
        // Check if the reverse of the word is in the list and it's not the same as the original word
        string reversedWord = new string(word.Reverse().ToArray());

        return !word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase) && // A *semordnilap* is a word that spells a different word backwards, is not *Palindrome*
               words.Contains(reversedWord, StringComparer.OrdinalIgnoreCase);   // A different word from the list, that spells the word backwards
    }
}