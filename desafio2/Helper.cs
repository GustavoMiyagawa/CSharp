namespace desafio2
{
    public class Helper
    {
        public static int var_global = 0;

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static char int_to_ASCII()
        {
            int div = var_global;
            while (div > 127)
            {
                //div = div / 2;
                div /= 2;
            }
            return (char)div;
        }
    }
}
