using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private int GetFibonacci(int n)
        {
            return 1;
        }
    }
}
