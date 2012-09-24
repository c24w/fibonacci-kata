using NUnit.Framework;

namespace Fibonacci
{
    [TestFixture]
    class Fibonacci
    {
        private FibonacciGenerator _generator;

        [SetUp]
        public void SetUp()
        {
            _generator = new FibonacciGenerator();
        }

        [Test]
        public void First_number_should_be_one()
        {
            var nth = _generator.GetFibonacci(1);
            Assert.That(nth, Is.EqualTo(1));
        }

        [Test]
        public void Second_number_should_be_one()
        {
            var nth = _generator.GetFibonacci(2);
            Assert.That(nth, Is.EqualTo(1));
        }

        [Test]
        public void Third_number_should_be_2()
        {
            var nth = _generator.GetFibonacci(3);
            Assert.That(nth, Is.EqualTo(2));
        }

        [Test]
        public void Fifth_number_should_be_5()
        {
            var nth = _generator.GetFibonacci(5);
            Assert.That(nth, Is.EqualTo(5));
        }

    }
}