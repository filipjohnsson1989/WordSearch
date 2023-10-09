using WordSearchEngine.Rules;

namespace WordSearchEngine;

public class MinLengthRule
{
    private readonly int _minLength;

    public MinLengthRule(int minLength) => this._minLength = minLength;

    public List<string> ApplyRule(List<string> words) => words.Where(word => word.Length >= _minLength).ToList();
}