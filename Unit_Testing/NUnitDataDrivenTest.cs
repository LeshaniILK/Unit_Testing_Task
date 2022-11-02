using CSharpCalculator;
using NUnit.Framework;

namespace Unit_Testing
{
    [TestFixture]
    public class NUnitDataDrivenTest
    {
        [SetUp]
        public static void TestInit()
        {
            Console.WriteLine("Pre Condition");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        private Calculator calc;

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 15)]
        [TestCase(7, 8, ExpectedResult = 15)]
        public double Add_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Add(x, y);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(15485, ExpectedResult = 15485)]
        [TestCase(-514, ExpectedResult = 514)]
        public double Abs_TC(double x)
        {
            calc = new Calculator();
            return calc.Abs(x);
        }

        [TestCase(0, ExpectedResult = 1.0d)]
        [TestCase(1, ExpectedResult = 0.54030230586813977d)]
        [TestCase(30, ExpectedResult = 0.15425144988758405d)]
        [TestCase(90, ExpectedResult = -0.44807361612917013d)]
        public double Cos_TC(double x)
        {
            calc = new Calculator();
            return calc.Cos(x);
        }

        [TestCase(20, 5, ExpectedResult = 4)]
        [TestCase(5, 1, ExpectedResult = 5)]
        [TestCase(1000, 50, ExpectedResult = 20)]
        [TestCase(7, 2, ExpectedResult = 3.5)]
        public double Divide_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Divide(x, y);
        }


        [TestCase(-1, ExpectedResult = true)]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2546, ExpectedResult = false)]
        [TestCase(-125, ExpectedResult = true)]
        public bool isNegative_TC(double x)
        {
            calc = new Calculator();
            return calc.isNegative(x);
        }

        [TestCase(1, ExpectedResult = true)]
        [TestCase(-1, ExpectedResult = false)]
        [TestCase(2546, ExpectedResult = true)]
        [TestCase(-125, ExpectedResult = false)]
        public bool isPositive_TC(double x)
        {
            calc = new Calculator();
            return calc.isPositive(x);
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 4, ExpectedResult = 20)]
        [TestCase(-8, -2, ExpectedResult = 16)]
        [TestCase(-1, 5, ExpectedResult = -5)]
        public double Multipy_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Multiply(x, y);
        }

        [TestCase(2, 2.0, ExpectedResult = 4)]
        [TestCase(5, 2.0, ExpectedResult = 25)]
        [TestCase(105, 3.0, ExpectedResult = 1157625)]
        [TestCase(1, 1.0, ExpectedResult = 1)]
        public double Pow_TC(object x, object y)
        {
            calc = new Calculator();
            return calc.Pow(x, y);
        }


        [TestCase(90, ExpectedResult = 0.89399666360055785d)]
        [TestCase(45, ExpectedResult = 0.85090352453411844d)]
        [TestCase(Double.NaN, ExpectedResult = "NaN")]
        [TestCase(60, ExpectedResult = -0.30481062110221668d)]
        public double Sin_TC(double x)
        {
            calc = new Calculator();
            return calc.Sin(x);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(25, ExpectedResult = 5)]
        [TestCase(625, ExpectedResult = 25)]
        [TestCase(900, ExpectedResult = 30)]
        public double Sqrt_TC(double x)
        {
            calc = new Calculator();
            return calc.Sqrt(x);
        }

        [TestCase(5, 2, ExpectedResult = 3)]
        [TestCase(50, 25, ExpectedResult = 25)]
        [TestCase(750, 200, ExpectedResult = 550)]
        [TestCase(115, 15, ExpectedResult = 100)]
        public double Sub_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Sub(x, y);
        }
    }
}