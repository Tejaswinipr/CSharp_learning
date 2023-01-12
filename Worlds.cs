//Properties get and set method

using System;

class Worlds
{
    private string name;
    public string Name{
        get{ return name;}
        set{name=value;}
    }
}
class Test{
public static void Main(string[] args)
{
    Worlds w=new Worlds();
    w.Name="Tejaswini";
    Console.WriteLine (w.Name);
}
}

