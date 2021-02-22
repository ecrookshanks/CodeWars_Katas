using System;
using Xunit;

namespace Katas.Tests
{
  public class JadenCaseTests
  {
    // Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
    // Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"

    [Fact]
    public void TestCapitalSingleWord()
    {
      String nonCap = "capitol";
      String cap = "Capitol";

      String result = CapProcessor.CapitalizeSingleString(nonCap);

      Assert.Equal(cap, result);

    }

    [Fact]
    public void TestCapitalizeEntireSentence()
    {
      String test = "How can mirrors be real if our eyes aren't real";
      String Desired = "How Can Mirrors Be Real If Our Eyes Aren't Real";

      String result = CapProcessor.CapitalizeSentence(test);

      Assert.Equal(Desired, result);
    }

    [Fact]
    public void TestCapsByLinq()
    {
      String test = "How can mirrors be real if our eyes aren't real";
      String Desired = "How Can Mirrors Be Real If Our Eyes Aren't Real";

      String result = CapProcessor.CapitalizeSentence(test);

      Assert.Equal(Desired, result);
    }

    [Fact]
    public void TestShortestCapsByLinq()
    {
      String test = "How can mirrors be real if our eyes aren't real";
      String Desired = "How Can Mirrors Be Real If Our Eyes Aren't Real";

      String result = CapProcessor.ShortestCapVersion(test);

      Assert.Equal(Desired, result);
    }
  }
}
