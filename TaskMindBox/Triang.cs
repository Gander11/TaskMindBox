using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMindBox
{
    public class Triang : IFigure
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triang(double _side1, double _side2, double _side3)
        {
            this._side1 = _side1;
            this._side2 = _side2;
            this._side3 = _side3;
        }

        public double Side1 { get { return _side1; } }
        public double Side2 { get { return _side2; } }
        public double Side3 { get { return _side3; } }

        public double GetSquare() // метод для метод для вычисления площади треугольника. Тут реализована проверка на то, является ли треугольник прямоугольным, если да, то используется другая формула площади
        {
            if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
            {
                throw new ArgumentException("Введите корректное значение сторон треугольника");
            }
            int degree = 2;
            double MaxValue = Math.Max(Side1, Math.Max(Side2, Side3));
            if (MaxValue > Side1 && MaxValue > Side2)
            {
                if (MaxValue > Side1 + Side2)
                {
                    throw new ArgumentException("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
                }

                if (Math.Pow(MaxValue, degree) == Math.Pow(Side1, degree) + Math.Pow(Side2, degree))
                {
                    double TriangleSquare90 = Side1 * Side2 * 0.5;
                    return Math.Round(TriangleSquare90, 3);
                }
            }

            if (MaxValue > Side2 && MaxValue > Side3)
            {
                if (MaxValue > Side2 + Side3)
                {
                    throw new ArgumentException("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
                }

                if (Math.Pow(MaxValue, degree) == Math.Pow(Side2, degree) + Math.Pow(Side3, degree))
                {
                    double TriangleSquare90 = Side2 * Side3 * 0.5;
                    return Math.Round(TriangleSquare90, 3);
                }
            }

            if (MaxValue > Side1 && MaxValue > Side3)
            {
                if (MaxValue > Side1 + Side3)
                {
                    throw new ArgumentException("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
                }

                if (Math.Pow(MaxValue, degree) == Math.Pow(Side1, degree) + Math.Pow(Side3, degree))
                {
                    double TriangleSquare90 = Side1 * Side3 * 0.5;
                    return Math.Round(TriangleSquare90, 3);
                }
            }
            double SemiPerimeter = (Side1 + Side2 + Side3) / 2;
            double TriangleSquare = Math.Sqrt(SemiPerimeter * (SemiPerimeter - Side1) * (SemiPerimeter - Side2) * (SemiPerimeter - Side3)); // тут применяем формулу Герона
            return Math.Round(TriangleSquare, 3);
        }

    }
}
