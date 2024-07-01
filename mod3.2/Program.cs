namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 0, f1 = 1, f2 = 0;
            do
            {
                Console.WriteLine(summ);
                summ = f1 + f2;
                f1 = f2;
                f2 = summ;
            }
            while (summ < 1000);
        }
    }
}
