using System;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 1000.00;
            string name = "John";
            // Using curly-brackets syntax.
            string str1 = string.Format("Hello {0}, your salary is {1}", name, salary);
            Console.WriteLine(str1);
            // Using string interpolation.
            string str2 = $"Hello {name,7}, your salary is {salary,8:N2}";
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
