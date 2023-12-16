using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    internal class Circle : Shape
    {
        public void CalculateArea(int a, int b, object Circle)
        {
            double area = Math.PI * a;

            ShapeManager.addShape(Circle, a, b, area);

        }
    }
}
