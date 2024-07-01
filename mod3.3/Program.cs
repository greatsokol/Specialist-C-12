using System.Numerics;

namespace Factorial
{
    internal class Program
    {
        static BigInteger FactorialCycle(BigInteger n)
        {
            BigInteger f = 1;
            for (BigInteger x = 1; x <= n; x++)
            {
                f = f * x;
            }
            return f;
        }

        static BigInteger FactorialRecursive(BigInteger n)
        {
            return n == 1 ? 1 : n * FactorialRecursive(n-1);
        }



        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите число:");
                string StrN = Console.ReadLine();
                BigInteger n = BigInteger.Parse(String.IsNullOrEmpty(StrN) ? "0" : StrN);
                Console.WriteLine($"Факториал, вычисленный циклом:\n{FactorialCycle(n)}");
                Console.WriteLine($"Факториал, вычисленный рекурсией:\n{FactorialRecursive(n)}");
            }
            while (true);
        }
    }
}
