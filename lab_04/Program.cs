﻿using System;

namespace lab_04
{
    internal class Program
    {
            static void Main()
            { 

                Console.Write("Choose operation: \n | == | != | < | > | << | \n ");

                string operation = Console.ReadLine();

                Console.WriteLine(Point.Result(operation));

                Console.ReadKey();
            }

    }
}
