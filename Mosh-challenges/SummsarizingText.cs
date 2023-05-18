using System;

namespace Summarizing
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = "The quick brown fox jumps over the lazy dog.";
      var summary = SummarizingText(s, 10);
      System.Console.WriteLine(summary);
    }
    static string SummarizingText(string text, int maxLength)
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
