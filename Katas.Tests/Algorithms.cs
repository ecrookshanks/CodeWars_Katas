using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas.Tests
{
  public class Algorithms
  {
    public static int[] Divisors(int n)
    {
      // only check to the square root
      int maxCheck = (int)Math.Floor((Math.Sqrt(n)));
      List<int> arr = new List<int>();

      for (int i = 2; i <= maxCheck; i++)
      {
        if (n % i == 0)
        {
          // add the divisor
          arr.Add(i);

          // check and add the result as well (if not the same
          // as the divisor)
          if (i != n/i)
          {
            arr.Add(n / i);
          }
        }
      }

      if (arr.Count == 0)
        return null;
      else
      {
        int[] sorted = arr.ToArray();
        Array.Sort(sorted);
        return sorted;
      }
    }

    public static String SpinWords(string sentence)
    {
      String[] words = sentence.Split(" ");
      StringBuilder builder = new StringBuilder();
      foreach (var item in words)
      {
        String toAdd = item;
        if(item.Length>=5)
        {
          toAdd = new string(item.ToCharArray().Reverse().ToArray());
        }
        builder.Append(toAdd);
        builder.Append(" ");
      }

      return builder.ToString().Trim();
    }

    public static long FindNextSquare(long num)
    {
      long sqrt = (long)Math.Sqrt(num);

      if (sqrt*sqrt != num)
      {
        return -1;
      }
      else
      {
        return (sqrt + 1) * (sqrt + 1);
      }
    }

    public static string PrinterError(String s) 
    {
      int len = s.Length;
      //string valid = "[a-m]";
      string invalid = "[n-z]";

      //Match matchGood = Regex.Match(s, valid);
      MatchCollection matchBad = Regex.Matches(s, invalid);

      return matchBad.Count + "/" + len;
    }
  }
 
 }
