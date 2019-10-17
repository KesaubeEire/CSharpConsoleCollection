using System;
using System.Collections.Generic;

namespace CsharpTest002
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass a1 = new MyClass();
            int a2 = 10;
            MyMethod(ref a1, ref a2);
            Console.WriteLine($"f1.Value : {a1.Value} f2: {a2}");
        }

        static void MyMethod(ref MyClass f1, ref int f2)
        {
            f1.Value += 5;
            f2 += 5;
            Console.WriteLine($"f1.Value : {f1.Value} f2: {f2}");
        }

        public class MyClass
        {
            public int Value = 25;
            public List<int> _List = new List<int>();
        }
    }
}