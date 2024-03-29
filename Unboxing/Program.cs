﻿using System;

namespace Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;  // a value type
            object o = i; // boxing
            int j = (int)o; // unboxing
            Console.WriteLine("i = {0}, o = {1}, j = {2}",i,o,j);
            Console.ReadLine();
        }
    }
}