namespace WordSearchEngine.Rules;

public class ContainOnlyRule : IRule
{
    private readonly string _containOnly;

    public ContainOnlyRule(string containOnly) => _containOnly = containOnly;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.All(c => _containOnly.Contains(c, StringComparison.OrdinalIgnoreCase))).ToList();
}