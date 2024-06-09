using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculationLib
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set => _radius = value < 0 ? -value : value;
        }

        public Circle(double radius) => Radius = radius;

        public override double CalcArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
