using System;
using System.Linq;

public class LinqNumGreater
{
    public static void Main(string[] args)
    {
        int[] arr={55, 200, 740, 76, 230, 482, 95};
        var nQuery=from num in arr
                    where num>80
                    select num;
        Console.WriteLine("The Numbers greater than 80 are ");
        foreach (var i in nQuery)
        {
          Console.WriteLine("{0} ",i);  
        }
    }
}
