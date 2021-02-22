using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace Katas.Tests
{
  //
  // Your task is to make a function that can take any non-negative integer 
  // as an argument and return it with its digits in descending order. Essentially, 
  // rearrange the digits to create the highest possible number.
  //
  //Examples:
  //Input: 42145 Output: 54421

  //Input: 145263 Output: 654321

  //Input: 123456789 Output: 987654321

  public class DescendTest
  {
    [Fact]
    public void ArrangeLargestNumberPossible()
    {
      int bigNum = 42145;
      int desired = 54421;

      String num = bigNum.ToString();
      char[] digits = num.ToCharArray();
      Array.Sort(digits);
      Array.Reverse(digits);
      int result = Int32.Parse(digits);

      Assert.Equal(desired, result);

    }

    [Fact]
    public void ArrangeUsingLinq()
    {
      int bigNum = 42145;
      int desired = 54421;

      // char[] digits = bigNum.ToString().ToCharArray();
      var dig = (from d in bigNum.ToString().ToCharArray()
                 orderby d descending
                 select d).ToArray();

      int result = Int32.Parse(dig);

      Assert.Equal(desired, result);
    }
  }
}
