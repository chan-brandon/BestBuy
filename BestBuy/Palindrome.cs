using System;
namespace BestBuy
{
    public class Palindrome
    {
        public bool IsThisAPalindrome(string word)
        {
            string tester = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                tester += word[i];
            }
            if (tester != word)
            {
                return false;
            }
            return true;
        }
    }
}
