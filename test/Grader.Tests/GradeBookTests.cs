using Xunit;
using System.Collections.ObjectModel;

namespace Grader.Tests
{
  public class GradeBookTests
  {
    string[] sampleArgs = new[] { "32.1", "87.5", "56.25", "98.23", "42.78", "17.48", "57.14" };
    double[] sampleParsedArgs = new[] { 32.1, 87.5, 56.25, 98.23, 42.78, 17.48, 57.14 };

    [Fact]
    public void CreateTest()
    {
      Assert.IsType<GradeBook>(GradeBook.Create(sampleArgs));
    }

    [Fact]
    public void StatisticsTest()
    {
      var gradeBook = GradeBook.Create(sampleArgs);
      var stats = gradeBook.Statistics();

      Assert.Equal(55.93, stats.Average, 2);
      Assert.Equal(98.23, stats.High, 2);
      Assert.Equal(17.48, stats.Low, 2);
      Assert.Equal(391.48, stats.Total, 2);
    }

    [Fact]
    public void GradesTest()
    {
      var gradeBook = GradeBook.Create(sampleArgs);
      var expectedGrades = new ReadOnlyCollection<double>(sampleParsedArgs);

      Assert.Equal(expectedGrades, gradeBook.Grades);
    }
  }
}
