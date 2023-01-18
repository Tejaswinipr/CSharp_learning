
using System;
using System.Linq;

public class LinqSqNum
{
    public static void Main(string[] args)
    {
        int[] arr={1,2,-3,-4,5,-6,7,-8,9,10,-11,12,-13,14,15};
        var arrQuery= from num in arr
                        let sqNum=num*num
                        where (sqNum>50)
                        select new {num,sqNum};
                        
        foreach(var a in arrQuery){
            Console.WriteLine(a);
        }
        Console.WriteLine("\n");
    }
}
