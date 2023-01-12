using System;
using System.IO;
using System.Text;
using FileStream;

namespace FileStream
{
    public class fileCreate
    {
     public static void Main()
        {
            string fName = @"test.txt";
            string[] lines;
            try
            {
                if (File.Exists(fName))
                {
                    File.Delete(fName);
                    Console.WriteLine("File deleted");
                }
                using (StreamWriter fStr = File.CreateText(fName))
                {
                    fStr.WriteLine("Hello, How are you?");
                    fStr.WriteLine(" It is the first content");
                    fStr.WriteLine(" of the text file mytest.txt");

                    Console.WriteLine("test.txt file is created");
                }

                Console.WriteLine("Enter the number of Lines:");
                int n = Convert.ToInt32(Console.ReadLine());
                lines = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter {0} line:", i + 1);
                    lines[i] = Console.ReadLine();
                }
                System.IO.File.WriteAllLines(fName, lines);
                using (StreamReader sr = File.OpenText(fName))
                {
                    string s = "";
                    Console.WriteLine("File Content:");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("{0}", s);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            if (File.Exists(fName))
            {
                File.Delete(fName);
                Console.WriteLine("test.txt file was deleted");
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }
                Console.ReadKey();

        }
    }
}
