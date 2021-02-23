using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Katas.Tests
{
  public class SpinnerTests
  {
    [Fact]
    public static void Test1()
    {
      Assert.Equal("emocleW", Algorithms.SpinWords("Welcome"));
    }

    [Fact]
    public static void Test2()
    {
      Assert.Equal("Hey wollef sroirraw", Algorithms.SpinWords("Hey fellow warriors"));
    }

    [Fact]
    public static void Test3()
    {
      Assert.Equal("This is a test", Algorithms.SpinWords("This is a test"));
    }

    [Fact]
    public static void Test4()
    {
      Assert.Equal("This is rehtona test", Algorithms.SpinWords("This is another test"));
    }

    [Fact]
    public static void Test5()
    {
      Assert.Equal("You are tsomla to the last test", Algorithms.SpinWords("You are almost to the last test"));
    }

    [Fact]
    public static void Test6()
    {
      Assert.Equal("Just gniddik ereht is llits one more", Algorithms.SpinWords("Just kidding there is still one more"));
    }
  }
}
