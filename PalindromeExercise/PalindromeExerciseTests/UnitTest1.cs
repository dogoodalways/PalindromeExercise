using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void PalindromeTester(string word, bool expected)
        {
            // Arrange
            WordSmith smith = new WordSmith();

            // Act
            bool actual = smith.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }
    }

}
    
