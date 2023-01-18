// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class LinqFreq
{
    public static void Main(string[] args)
    {
        int[] arr={3,2,4,4,5,2,5,6,7,3,2,4,2,6};
        
        var fQuery=from num in arr
                    group num by num into y
                    select y;
        
        foreach (var a in fQuery)
        {
            Console.WriteLine("Number "+a.Key+" appears "+a.Count()+" times");
        }
    }
}
