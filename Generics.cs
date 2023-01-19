using System;

public class Generics
{
    public static void Main(string[] args)
    {
        int[] i={1,2,3};
        double[] d={5,6,7};
        string[] s={"a", "b","c"};
        add(i);
        add(d);
        add(s);
    }
    public static void add<T>(T[] arr){
        foreach(T a in arr){
            Console.WriteLine ("{0}",a);
        }
        Console.WriteLine("\n");
    }
}
