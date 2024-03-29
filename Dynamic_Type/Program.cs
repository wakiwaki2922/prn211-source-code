using System;

namespace Dynamic_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic myValue = 0;
            Console.WriteLine("myInt is a: {0}",myValue.GetType().Name);
            myValue = true;
            Console.WriteLine("myBool is a: {0}", myValue.GetType().Name);
            myValue = "Hello";
            Console.WriteLine("myString is a: {0}", myValue.GetType().Name);
            myValue = 0.5;
            Console.WriteLine("myDouble is a: {0}", myValue.GetType().Name);
            Console.ReadLine();
        }
    }
}
