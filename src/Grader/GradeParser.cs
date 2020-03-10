using Grader.Exception;

namespace Grader.Parser
{
  public class GradeParser
  {
    public static double Parse(string unparsedGrade)
    {
      try
      {
        return double.Parse(unparsedGrade);
      }
      catch
      {
        throw new GraderFormatException($"Unable to convert \"{unparsedGrade}\" to \"double\". Please enter valid grades only.");
      }
    }
  }
}