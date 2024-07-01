namespace Enumerable
{
    internal class Program
    {
        private static IEnumerable<Student> GetStudentsYeld() 
        {
            yield return new Student("Eugene");
            yield return new Student("Maxim");
            yield return new Student("Igor");
            yield return new Student("Ilia");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("IEnumerator object:");
            Students students = new Students();
            students.Add(new Student("Olga"));
            students.Add(new Student("Elena"));
            students.Add(new Student("Maria"));
            students.Add(new Student("Yulia"));

            while (students.MoveNext())
            {
                Console.WriteLine(students.Current);
            }

            Console.WriteLine("IEnumerable object:");
            foreach (Student student in GetStudentsYeld())
            {
                Console.WriteLine(student);
            }
        }
    }
}
