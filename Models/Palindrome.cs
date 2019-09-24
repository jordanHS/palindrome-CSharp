using System;

namespace Palindrome.Models
{
  class Palindromes
  {
    public string UserInput;

    public Palindromes(string userInput)
    {
      UserInput = userInput;
    }

    public static bool isPalindrome(string userInput)
    {
      char[] wordArray = userInput.ToCharArray();
      Array.Reverse(wordArray);
      string reversedWord = new string(wordArray);
      if (userInput == reversedWord)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}