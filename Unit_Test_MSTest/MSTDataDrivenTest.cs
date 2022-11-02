using CSharpCalculator;

namespace Unit_Test_MSTest
{
    [TestClass]
    public class MSTestDataDrivenTest
    {

        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 0, 1)]
        [DataRow(5, 10, 15)]
        [DataRow(7, 8, 15)]
        public void Add_TC(double x, double y, double z)
        {
            
            Calculator myCalculator = new Calculator();
            double result = myCalculator.Add(x, y);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(5, 5)]
        [DataRow(15485, 15485)]
        [DataRow(-514, 514)]
        public void Abs_TC(double x, double z)
        {
            Calculator myCalculator = new Calculator();
            double result = myCalculator.Abs(x);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(0, 1.0d)]
        [DataRow(1, 0.54030230586813977d)]
        [DataRow(30, 0.15425144988758405d)]
        [DataRow(90, -0.44807361612917013d)]
        public void Cos_TC(double x, double z)
        {
            Calculator myCalculator = new Calculator();
            double result = myCalculator.Cos(x);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(20, 5, 4)]
        [DataRow(5, 1, 5)]
        [DataRow(1000, 50, 20)]
        [DataRow(7, 2, 3.5)]
        public void Divide_TC(double x, double y, double z)
        {
            Calculator myCalculator = new Calculator();
            double result = myCalculator.Divide(x, y);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(-1, true)]
        [DataRow(1, false)]
        [DataRow(2546, false)]
        [DataRow(-125, true)]
        public void isNegative_TC(double x, bool z)
        {
            Calculator myCalculator = new Calculator();
            bool result = myCalculator.isNegative(x);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(-1, false)]
        [DataRow(1, true)]
        [DataRow(2546, true)]
        [DataRow(-125, false)]
        public void isPositive_TC(double x, bool z)
        {
            Calculator myCalculator = new Calculator();
            bool result = myCalculator.isPositive(x);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(5, 4, 20)]
        [DataRow(-8, -2, 16)]
        [DataRow(-1, 5, -5)]
        public void Multiply_TC(double x, double y, double z)
        {
            Calculator myCalculator = new Calculator();
            double result = myCalculator.Multiply(x, y);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(2, 2.0, 4)]
        [DataRow(5, 2.0, 25)]
        [DataRow(105, 3.0, 1157625)]
        [DataRow(1, 1.0, 1)]
        public void Pow_TC(object x, object y, double z)
        {
            Calculator myCalculator = new Calculator();
            var result = myCalculator.Pow(x, y);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(90, 0.89399666360055785d)]
        [DataRow(45, 0.85090352453411844d)]
        [DataRow(0, 0)]
        [DataRow(60, -0.30481062110221668d)]
        public void Sin_TC(double x, double z)
        {
            Calculator myCalculator = new Calculator();
            double result = myCalculator.Sin(x);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(25, 5)]
        [DataRow(625, 25)]
        [DataRow(900, 30)]
        public void Sqrt_TC(double x, double z)
        {
            Calculator myCalculator = new Calculator();
            double result = myCalculator.Sqrt(x);
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(5, 2, 3)]
        [DataRow(50, 25, 25)]
        [DataRow(750, 200, 550)]
        [DataRow(115, 15, 100)]
        public void Sub_TC(double x, double y, double z)
        {
            Calculator myCalculator = new Calculator();
            double result = myCalculator.Sub(x, y);
            Assert.AreEqual(z, result);
        }
    }
}