namespace Enumerable
{
    public class Student
    {
        private string Name { get; init; }
        public Student(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
