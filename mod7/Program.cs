using System.Reflection;
using System.Text;

namespace Reflection
{
    internal class Program
    {
        static void PrintMethods(string ClassName)
        {
            Type type = Type.GetType(ClassName);
            if (type == null)
            {
                Console.WriteLine($"{ClassName} type not found");
                return;
            }
            Console.WriteLine($"Methods of object of \"{ClassName}\" class:");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                ParameterInfo[] parameters = method.GetParameters();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (ParameterInfo param in parameters)
                {
                    stringBuilder.Append(param.ParameterType.Name).
                        Append(" ").Append(param.Name).Append(", ");
                }
                if (stringBuilder.Length > 2)
                {
                    stringBuilder.Remove(stringBuilder.Length - 2, 2);
                }

                Console.WriteLine($"\t{method.ReturnType.Name} {method.Name}({stringBuilder})");
            }
        }

        static void ConvertingInt2Boolean()
        {
            Console.WriteLine("\n\nConvert:");
            bool IsOk = Convert.ToBoolean(1);
            bool IsNotOk = Convert.ToBoolean(0);
            Console.WriteLine($"\t1={IsOk} 0={IsNotOk}");
        }

        static void WatchingForDestruction()
        {
            void foo()
            {
                FinalizingClass fc = new FinalizingClass();
            }

            Console.WriteLine("\nGC examination:");
            foo();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        static void Main(string[] args)
        {
            PrintMethods("System.String");
            ConvertingInt2Boolean();
            WatchingForDestruction();
        }
    }
}
