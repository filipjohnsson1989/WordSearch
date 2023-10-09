using WordSearchEngine.Rules;

namespace WordSearchEngine;

public class EndWithRule
{
    private readonly string _endWith;

    public EndWithRule(string endWith) => this._endWith = endWith;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.EndsWith(_endWith, StringComparison.OrdinalIgnoreCase)).ToList();
}