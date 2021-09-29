using System;
using Xunit;

namespace Palindromes.test
{
    public class UnitTest1
    {
        [Fact]
        public void single_words_read_the_same_forwards_and_backwards()
        {
            //arrange
            var word = "radar";
            bool expectedResult = true;
            var palindromeCheck = new PalindromeTester();
            //act
            bool actualResult = palindromeCheck.Test(word);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void multiple_words_read_the_same_forwards_and_backwards_but_with_no_spaces()
        {
            //arrange
            var word = "race car";
            bool expectedResult = true;
            var palindromeCheck = new PalindromeTester();
            //act
            bool actualResult = palindromeCheck.Test(word);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void capital_letters_are_changed_to_lower_case()
        {
            //arrange
            var word = "rAce Car";
            bool expectedResult = true;
            var palindromeCheck = new PalindromeTester();
            //act
            bool actualResult = palindromeCheck.Test(word);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("race car", true)]
        [InlineData("No X IN NIXON", true)]
        [InlineData("O, a kakao!", true)]
        [InlineData("flkjasdf;kajd;flkj;jfkfkfl", false)]
        public void test_if_a_given_string_is_a_palindrome(string input, bool expectedResult)
        {
            //arrange
            var palinderomTester = new PalindromeTester();
            //act
            bool actualResult = palinderomTester.Test(input);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
