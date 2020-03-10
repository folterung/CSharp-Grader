using Grader.Parser;
using Xunit;

namespace Grader.Tests
{
  public class GradeParserTests
  {
    [Fact]
    public void ParseTest()
    {
      Assert.Equal(32.1, GradeParser.Parse("32.1"));
      Assert.Equal(93.25, GradeParser.Parse("93.25"));
      Assert.Equal(84.569, GradeParser.Parse("84.569"));
    }

    [Fact]
    public void ParseErrorTest()
    {
      try
      {
        GradeParser.Parse("spaghetti");
      }
      catch (System.Exception ex)
      {
        Assert.Contains("Unable to convert \"spaghetti\" to \"double\". Please enter valid grades only.", ex.Message);
      }
    }
  }
}