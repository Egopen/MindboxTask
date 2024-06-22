using FigureLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Figures
{
    public class Circle : IFigure//круг
    {
        public double P { get { return 2 * Math.PI * radius; } }
        public double radius;
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new WrongDataForFigureExc();
            }
            this.radius = radius;
        }
        public void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new WrongDataForFigureExc();
            }
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }

    }
}
