using System;
using System.Collections.Generic;
using System.Linq;

public class LinqNumGreList
{
    public static void Main(string[] args)
    {
        List<int> arr=new List<int>();
        Console.WriteLine("Input the number of members on the List:");
        int n=int.Parse(Console.ReadLine());
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Member {0}:",i);
            int t=int.Parse(Console.ReadLine());
            arr.Add(t);
        }
        Console.WriteLine("Input the above you want to display the members of the List:");
        int s=int.Parse(Console.ReadLine());
        
        List<int> queryList=arr.FindAll(a => a > s ? true : false);
        
        Console.WriteLine("The Numbers greater than {0} are ",s);
        foreach (var i in queryList)
        {
          Console.WriteLine(i);  
        }
    }
}
