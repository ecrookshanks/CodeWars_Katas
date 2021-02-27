using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Katas.Tests
{
  public class AlgorithmTests
  {
    [Fact]
    public void TestDivisors()
    {
      Assert.Equal(new int[] { 3, 5 }, Algorithms.Divisors(15));
      Assert.Equal(new int[] { 2, 4, 8 }, Algorithms.Divisors(16));
      Assert.Equal(new int[] { 11, 23 }, Algorithms.Divisors(253));
      Assert.Equal(new int[] { 2, 3, 4, 6, 8, 12 }, Algorithms.Divisors(24));
    }

    [Theory]
    [InlineData(155, -1)]
    [InlineData(121,  144)]
    [InlineData(625, 676)]
    [InlineData(319225, 320356)]
    [InlineData(15241383936, 15241630849)]
    public static void FixedTest(long num, long expected)
    {
      long result =  Algorithms.FindNextSquare(num);

      Assert.Equal(expected, result);
    }

    [Fact]
    public static void ValidPrintControlString() 
    {
        Console.WriteLine("Testing PrinterError");
        string s="aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
        Assert.Equal("3/56", Algorithms.PrinterError(s));
    }

    [Fact]
    public void BasicTestsFirstNonRepeatingChar()
    {
      Assert.Equal("a", Algorithms.FirstNonRepeatingLetter("a"));
      Assert.Equal("t", Algorithms.FirstNonRepeatingLetter("stress"));
      Assert.Equal("e", Algorithms.FirstNonRepeatingLetter("moonmen"));
      Assert.Equal("E", Algorithms.FirstNonRepeatingLetter("EFDDB"));
      Assert.Equal("\u007f", Algorithms.FirstNonRepeatingLetter(
        "\u007faKruoZhit{i`AMWXSigGkeJ\\LvVKq ^ AQ"));
    }
  }
}
