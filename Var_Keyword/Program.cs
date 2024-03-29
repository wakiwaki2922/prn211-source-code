using System;

namespace Var_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myInt = 10;
            var myBool = true;
            var myString = "Time, marches on...";
            var myDouble = 10.5;
            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
            Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
            // Pause program execution before exiting.
            Console.ReadLine();
        }
    }
}
