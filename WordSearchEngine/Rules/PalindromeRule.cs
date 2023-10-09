namespace WordSearchEngine.Rules;

public class PalindromeRule : IRule
{
    public List<string> ApplyRule(List<string> words) => words.Where(word => IsPalindrome(word)).ToList();

    private bool IsPalindrome(string word)
    {
        // Convert the word to lowercase to ignore case
        word = word.ToLower();

        int length = word.Length;

        // We only need to check half the word because the other half is the reverse of the first half in a palindrome.
        for (int i = 0; i < length / 2; i++)
        {
            // Check if characters at positions i and length - i - 1 are not the same.
            // If they are not the same, the word is not a palindrome.
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}