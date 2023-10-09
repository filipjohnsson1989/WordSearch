namespace WordSearchEngine.Rules;

public class EndWithRule : IRule
{
    private readonly string _endWith;

    public EndWithRule(string endWith) => _endWith = endWith;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.EndsWith(_endWith, StringComparison.OrdinalIgnoreCase)).ToList();
}