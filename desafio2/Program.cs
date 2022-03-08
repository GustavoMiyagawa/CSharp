using System;

namespace desafio2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double[] numeros = { 6.2, 4.3, 9.7, 2.4, 12.1 };

      // int[] numeros = { 6, 4, 9, 2, 12 };

      Iterator_for itera = new Iterator_for();

      itera.Set_Interator_for(numeros);

      // Console.WriteLine($"valor de {Helper.var_global} para ASCII: {Helper.int_to_ASCII()}");

      // Yield_method.Iterator_yield(numeros);

      Console.WriteLine($"valor de {Helper.var_global} para ASCII: {Helper.int_to_ASCII()}");

      Console.ReadLine();
    }
  }
}