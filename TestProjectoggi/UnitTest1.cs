using net_calculator_tester;
using System.Runtime.InteropServices;
namespace TestProjectoggi
{
    public class Tests
    {
        [Test]
        [TestCase(1,2,3)]
        public void TestAdd(float num1, float num2, float num3)
        {
            Calculator calc = new Calculator();
            float risultato = calc.Add(num1, num2);
            Assert.AreEqual(num3, risultato);
        }

        [Test]
        [TestCase(5, 5, 0)]
        public void TestSubtract(float num1, float num2, float num3)
        {
            Calculator calc = new Calculator();
            float risultato = calc.Subtract(num1, num2);
            Assert.AreEqual(num3, risultato);
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(0, 2, 0)]
        public void TestDividet(float num1, float num2, float num3)
        {
            Calculator calc = new Calculator();
            float risultato = calc.Divide(num1, num2);
            Assert.AreEqual(num3, risultato);
        }

        [Test]
        [TestCase(5, 2, 10)]
        public void TestMultiply(float num1, float num2, float num3)
        {
            Calculator calc = new Calculator();
            float risultato = calc.Multiply(num1, num2);
            Assert.AreEqual(num3, risultato);
        }



    }
}