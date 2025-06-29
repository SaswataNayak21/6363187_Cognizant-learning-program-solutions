using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-1, -1, -2)]
        [TestCase(-1, -1, -2)]
        [TestCase(100, 200, 300)]
        public void Add_ReturnsCorrectSum(int a, int b, int expected)
        {
            int result = calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
