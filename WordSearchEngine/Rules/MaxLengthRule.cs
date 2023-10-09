namespace WordSearchEngine.Rules;

public class MaxLengthRule : IRule
{
    private readonly int _maxLength;

    public MaxLengthRule(int maxLength) => _maxLength = maxLength;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.Length <= _maxLength).ToList();
}