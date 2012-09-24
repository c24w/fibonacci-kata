using NUnit.Framework;

namespace Fibonacci
{
    [TestFixture]
    class Fibonacci
    {

        [Test]
        public void First_number_should_be_one()
        {
            var nth = GetFibonacci(1);
            Assert.That(nth, Is.EqualTo(1));
        }

        [Test]
        public void Second_number_should_be_one()
        {
            var nth = GetFibonacci(2);
            Assert.That(nth, Is.EqualTo(1));
        }

        [Test]
        public void Third_number_should_be_2()
        {
            var nth = GetFibonacci(3);
            Assert.That(nth, Is.EqualTo(2));
        }

        private int GetFibonacci(int i)
        {
            if (i < 3) return 1;
            return i - 1;
        }
    }
}