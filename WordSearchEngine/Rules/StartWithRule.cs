namespace WordSearchEngine.Rules;

public class StartWithRule : IRule
{
    private readonly string _startWith;

    public StartWithRule(string startWith) => _startWith = startWith;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.StartsWith(_startWith, StringComparison.OrdinalIgnoreCase)).ToList();
}