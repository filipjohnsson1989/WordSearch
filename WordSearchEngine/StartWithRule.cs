using WordSearchEngine.Rules;

namespace WordSearchEngine;

public class StartWithRule
{
    private readonly string _startWith;

    public StartWithRule(string startWith) => this._startWith = startWith;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.StartsWith(_startWith, StringComparison.OrdinalIgnoreCase)).ToList();
}