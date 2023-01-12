//Interface


using System;
interface Human{
    public abstract void food();
}
class Children : Human
{
    public void food(){
        Console.WriteLine("Children eat light food.");
    }
}
class Adult : Human
{
    public void food()
    {
        Console.WriteLine("Adults eat protien rich food");
    }
}
public class IProject
{
    public static void Main(string[] args)
    {
        Children c=new Children();
        Adult a=new Adult();
        c.food();
        a.food();
    }
}
