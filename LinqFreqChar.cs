
using System;
using System.Linq;

public class LinqFreqChar
{
    public static void Main(string[] args)
    {
        string s="tejaswini";
        
        var fQuery=from x in s
                    group x by x into y
                    select y;
        
        foreach (var a in fQuery)
        {
            Console.WriteLine("Character "+a.Key+":"+a.Count()+" times");
        }
    }
}
