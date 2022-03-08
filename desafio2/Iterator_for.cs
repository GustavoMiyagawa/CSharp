using System;

namespace desafio2
{
    public class Iterator_for
    {
        public void Set_Interator_for(int[] num)
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
                    break;
                }
            }
        }

        public void Set_Interator_for(double[] num)
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
                    break;
                }
            }
        }
    }
}