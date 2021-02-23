using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double n = 100;
            double resultado = 0;

            for(int i = 0; i<=n; i++)
              {
                resultado += (Math.Pow(x, i)) / Factorial(i);
                Console.WriteLine(resultado);
              }


        }

        static double Factorial(double valor)
        {
            double total = 1;
            for(int i = 1; i <= valor; i++)
            {
                total *= i;
            }
            return total;
        }
    }
}
