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
            var expectedResult = "radar";
            var palindromeCheck = new PalindromeTester();
            //act
            var actualResult = palindromeCheck.Test(word);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void multiple_words_read_the_same_forwards_and_backwards_but_with_no_spaces()
        {
            //arrange
            var word = "race car";
            var expectedResult = "racecar";
            var palindromeCheck = new PalindromeTester();
            //act
            var actualResult = palindromeCheck.Test(word);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void capital_letters_are_changed_to_lower_case()
        {
            //arrange
            var word = "rAce Car";
            var expectedResult = "racecar";
            var palindromeCheck = new PalindromeTester();
            //act
            var actualResult = palindromeCheck.Test(word);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("race car", "racecar")]
        [InlineData("No X IN NIXON", "noxinnixon")]
        [InlineData("O, a kakao!","oakakao")]
        public void test_if_a_given_string_is_a_palindrome(string input, string expectedResult)
        {
            //arrange
            var palinderomTester = new PalindromeTester();
            //act
            var actualResult = palinderomTester.Test(input);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
