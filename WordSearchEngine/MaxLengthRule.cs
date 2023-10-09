using WordSearchEngine.Rules;

namespace WordSearchEngine;

public class MaxLengthRule
{
    private readonly int _maxLength;

    public MaxLengthRule(int maxLength) => this._maxLength = maxLength;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.Length <= _maxLength).ToList();
}