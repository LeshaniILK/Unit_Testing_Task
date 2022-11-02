using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test_MSTest
{
    [TestClass]
    public class MSTest
    {

        /*[ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Console.WriteLine("Pre Condition for class + '{context.ToString()}'");
        }

        [TestInitialize]
        public static void TestInit()
        {
            Console.WriteLine("Pre Condition for test");
        }*/

        [TestMethod]
        public void TestMethod1()
        {
        }

        private Calculator calc;

        [TestMethod]
        public void Addition_TC()
        {
            double arg1 = 20;
            double arg2 = 10;
            double expected = 30;
            calc = new Calculator();

            double result = calc.Add(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Abs_TC()
        {
            double arg1 = -5;
            double expected = 5;
            calc = new Calculator();

            double result = calc.Abs(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cos_TC()
        {
            double arg1 = 0;
            double expected = 1.0d;
            calc = new Calculator();

            double result = calc.Cos(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_TC()
        {
            double arg1 = 100;
            double arg2 = 2;
            double expected = 50;
            calc = new Calculator();

            double result = calc.Divide(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsNegative_TC()
        {
            double arg1 = -5;
            bool expected = true;
            calc = new Calculator();

            bool result = calc.isNegative(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPositive_TC()
        {
            double arg1 = 5;

            bool expected = true;
            calc = new Calculator();

            bool result = calc.isPositive(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_TC()
        {
            double arg1 = 10;
            double arg2 = 2;
            double expected = 20;
            calc = new Calculator();

            double result = calc.Multiply(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Pow_TC()
        {
            var arg1 = 2;
            var arg2 = 3.0;
            var expected = 8;
            calc = new Calculator();

            var result = calc.Pow(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sin_TC()
        {
            double arg1 = 0;
            double expected = 0;
            calc = new Calculator();

            double result = calc.Sin(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sqrt_TC()
        {
            double arg1 = 25;
            double expected = 5;
            calc = new Calculator();

            double result = calc.Sqrt(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sub_TC()
        {
            double arg1 = 5;
            double arg2 = 2;
            double expected = 3;
            calc = new Calculator();

            double result = calc.Sub(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

         /*[TestCleanup]
         public static void TestClean()
         {
             Console.WriteLine("Post Condition for test");
         }

         [ClassCleanup]
         public static void CleanClass()
         {
             Console.WriteLine("Post Condition for test class");
         }*/
    }
}