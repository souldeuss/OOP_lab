using System;

namespace lab_04
{
    internal class Program
    {
            static void Main()
            {
                ConsoleKeyInfo cki;

                Console.Write("Choose operation: \n | == | != | < | > | << | \n ");

                string operation = Console.ReadLine();



                Console.WriteLine("Enter coordinate \"X\": ");
                int X1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter coordinate \"Y\": ");
                int Y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter coordinate \"X\": ");
                int X2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter coordinate \"Y\": ");
                int Y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Point.Result(X1,Y1,X2,Y2,operation));

                Console.ReadKey();
            }

    }
}
