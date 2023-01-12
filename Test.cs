//Inheritance 

using System;

class Earth
{
    public  string name="Earth";
    public void location()
    {
        Console.WriteLine("I am on Earth");
    }
}
class India : Earth
{
    public  string countryName="India";
    public static void loc()
    {
        Console.WriteLine("I am in India");
    }
}
class Test{
public static void Main(string[] args)
{
    India ind=new India();
    Console.WriteLine(ind.name);
    ind.location();
    Console.WriteLine(ind.countryName);
    India.loc();
}
}

