using WordSearchEngine.Rules;

namespace WordSearchEngine;

public class WordSearchService
{
    private readonly List<string> _words;

    public WordSearchService(List<string> words)
    {
        _words = words;
    }

    public List<string> Search(string[] rules)
    {
        var result = new List<string>(_words);

        foreach (var rule in rules)
        {
            var parts = rule.Split('=');

            if (parts.Length != 2)
            {
                Console.WriteLine($"Invalid rule: {rule}. Skipping.");
                continue;
            }

            var ruleType = parts[0];
            var argument = parts[1];

            IRule ruleInstance = GetRuleInstance(ruleType, argument);

            if (ruleInstance != null)
            {
                result = ruleInstance.ApplyRule(result);
            }
            else
            {
                Console.WriteLine($"Unknown rule: {ruleType}. Skipping.");
            }
        }

        return result;
    }

    private IRule GetRuleInstance(string ruleType, string argument)
    {
        switch (ruleType.ToLower())
        {
            case "class":
                // Handle class rule, Isogram/Palindrome/Semordnilap
                return GetClassRule(argument);

            case "maxlength":
                int.TryParse(argument, out int maxLength);
                return new MaxLengthRule(maxLength);

            case "minlength":
                int.TryParse(argument, out int mintResult);
                return new MinLengthRule(mintResult);

            case "startswith":
                return new StartWithRule(argument);

            case "endswith":
                return new EndWithRule(argument);

            case "containsonly":
                return new ContainOnlyRule(argument);

            default:
                Console.WriteLine($"Unknown rule type: {ruleType}");
                return null;
        }

        return null;
    }

    private IRule GetClassRule(string argument)
    {
        switch (argument.ToLower())
        {
            case "isogram":
                return new IsogramRule();

            case "palindrome":
                return new PalindromeRule();

            case "semordnilap":
                return new SemordnilapRule();

            default:
                Console.WriteLine($"Unknown class rule argument: {argument}");
                return null;
        }
    }
}