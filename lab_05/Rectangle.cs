using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    internal class Rectangle : Shape
    {
        public void CalculateArea(int a, int b,object Rectangle)
        {
            double area = a * b;

            ShapeManager.addShape(Rectangle,a,b,area);
        }
    }
}
