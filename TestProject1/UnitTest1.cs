using NUnit.Framework;
using Meller_UNIT;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Plus()
        {
            Calculator calc = new Calculator();
            double result = calc.Plus(3, 4);
            Assert.AreEqual(7, result);
        }
        [Test]
        public void Divide()
        {
            Calculator calc = new Calculator();
            double result = calc.Divide(8, 4);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Minus()
        {
            Calculator calc = new Calculator();
            double result = calc.Minus(8, 4);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void Multiply()
        {
            Calculator calc = new Calculator();
            double result = calc.Multiply(8, 4);
            Assert.AreEqual(32, result);
        }
        [Test]
        public void AreaOfATriangle()
        {
            Calculator calc = new Calculator();
            double result = calc.AreaOfATriangle(8, 4);
            Assert.AreEqual(16, result);
        }
        [Test]
        public void SquareAre()
        {
            Calculator calc = new Calculator();
            double result = calc.SquareAre(4);
            Assert.AreEqual(16, result);
        }
        [Test]
        public void Average1()
        {
            double[] array = { 1, 2, 3, 4, 5 };
            Calculator calc = new Calculator();
            double result = calc.Average(array);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Average2()
        {
            double[] array = { -1, -2, -3, -4, -5 };
            Calculator calc = new Calculator();
            double result = calc.Average(array);
            Assert.AreEqual(-3, result);
        }
        [Test]
        public void Average3()
        {
            double[] array = { 6, -2, -3, -4, -5 };
            Calculator calc = new Calculator();
            double result = calc.Average(array);
            Assert.AreEqual(-1.6, result);
        }
    }
}