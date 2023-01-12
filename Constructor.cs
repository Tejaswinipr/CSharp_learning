//Constructors


using System;

class Constructor
{
    public string name;
    public string dept;
    public int rollNo;
    public World(string studName, string studDept, int studRollNo){
        name=studName;
        dept=studDept;
        rollNo=studRollNo;
    }
}
class Test{
public static void Main(string[] args)
{
    Constructor w=new Constructor("Tejaswini","CSE",361);
    Console.WriteLine (w.name+" "+w.dept+" "+w.rollNo);
}
}

