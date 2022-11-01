using CSharpCalculator;

namespace Unit_Test_MSTest
{
    [TestClass]
    public class MSTestDataDrivenTest
    {
        private Calculator calc;

        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow("1", 0, 1)]
        [DataRow(5, 10, 15)]
        [DataRow(7, 8, 15)]
        public double Add_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Add(x, y);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(5, 5)]
        [DataRow(15485, 15485)]
        [DataRow(-514, 514)]
        public double Abs_TC(double x)
        {
            calc = new Calculator();
            return calc.Abs(x);
        }

        [TestMethod]
        [DataRow(0, 1.0d)]
        [DataRow(1, 0.54030230586813977d)]
        [DataRow(30, 0.15425144988758405d)]
        [DataRow(90, -0.44807361612917013d)]
        public double Cos_TC(double x)
        {
            calc = new Calculator();
            return calc.Cos(x);
        }

        [TestMethod]
        [DataRow(20, 5, 4)]
        [DataRow(5, 1, 5)]
        [DataRow(1000, 50, 20)]
        [DataRow(7, 2, 3.5)]
        public double Divide_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Divide(x, y);
        }

        [TestMethod]
        [DataRow(-1, true)]
        [DataRow(1, false)]
        [DataRow(2546, false)]
        [DataRow(-125, true)]
        public bool isNegative_TC(double x)
        {
            calc = new Calculator();
            return calc.isNegative(x);
        }

        [TestMethod]
        [DataRow(1, true)]
        [DataRow(-1, false)]
        [DataRow(2546, true)]
        [DataRow(-125, false)]
        public bool isPositive_TC(double x)
        {
            calc = new Calculator();
            return calc.isPositive(x);
        }

        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(5, 4, 20)]
        [DataRow(-8, -2, 16)]
        [DataRow(-1, 5, -5)]
        public double Multipy_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Multiply(x, y);
        }

        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(5, 2, 25)]
        [DataRow(105, 3, 11025)]
        [DataRow(1, 1, 1)]
        public double Power_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Pow(x, y);
        }

        [TestMethod]
        [DataRow(90, 0.89399666360055785d)]
        [DataRow(45, 0.85090352453411844d)]
        [DataRow(Double.NaN, "NaN")]
        [DataRow(60, -0.30481062110221668d)]
        public double Sin_TC(double x)
        {
            calc = new Calculator();
            return calc.Sin(x);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(25, 5)]
        [DataRow(625, 25)]
        [DataRow(900, 30)]
        public double Sqrt_TC(double x)
        {
            calc = new Calculator();
            return calc.Sqrt(x);
        }

        [TestMethod]
        [DataRow(5, 2, 3)]
        [DataRow(50, 25, 25)]
        [DataRow(750, 200, 550)]
        [DataRow(115, 15, 100)]
        public double Sub_TC(double x, double y)
        {
            calc = new Calculator();
            return calc.Sub(x, y);
        }
    }
}