using FigureAreaCalculationLib;
using NuGet.Frameworks;

namespace UnitTest
{
    [TestClass]
    public class AreaCalcTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "Incorrect values of the sides of a triangle according to the triangle inequality theorem.")]
        public void CreateNonExistentTriangle()
        {
            double firstSide = 20;
            double secondSide = 2;
            double thirdSide = 8;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
        }

        [TestMethod]
        public void CreateTriangleWithNegativeSides()
        {
            double firstSide = -2;
            double secondSide = -4;
            double thirdSide = -3;

            double expectedFirstSide = 2;
            double expectedSecondSide = 4;
            double expectedThirdSide = 3;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expectedFirstSide, triangle.FirstSide);
            Assert.AreEqual(expectedSecondSide, triangle.SecondSide);
            Assert.AreEqual(expectedThirdSide, triangle.ThirdSide);
        }

        [TestMethod]
        public void CheckIsRightTriangle()
        {
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;

            bool expected = true;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTriangleArea()
        {
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;

            double expected = 6;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            double actual = triangle.CalcArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateCircleWithNegativeRadius()
        {
            double radius = -2;

            double expectedRadius = 2;

            Circle circle = new Circle(radius);

            Assert.AreEqual(expectedRadius, circle.Radius);
        }

        [TestMethod]
        public void CalculateCircleArea()
        {
            double radius = 3;

            double expected = Math.PI * Math.Pow(radius, 2);

            Circle circle = new Circle(radius);
            double actual = circle.CalcArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateRectangleWithNegativeSides()
        {
            double firstSide = -2;
            double secondSide = -5;

            double expectedFirstSide = 2;
            double expectedSecondSide = 5;

            Rectangle rectangle = new Rectangle(firstSide, secondSide);

            Assert.AreEqual(expectedFirstSide, rectangle.FirstSide);
            Assert.AreEqual(expectedSecondSide, rectangle.SecondSide);
        }

        [TestMethod]
        public void CalculateRectangleArea()
        {
            double firstSide = 3;
            double secondSide = 4;

            double expected = 12;

            Rectangle rectangle = new Rectangle(firstSide, secondSide);
            double actual = rectangle.CalcArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateSquareWithNegativeSide()
        {
            double side = -10;

            double expectedSide = 10;

            Square square = new Square(side);

            Assert.AreEqual(expectedSide, square.FirstSide);
        }

        [TestMethod]
        public void CalculateSquareArea()
        {
            double side = 3;

            double expected = 9;

            Square square = new Square(side);
            double actual = square.CalcArea();

            Assert.AreEqual(expected, actual);
        }
    }
}