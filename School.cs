//Struct

using System;

struct Students{
public int rollNo;
public string name;
public string dept;
};

public class School{
    public static void Main(string[] args){
        Students s1;
        Students s2;
        s1.rollNo=1;
        s1.name="Ram";
        s1.dept="CSE";
        s2.rollNo=2;
        s2.name="Jay";
        s2.dept="ECE";
        Console.WriteLine("Student 1 details:");
        Console.WriteLine(s1.name+" "+s1.rollNo+" "+s1.dept);
        Console.WriteLine("Student 2 details:");
        Console.WriteLine(s2.name+" "+s2.rollNo+" "+s2.dept);
        Console.ReadKey();
    }
}
