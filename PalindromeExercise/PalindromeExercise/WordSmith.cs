using System;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            word = word.ToLower();

            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            
                reversed += word[i];
            

            return word == reversed;
        }
    }
}