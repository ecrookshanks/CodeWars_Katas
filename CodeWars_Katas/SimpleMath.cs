
namespace CodeWars_Katas
{

  public class SimpleMath
  {
      public static int SumOfAll3and5Factors(int maxNum)
      {
        int num = 0;
        for (int i = 0; i < maxNum; i++)
        {
            if ( i%3 == 0 || i%5 == 0)
            {
              num += i;
            }
        }
        return num;
      }
  }

}