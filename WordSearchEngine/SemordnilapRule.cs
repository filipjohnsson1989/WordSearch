namespace WordSearchEngine;

public class SemordnilapRule
{
    public List<string> ApplyRule(List<string> words) => words.Where(word => IsSemordnilap(word, words)).ToList();

    private bool IsSemordnilap(string word, List<string> words) => false; //TODO: Implement Semordnilap check logic
}