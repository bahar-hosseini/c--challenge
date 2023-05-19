using System;
using System.Collections.Generic;
namespace CSharpExercises
{
  public class Program
  {

    public static string SummarizingText(string text, int maxLength)
    {
      if (text.Length < maxLength)
        return text;
      var summarized = text.Split(' ');
      var totalChar = 0;
      var summaryWords = new List<string>();
      foreach (var word in summarized)
      {
        summaryWords.Add(word);
        totalChar += word.Length + 1;
        if (totalChar > maxLength)
          break;
      }
      return String.Join(' ', summaryWords) + " ...";
    }
  }
}
