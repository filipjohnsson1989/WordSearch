namespace WordSearchEngine.Rules;

public class MinLengthRule : IRule
{
    private readonly int _minLength;

    public MinLengthRule(int minLength) => _minLength = minLength;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.Length >= _minLength).ToList();
}