namespace WordSearchEngine.Rules;

public interface IRule
{
    List<string> ApplyRule(List<string> words);
}