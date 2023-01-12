//Enum

using System;

public class EnumProject
{
    enum weekdays{
        Sunday,
        Monday,
        Tuesday,
        Wednesday=10,
        Thursday,
        Friday,
        Saturday
    }
    public static void Main(string[] args)
    {
    weekdays day=weekdays.Wednesday;
    Console.WriteLine(day);
    int num=(int)weekdays.Thursday;
    Console.WriteLine(num);
    }
}
