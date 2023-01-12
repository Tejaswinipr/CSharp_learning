#Class and Object

using System;

public class World
{
    string hello="Hello World";
    public void printWelcome(){
        Console.WriteLine("Welcome to the World");
    }
    public static void Main(string[] args)
    {
        World w=new World();
        Console.WriteLine (w.hello);
        w.printWelcome();
    }
}
