using System;
using System.Collections.Generic;
using System.Linq;

public class LinqNumGreater
{
    public static void Main(string[] args)
    {
        List<int> arr=new List<int>();
        arr.Add(55);
        arr.Add(200);
        arr.Add(740);
        arr.Add(76);
        arr.Add(230);
        arr.Add(482);
        arr.Add(95);
        List<int> queryList=arr.FindAll(a => a > 80 ? true : false);
        
        Console.WriteLine("The Numbers greater than 80 are ");
        foreach (var i in queryList)
        {
          Console.WriteLine(i);  
        }
    }
}
