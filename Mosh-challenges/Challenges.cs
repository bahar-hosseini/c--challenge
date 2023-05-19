namespace CSharpExercises
{
  public class Exercise
  {
    static void Main(string[] args)
    {
      //challenge StringExercises
      string s = "The quick brown fox jumps over the lazy dog.";
      var summary = Program.SummarizingText(s, 10);
      System.Console.WriteLine(summary);
      StringsChallenge.Exercise1();
    }
  }

}