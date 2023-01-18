using System;
using System.Collections.Generic;
using System.Linq;

public class LinqNumUserGre
{
    public static void Main(string[] args)
    {
        List<int> list=new List<int>();
        Console.WriteLine("Input the number of members on the List:");
        int n=int.Parse(Console.ReadLine());
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Member {0}:",i);
            int t=int.Parse(Console.ReadLine());
            list.Add(t);
        }
        
        list.Sort();
        list.Reverse();
        
        Console.WriteLine("How many records you want to display ? :");
        int num=int.Parse(Console.ReadLine());
        
        Console.WriteLine("The top {0} records from the list are : ",num);
        foreach (int i in list.Take(num))
        {
          Console.WriteLine("{0}",i);  
        }
    }
}
