using System;
using System.Collections.Generic;
using Grader.Parser;
using Grader.Statistics;
using System.Collections.ObjectModel;
using Grader.Exception;

namespace Grader
{
  public class GradeBook
  {
    private List<double> grades;

    public static GradeBook Create(string[] grades)
    {
      return new GradeBook(grades);
    }

    public GradeBook(string[] grades)
    {
      if (isValidArgs(grades))
      {
        this.grades = convertToGrades(grades);
      }
      else
      {
        throw new GraderFormatException("Invalid argument list, please provide grades in the format: \"41.6 37.9 23 19\"");
      }
    }

    public ReadOnlyCollection<double> Grades
    {
      get
      {
        return grades.AsReadOnly();
      }
    }

    public GradeStatistics Statistics()
    {
      var stats = GradeStatistics.Create();

      stats.High = double.MinValue;
      stats.Low = double.MaxValue;

      foreach (double grade in grades)
      {
        stats.High = Math.Max(grade, stats.High);
        stats.Low = Math.Min(grade, stats.Low);
        stats.Total += grade;
      }

      stats.Average = grades.Count == 0 ? 0 : stats.Total / grades.Count;

      return stats;
    }

    private List<double> convertToGrades(string[] unparsedGrades)
    {
      var parsedGrades = new List<double>();

      foreach (string unparsedGrade in unparsedGrades)
      {
        parsedGrades.Add(GradeParser.Parse(unparsedGrade));
      }

      return parsedGrades;
    }

    private Boolean isValidArgs(string[] args)
    {
      return args.Length > 0;
    }
  }
}