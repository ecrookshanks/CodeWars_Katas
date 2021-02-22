using System;
using System.Linq;
using System.Text;

namespace Katas.Tests
{
  public class CapProcessor
  {
    public static string CapitalizeSingleString(string nonCap)
    {
      String allLower = nonCap.ToLower();
      string firstUpper = allLower[0].ToString().ToUpper();
      String result = firstUpper + allLower.Substring(1);

      return result;

    }

    public static string CapitalizeSentence(string test)
    {
      String[] words = test.Split(" ");
      for(int i = 0; i< words.Length; i++)
      {
        words[i] = CapitalizeSingleString(words[i]);
      }

      StringBuilder sb = new StringBuilder();

      foreach(var w in words)
      {
        sb.Append(w);
        sb.Append(" ");
      }

      return sb.ToString().Trim();

    }

    public static string CapitalizeSentanceWithLinq(string sentence)
    {
      string[] words = sentence.Split(" ");

      words.Select(n => CapitalizeSingleString(n) + " ");
      return String.Concat(words).Trim();
    }

    public static String ShortestCapVersion(string sentence)
    {
      var qq = from w in sentence.Split(" ")
               let first = w[0].ToString().ToUpper()
               let rest = w.Substring(1).ToLower()
               select first + rest;

      return String.Join(" ", qq);

    }
  }
}