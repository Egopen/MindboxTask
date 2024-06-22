using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Exceptions
{
    public class WrongDataForFigureExc:Exception
    {
        public WrongDataForFigureExc():base("Неправильные стороны для фигуры") { 
        }
    }
}
