using System;
namespace learning
{
    public class DynamicType
    {
        public static void add(dynamic a, dynamic b)
        {
            Console.WriteLine("Sum:" + (a + b));
        }
        public static void Main(string[] args)
        {
            dynamic d1 = 123;
            dynamic d2 = "adc";
            dynamic d3 = 12.3;
            dynamic d4 = true;
            Console.WriteLine(d1.GetType());
            Console.WriteLine(d2.GetType());
            Console.WriteLine(d3.GetType());
            Console.WriteLine(d4.GetType());
            add(4, 89.7);
        }
    }
}


