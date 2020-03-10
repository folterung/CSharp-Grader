using System;

namespace Grader
{
  class GraderCli
  {
    static void Main(string[] args)
    {
      var gradeBook = GradeBook.Create(args);
      var stats = gradeBook.Statistics();

      Console.WriteLine("============================");
      Console.WriteLine($"Grade(s) average: {stats.Average:N2}");
      Console.WriteLine($"Grade(s) highest grade: {stats.High:N2}");
      Console.WriteLine($"Grade(s) lowest grade: {stats.Low:N2}");
      Console.WriteLine($"Grade(s) total: {stats.Total:N2}");
    }
  }
}
