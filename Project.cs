//Abstraction

using System;
abstract class Human{
    public abstract void food();
    public void eat(){
        Console.WriteLine("Humans eat food to survive.\n");
    }
}
class Children : Human
{
    public override void food(){
        Console.WriteLine("Children eat light food.");
    }
}
class Adult : Human
{
    public override void food()
    {
        Console.WriteLine("Adults eat protien rich food");
    }
}
public class Project
{
    public static void Main(string[] args)
    {
        Children c=new Children();
        Adult a=new Adult();
        a.eat();
        c.food();
        a.food();
    }
}
