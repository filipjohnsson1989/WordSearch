using WordSearchEngine.Rules;

namespace WordSearchEngine;

public class ContainOnlyRule
{
    private readonly string _containOnly;

    public ContainOnlyRule(string containOnly) => this._containOnly = containOnly;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.All(c => _containOnly.Contains(c, StringComparison.OrdinalIgnoreCase))).ToList();
}