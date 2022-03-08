using System.Collections.Generic;

namespace desafio2
{
    public class Yield_method
    {
        public static IEnumerable<int> Iterator_yield(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Helper.var_global += num[i];
                    Console.WriteLine("check");
                }
                if (num[i] % 2 == 1)
                {
                    continue;
                }
                if (Helper.IsPrime(num[i]))
                {
                    yield break;
                }
            }
        }

        public static IEnumerable<double> Iterator_yield(double[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if ((int)num[i] % 2 == 0)
                {
                    Helper.var_global += (int)num[i];
                    Console.WriteLine("check");
                }
                if ((int)num[i] % 2 == 1)
                {
                    continue;
                }
                if (Helper.IsPrime((int)num[i]))
                {
                    yield break;
                }
            }
        }
    }
}