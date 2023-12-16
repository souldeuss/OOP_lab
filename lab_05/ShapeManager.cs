using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{

    internal class ShapeManager
    {
        public static List<ShapeManager> shapes = new List<ShapeManager>();
        private object shape;
        private int a;
        private int b;
        private double area;

        public ShapeManager(object shape, int a, int b, double area)
        {
            this.shape = shape;
            this.a = a;
            this.b = b;
            this.area = area;
        }

        public static void addShape(object shape, int a, int b,double area)
        {
            shapes.Add( new ShapeManager (shape,a,b,area) );
        }

        public static void TableOfShape()
        {
            var table = new ConsoleTable("#", "Shape", "Radius/Width", "Height", "Area");
            int i = 1;
            foreach (var ShapeManager in shapes)
            {
                i++;
                table.AddRow(i, ShapeManager.shape, ShapeManager.a, ShapeManager.b, ShapeManager.area);
            }

                table.Write(Format.Alternative);
        }
    }
}
