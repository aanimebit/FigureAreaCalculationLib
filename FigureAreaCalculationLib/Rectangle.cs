using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculationLib
{
    public class Rectangle : Figure
    {
        private double _firstSide;
        private double _secondSide;

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

        public Rectangle(double firstSide, double secondSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
        }

        public override double CalcArea()
        {
            return FirstSide * SecondSide;
        }
    }
}
