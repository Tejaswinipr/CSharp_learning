using System;
using System.Linq;

public class WeekDays
{
    public static void Main(string[] args)
    {
        string[] s={"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        
        var wQuery= from a in s
                    select a;
        
        foreach (var i in s)
        {
            Console.WriteLine(i);
        }
    }
}
