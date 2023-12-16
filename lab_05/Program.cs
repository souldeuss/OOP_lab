using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace lab_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many shapes?");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Circles ?");

            int c = Convert.ToInt32(Console.ReadLine());

            int r = n - c;

            int i = 1;
            

            for (int g = 0; g < c; g++)
            {

                var Circle = new Circle();
                Console.WriteLine($"Shapes:{i}/{n} ||{g}/{c}");

                Console.WriteLine("Enter a radius:");

                int radius = Convert.ToInt32(Console.ReadLine());

                Circle.CalculateArea(radius, 0,Circle);
                i++;
            }
            for (int y = 0; y < r; y++)
            {
                var Rectangle = new Rectangle();
                Console.WriteLine($"Shapes:{i}/{n} ||{y}/{r}");

                Console.WriteLine("Enter two number width:");
                int w = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter two number height:");
                int h = Convert.ToInt32(Console.ReadLine());

                Rectangle.CalculateArea(w, h, Rectangle);
                i++;
            }
            
            ShapeManager.TableOfShape();

            Console.ReadKey();
        }

        
    }
}
