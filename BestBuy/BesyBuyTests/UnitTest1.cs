using System;
using BestBuy;
using Xunit;

namespace BesyBuyTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("noon", true)]
        [InlineData("dogged", false)]
        public void IsThisAPalindrome(string word, bool expected)
        {
            var palindrome = new Palindrome();

            var actual = palindrome.IsThisAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }

    public class UnitTest2
    {
        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(90, 10, 100)]
        [InlineData(11, 11, 22)]
        public void SumOfNumbers(int num1, int num2, int expected)
        {
            var summation = new CashRegister();

            var result = summation.SumOfNumbers(num1, num2);

            Assert.Equal(expected, result);
        }
    }
}
