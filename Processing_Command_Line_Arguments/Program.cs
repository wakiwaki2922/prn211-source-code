﻿namespace Processing_Command_Line_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "***** Welcome to C#.NET Programming *****";
            Console.WriteLine("{0}",msg);
            // Process any incoming args.
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg: {args[i]}");
            }
            Console.ReadLine();
        }
    }
}
