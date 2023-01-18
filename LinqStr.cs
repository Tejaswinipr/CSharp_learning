using System;
using System.Linq;

public class LinqStr
{
    public static void Main(string[] args)
    {
        string[] c={"India","Canada","England","Germany","Kajikisthan","Maldives","Indonesia","Kazakasthan"};
        Console.WriteLine("Input starting character for the string:");
        string s=Console.ReadLine();
        Console.WriteLine("Input ending character for the string:");  
        string e=Console.ReadLine();
        
        var sQuery=from str in c
                    where str.StartsWith(s)
                    where str.EndsWith(e)
                    select str;
                    
        Console.WriteLine("Countries starting with {0} and ending with {1} is/are",s,e);
        foreach (var i in sQuery)
        {
          Console.WriteLine("{0}",i);  
        }
    }
}
