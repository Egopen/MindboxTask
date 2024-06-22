using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLib.Figures;

namespace FigureSpace
{
    public static class AreaCounter
    {
        static public double Count(IFigure figure)
        {
            if(figure == null) return 0;
            else if(figure is Circle circle)
            {
                return circle.GetRadius()*Math.Pow(Math.PI,2);
            }
            else if(figure is Triangle triangle)
            {
                List<double> sides = triangle.GetSides();
                double MaxSide = sides[0];
                double MidSide = sides[1];
                double MinSide= sides[2];
                if (RectangularTriangleCheck(MaxSide,MidSide,MinSide))
                {
                    return (MidSide * MinSide) / 2;
                }
                else
                {
                    return Math.Sqrt(triangle.P/2 * (triangle.P/2 - MaxSide) * (triangle.P/2 - MinSide) * (triangle.P/2 - MidSide));
                }
            }
            return 0;
        }
        private static bool RectangularTriangleCheck(double MaxSide, double MidSide, double MinSide)
        {
            return Math.Pow(MaxSide, 2) == Math.Pow(MinSide, 2) + Math.Pow(MidSide, 2);
        }
    }
}
