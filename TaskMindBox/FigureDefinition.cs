using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMindBox
{
    // в задании было написано сделать вычисление площади фигуры без знания типа фигуры. В классе ниже это реализовано 
    public class FigureDefinition
    {
        public static void GetDefinition(IFigure figure)
        {
            Console.WriteLine("Площадь фигуры = " + figure.GetSquare());
        }
    }
}
