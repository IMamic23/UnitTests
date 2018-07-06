using AutoFixture.Kernel;
using AutoFixture.Xunit2;
using System;
using Xunit;

namespace UnitTestsXunit
{
    public class Tests
    {
        [Theory, AutoData]
        public void Test1(int test, TestClass testClass)
        {

            //Assert.IsType<int>(test);
            //Assert.IsType<TestClass>(testClass);

            //var test = AutoFixture.CreateSeedExtensions.CreateMany<TestClass>();
        }
    }

    public class TestClass
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }
    }
}
