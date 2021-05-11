using NUnit.Framework;
using Calc;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumTest1()
        {
            Class1 calc = new Class1();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong 1");
        }
        [Test]
        public void SumTest2()
        {
            Class1 calc = new Class1();
            int value = calc.Sum("2,5");
            Assert.That(value, Is.EqualTo(7), "Wrong 2");
        }
        [Test]
        public void SumTest3()
        {
            Class1 calc = new Class1();
            int value = calc.Sum("");
            Assert.That(value, Is.EqualTo(0), "Wrong 3");
        }
        [Test]
        public void SumTest4()
        {
            Class1 calc = new Class1();
            int value = calc.Sum("3");
            Assert.That(value, Is.EqualTo(3), "Wrong 4");
        }
        [Test]
        public void SumTest5()
        {
            Class1 calc = new Class1();
            int value = calc.Sum("2,-2");
            Assert.That(value, Is.EqualTo(-1), "Wrong 5");
        }
        [Test]
        public void SumTest6()
        {
            Class1 calc = new Class1();
            int value = calc.Sum("-3");
            Assert.That(value, Is.EqualTo(-1), "Wrong 6");
        }
        [Test]
        public void SumTest7()
        {
            Class1 calc = new Class1();
            int value = calc.Sum("2 5");
            Assert.That(value, Is.EqualTo(-1), "Wrong 5");
        }
        [Test]
        public void SumTest8()
        {
            Class1 calc = new Class1();
            int value = calc.Sum(",2");
            Assert.That(value, Is.EqualTo(-1), "Wrong 5");
        }
        [Test]
        public void SumTest9()
        {
            Class1 calc = new Class1();
            int value = calc.Sum("2,7,1");
            Assert.That(value, Is.EqualTo(-1), "Wrong 5");
        }
    }
}