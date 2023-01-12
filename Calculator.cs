using System;
namespace Calculator
{
    public class EmptyClass
    {
        public EmptyClass()
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("\n1. Addition\n2.Subraction\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter a choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            int val1, val2;
            Console.WriteLine("Enter 1st operand:");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd operand:");
            val2 = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sum:" + val1 + val2);
                    break;
                case 2:
                    Console.WriteLine("Difference:" + (val1 - val2));
                    break;
                case 3:
                    Console.WriteLine("Product:" + (val1 * val2));
                    break;
                case 4:
                    Console.WriteLine("Quotient:" + (val1 / val2));
                    break;
                default:
                    Console.WriteLine("Invalid choice!!!");
                    break;
            }
            Console.ReadKey();

        }
    }
}

