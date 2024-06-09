using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculationLib
{
    public class Triangle : Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        private double[] _sides = new double[3];

        public double FirstSide
        {
            get => _firstSide;
            set => _firstSide = value < 0 ? -value : value;
        }

        public double SecondSide
        {
            get => _secondSide;
            set => _secondSide = value < 0 ? -value : value;
        }

        public double ThirdSide
        {
            get => _thirdSide;
            set => _thirdSide = value < 0 ? -value : value;
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (Math.Abs(firstSide) + Math.Abs(secondSide) > Math.Abs(thirdSide) &&
                Math.Abs(secondSide) + Math.Abs(thirdSide) > Math.Abs(firstSide) &&
                Math.Abs(thirdSide) + Math.Abs(firstSide) > Math.Abs(secondSide))
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;

                _sides = [firstSide, secondSide, thirdSide];
                _sides = [.. _sides.OrderDescending()];
            }
            else
            {
                throw new Exception("Incorrect values of the sides of a triangle according to the triangle inequality theorem.");
            }
        }

        public bool IsRightTriangle()
        {
            if (Math.Pow(_sides[0], 2) == (Math.Pow(_sides[1], 2) + Math.Pow(_sides[2], 2)))
                return true;

            return false;
        }

        public override double CalcArea()
        {
            if (IsRightTriangle())
                return _sides[1] * _sides[2] / 2;

            double p = _sides.Sum() / 2;
            return Math.Sqrt( p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }
    }
}
