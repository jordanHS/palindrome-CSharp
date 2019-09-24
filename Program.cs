using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Type a word and we'll check wehter it's a palindrome.");
    string userInput = Console.ReadLine();
    bool result = isPalindrome(userInput);
    if(result)
    {
      Console.WriteLine("This is a palindrome.");
    }
    else
    {
      Console.WriteLine("This is NOT a palindrome.");
    }
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