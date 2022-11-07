using System;
using System.Reflection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Sample {
        public int test = 1;
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sample = new Sample();
            FieldInfo[] fields = sample.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public);
            foreach (var field in fields) {
                Console.WriteLine(field.Name);
            }
        }
    }
}