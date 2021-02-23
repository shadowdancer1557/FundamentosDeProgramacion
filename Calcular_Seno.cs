using System;

namespace Calcular_Seno
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.5;
            int n = 1000;
            double resultado = 0;
            for(int i =0;i<=n; i++)
            {
                resultado += (Math.Pow(-1, i) / Factorial((2 * i) + 1)) * Math.Pow(x, (2 * i) + 1);
            }
            Console.WriteLine(resultado);
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
