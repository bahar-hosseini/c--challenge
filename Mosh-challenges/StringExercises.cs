using System;

namespace CSharpExercises
{
  /// Challenge1:
  /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
  /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
  /// display a message: "Consecutive"; otherwise, display "Not Consecutive".

  public class StringsChallenge
  {
    public static void Exercise1()
    {
      Console.WriteLine("Write a few numbers separated by a hyphen:");
      var numbers = Console.ReadLine();
      var split = numbers.Split('-');

      if (IsConsecutive(split))
      {
        Console.WriteLine("Consecutive");
      }
      else
      {
        Console.WriteLine("Not Consecutive");
      }

    }


    static bool IsConsecutive(string[] stringArray)
    {
      int[] intArray = Array.ConvertAll(stringArray, int.Parse);
      if (intArray.Length <= 1)
      {
        return true;
      }

      int difference = intArray[1] - intArray[0];
      for (var i = 0; i < intArray.Length - 1; i++)
      {
        if (intArray[i + 1] - intArray[i] != difference)
        {
          return false;
        }
      }
      return true;
    }

  }
}