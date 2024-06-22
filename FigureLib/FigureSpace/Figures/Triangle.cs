using FigureLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Figures
{
    public class Triangle : IFigure
    {
        public double P { get { return MaxSide + MidSide + MinSide; } }
        private double MaxSide { get; set; }
        private double MidSide { get; set; }
        private double MinSide { get; set; }
        public Triangle(double side1, double side2, double side3)
        {
            double max = double.Max(side1, double.Max(side2, side3));
            if (CheckIncrrectnessOfSides(side1,side2,side3,max))
            {
                throw new WrongDataForFigureExc();
            }
            MaxSide = max;
            MinSide = double.Min(side1, double.Min(side2, side3));
            MidSide = side1 + side2 + side3 - MaxSide - MinSide;
        }
        /// <summary>
        /// Возвращает список сторон от большей к меньшей
        /// </summary>
        /// <returns></returns>
        public List<double> GetSides()
        {
            return new List<double>() { MaxSide, MidSide, MinSide };
        }
        public void ChangeSides(double side1, double side2, double side3)
        {
            double max = double.Max(side1, double.Max(side2, side3));
            if (CheckIncrrectnessOfSides(side1, side2, side3, max))
            {
                throw new WrongDataForFigureExc();
            }
            MaxSide = max;
            MinSide = double.Min(side1, double.Min(side2, side3));
            MidSide = side1 + side2 + side3 - MaxSide - MinSide;
        }
        private bool CheckIncrrectnessOfSides(double side1, double side2, double side3, double max)
        {
            return side1 <= 0 || side2 <= 0 || side3 <= 0 || max > side1 + side2 + side3 - max;
        }
    }
}
