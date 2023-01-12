//Exception Handling


using System;
using System.IO;  

class ExceptionHandling
{
    public static void Main(string[] args)
    {
    try {
        Console.WriteLine(10/0);
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
    }
}
