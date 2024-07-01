namespace DateWithOperators
{
    internal class Program
    {
        static void TestComparitions(Date d1, Date d2)
        {
            Console.WriteLine($"{d1} == {d2} = {d1 == d2}");
            Console.WriteLine($"{d1} > {d2} = {d1 > d2}");
            Console.WriteLine($"{d1} < {d2} = {d1 < d2}");
            Console.WriteLine($"{d1} >= {d2} = {d1 >= d2}");
            Console.WriteLine($"{d1} <= {d2} = {d1 <= d2}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestComparitions(new Date(1, 1, 2024), new Date(1, 1, 2024));
            TestComparitions(new Date(1, 1, 2024), new Date(1, 1, 2025));
            TestComparitions(new Date(1, 1, 2025), new Date(1, 2, 2025));
            TestComparitions(new Date(1, 2, 2025), new Date(2, 2, 2025));
        }
    }
}
