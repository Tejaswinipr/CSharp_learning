//Polymorphism and Overriding


using System;
class Human{
    public void food(){
        Console.WriteLine("Humans eat food to survive");
    }
}
class Children : Human
{
    public void food(){
        Console.WriteLine("Children eat light food.\n");
    }
}
class Adult : Human
{
    public void food()
    {
        Console.WriteLine("Adults eat protien rich food.\n");
    }
}
public class PolyOR
{
    public static void Main(string[] args)
    {
        Human h=new Human();
        Children c=new Children();
        Adult a=new Adult();
        h.food();
        c.food();
        a.food();
    }
}
