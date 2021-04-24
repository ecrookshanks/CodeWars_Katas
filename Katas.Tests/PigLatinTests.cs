using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Katas.Tests
{
  public class PigLatinTests
  {
    [Fact]
    public void KataTests()
    {
      Assert.Equal("igPay atinlay siay oolcay", Algorithms.PigIt("Pig latin is cool"));
      Assert.Equal("hisTay siay ymay tringsay", Algorithms.PigIt("This is my string"));

      Assert.Equal("elloHay orldway !", Algorithms.PigIt("Hello world !"));
    }
  }
}
