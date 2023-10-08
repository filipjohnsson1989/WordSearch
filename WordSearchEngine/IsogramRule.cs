namespace WordSearchEngine;

public class IsogramRule
{
    public List<string> ApplyRule(List<string> words) => words.Where(word => IsIsogram(word)).ToList();

    private bool IsIsogram(string word) => false; //TODO: Implement isogram check logic
}