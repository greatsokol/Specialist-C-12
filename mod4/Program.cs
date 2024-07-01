namespace LaunchParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            foreach (var arg in args)
            {
                Console.WriteLine($"Параметр: {arg}");
                int param;
                if (int.TryParse(arg, out param))
                {
                    sum += param;
                }
            }
            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
