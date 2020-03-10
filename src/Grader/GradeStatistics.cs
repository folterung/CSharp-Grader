namespace Grader.Statistics
{
  public class GradeStatistics
  {
    public double Average;
    public double High;
    public double Low;

    public double Total;

    public static GradeStatistics Create()
    {
      return new GradeStatistics();
    }
  }
}