using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchEngine
{
    public class PalindromeRule
    {
        public List<string> ApplyRule(List<string> words) => words.Where(word => IsPalindrome(word)).ToList();

        private bool IsPalindrome(string word) => false; //TODO: Implement palindrome check logic
    }
}
