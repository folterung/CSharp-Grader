using Grader.Statistics;
using Xunit;

namespace Grader.Tests
{
  public class GradeStatisticsTests
  {
    [Fact]
    public void CreateTest()
    {
      Assert.IsType<GradeStatistics>(GradeStatistics.Create());
    }

    [Fact]
    public void DefaultValuesTest()
    {
      var stats = GradeStatistics.Create();

      Assert.Equal(0, stats.Average);
      Assert.Equal(0, stats.High);
      Assert.Equal(0, stats.Low);
      Assert.Equal(0, stats.Total);
    }
  }
}