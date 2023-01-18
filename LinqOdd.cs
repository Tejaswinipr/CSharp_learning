
using System;
using System.Linq;

public class LinqOdd
{
    public static void Main(string[] args)
    {
        int[] arr={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
        var arrQuery= from a in arr
                        where(a%2!=0)
                        select a;
                        
        foreach(int a in arrQuery){
            Console.WriteLine("{0}",a);
        }
        Console.WriteLine("\n");
    }
}
