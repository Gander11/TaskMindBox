using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMindBox
{
    public class Circle : IFigure
    {
        const double PI = 3.14;
        private double _radius;
        public Circle(double _radius)
        {
            this._radius = _radius;
        }

        public double Radius { get { return _radius; } }

        public double GetSquare()
        {
            double radius = Radius;
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга не может быть меньше или равен 0");
            }
            double CircleSquare = PI * (radius * radius);
            return Math.Round(CircleSquare, 3);
        }
    }
}
