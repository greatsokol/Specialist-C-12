using System.Collections;

namespace Enumerable
{
    public class Students : IEnumerator<Student>
    {
        private List<Student> students;
        private int current;

        public Students()
        {
            students = new List<Student>();
            current = -1;
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public Student Current => students[current];

        object IEnumerator.Current => students[current];

        public void Dispose()
        {
            students.Clear();
        }

        public bool MoveNext()
        {
            if (current < students.Count-1) 
            { 
                current++; 
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
