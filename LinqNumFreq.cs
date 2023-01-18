using System;
using System.Linq;

public class LinqNumFreq
{
    public static void Main(string[] args)
    {
        int[] arr={2,3,2,4,2,2,7,6,4,5,9,6,7,9,5,7,9,5,2,9};
        
        var nQuery=from num in arr
                    group num by num into x
                    select x;
                    
        foreach (var i in nQuery)
        {
            Console.WriteLine(i.Key+" "+(i.Key*i.Count())+" "+i.Count());
        }
    }
}
