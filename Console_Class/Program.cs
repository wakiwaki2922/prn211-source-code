using System;

namespace Console_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            int i;
            string s;
            DateTime date;
            Console.WriteLine("***** Data Type Parsing *****");
            Console.Write("Enter a string: ");
            s = Console.ReadLine();
            Console.Write("Enter a double: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Enter an integer: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter a date: ");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Value of s:{s}, i:{i}, d:{d},date:{date:dd/MM/yyyy}");
            Console.ReadLine();
        }
    }
}
