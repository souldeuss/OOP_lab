using System;

namespace lab_04
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        //public static int x2;
        //public static int y2;

        public Point(int x,int y)
        {
             X = x;
             Y = y;
        }

        public static string Result (string operation)
        {
            string R = "False";


            Console.WriteLine("Enter coordinate \"X\": ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate \"Y\": ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            var P1 = new Point(X1,Y1);

            Console.WriteLine("Enter coordinate \"X\": ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate \"Y\": ");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            var P2 = new Point(X2,Y2);


            switch (operation)
            {
                case "==":
                    if (P1.X == P2.X || P1.Y == P2.Y)
                    {
                        R = ("True");
                    }
                    else
                    {
                        R = ("False");
                    }
                    break;
                case "!=":
                    if (P1.X != P2.X || P1.Y != P2.Y)
                    {
                        R = ("True");
                    }
                    else
                    {
                        R = ("False");
                    }
                    break;
                case "<":
                    if (P1.X < P2.X || P1.Y < P2.Y)
                    {
                        R = ("True");
                    }
                    else
                    {
                        R = ("False");
                    }
                    break;
                case ">":
                    if (P1.X > P2.X || P1.Y > P2.Y)
                    {
                        R = ("True");
                    }
                    else
                    {
                        R = ("False");
                    }
                    break;
                case "<<":
                    Console.WriteLine($"Point 1: ({P1.X};{P1.Y})\n Point 2: ({P2.X};{P2.Y})");
                    break;


                default:
                    Console.WriteLine("Incorrect data, pls try again!");
                    break;
            }
            return R;

        }

    }
}