using System;

namespace CodeWars_Katas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("This is the console app - kata tests will *mainly* be implemented as unit tests.");
      Console.WriteLine("This is a writeline statement from VS Code");

      int sum = SimpleMath.SumOfAll3and5Factors(1000);
      Console.WriteLine("The sum of all 3 and 5 factors is: " + sum);
    }
  }
}
