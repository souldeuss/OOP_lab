using System;


namespace lab_04
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter coordinate \"X\": ");

            point.x = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter coordinate \"Y\": ");
            point.y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose operation: \n |operation ==| operation != | operation < | operation > | operation << | \n");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "==":
                    if (point.x == point.y)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                    break;
                case "!=":
                    if (point.x != point.y)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                    break;
                case "<":
                    if (point.x < point.y)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                    break;
                case ">":
                    if (point.x > point.y)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                    break;
                case "<<":
                    Console.WriteLine($"Point: ({point.x};{point.y})");
                    break;


                default:
                    Console.WriteLine("Incorrect data, pls try again!");
                    Main();
                    break;
                    
            }
            Console.ReadLine();
        }


    }
}
