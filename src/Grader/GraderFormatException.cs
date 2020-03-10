
namespace Grader.Exception
{
  public class GraderFormatException : System.FormatException
  {
    public GraderFormatException() { }

    public GraderFormatException(string message) : base(message) { }

    public GraderFormatException(string message, System.Exception innerException) : base(message, innerException) { }
  }
}