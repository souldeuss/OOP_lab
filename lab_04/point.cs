using System;

namespace lab_04
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        //public static int x2;
        //public static int y2;

        public Point(int x,int y)
        {
            int X = x;
            int Y = y;
        }

        public static string Result (int X1,int Y1,int X2,int Y2, string operation)
        {
            string R = "False";

            var P1 = new Point(X1,Y2);
            var P2 = new Point(X2,Y2);

            switch (operation)
            {
                case "==":
                    if (P1.x == P2.x || P1.y == P2.y)
                    {
                        R = ("True");
                    }
                    else
                    {
                        R = ("False");
                    }
                    break;
                case "!=":
                    if (P1.x != P2.x || P1.y != P2.y)
                    {
                        R = ("True");
                    }
                    else
                    {
                        R = ("False");
                    }
                    break;
                case "<":
                    if (P1.x < P2.x && P1.y < P2.y)
                    {
                        R = ("True");
                    }
                    else
                    {
                        R = ("False");
                    }
                    break;
                case ">":
                    if (P1.x > P2.x && P1.y > P2.y)
                    {
                        R = ("True");
                    }
                    else
                    {
                        R = ("False");
                    }
                    break;
                case "<<":
                    Console.WriteLine($"Point 1: ({P1.x};{P1.y})\n Point 2: ({P2.x};{P2.y})");
                    break;


                default:
                    Console.WriteLine("Incorrect data, pls try again!");
                    break;
            }
            return R;

        }

    }
}