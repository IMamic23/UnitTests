using NUnit.Framework;
using System.Linq;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        [Test]
        [Ignore("Because I said so")]
        [TestCase(2, 1, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(1, 1, 2)]
        public void Add_WhenCalled_ReturnSum(int a, int b, int expected)
        {
            var result = _math.Add(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(2, 3, 3)]
        [TestCase(1, 1, 1)]
        public void Add_WhenCalled_ReturnTheGreaterAgrument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThenZero_ReturnOddNumbers()
        {
            var result = _math.GetOddNumbers(5).ToList();
            
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(3));
            
            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));
            
            Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5}));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}
