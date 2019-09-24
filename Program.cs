using System;
using Palindrome.Models;

namespace Palindrome
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Type a word and we'll check wehter it's a palindrome.");
      string userInput = Console.ReadLine();
      // Palindromes palindrome = new Palindromes(userInput);
      bool result = Palindromes.isPalindrome(userInput);
      if(result)
      {
        Console.WriteLine("This is a palindrome.");
      }
      else
      {
        Console.WriteLine("This is NOT a palindrome.");
      }
    }
  }
}