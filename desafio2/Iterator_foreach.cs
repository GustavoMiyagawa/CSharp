namespace desafio2
{
    public class Iterator_foreach
    {
        public void Set_Interator_foreach(int[] num)
        {
            foreach (var n in num)
            {
                if (n % 2 == 0)
                {
                    Helper.var_global += n;
                    Console.WriteLine("check");
                }
                if (n % 2 == 1)
                {
                    continue;
                }
                if (Helper.IsPrime(n))
                {
                    break;
                }
            }
        }

        public void Set_Interator_foreach(double[] num)
        {
            foreach (var n in num)
            {
                if ((int)n % 2 == 0)
                {
                    Helper.var_global += (int)n;
                    Console.WriteLine("check");
                }
                if ((int)n % 2 == 1)
                {
                    continue;
                }
                if (Helper.IsPrime((int)n))
                {
                    break;
                }
            }
        }
    }
}