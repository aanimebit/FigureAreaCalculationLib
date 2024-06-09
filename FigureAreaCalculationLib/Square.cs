using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculationLib
{
    public class Square : Rectangle
    {
        public Square(double firstSide, double secondSide = 0) : base(firstSide, secondSide)
        {
            base.FirstSide = firstSide;
            base.SecondSide = firstSide;
        }
    }
}
