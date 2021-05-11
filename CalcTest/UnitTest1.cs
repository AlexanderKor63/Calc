using NUnit.Framework;
using KAICalc;

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
            Calc calc = new Calc();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong 1");
        }
        [Test]
        public void SumTest2()
        {
            Calc calc = new Calc();
            int value = calc.Sum("2,5");
            Assert.That(value, Is.EqualTo(7), "Wrong 2");
        }
        [Test]
        public void SumTest3()
        {
            Calc calc = new Calc();
            int value = calc.Sum("");
            Assert.That(value, Is.EqualTo(0), "Wrong 3");
        }
        [Test]
        public void SumTest4()
        {
            Calc calc = new Calc();
            int value = calc.Sum("3");
            Assert.That(value, Is.EqualTo(3), "Wrong 4");
        }
        [Test]
        public void SumTest5()
        {
            Calc calc = new Calc();
            int value = calc.Sum("2,-2");
            Assert.That(value, Is.EqualTo(-1), "Wrong 5");
        }
        [Test]
        public void SumTest6()
        {
            Calc calc = new Calc();
            int value = calc.Sum("-3");
            Assert.That(value, Is.EqualTo(-1), "Wrong 6");
        }
        [Test]
        public void SumTest7()
        {
            Calc calc = new Calc();
            int value = calc.Sum("2 5");
            Assert.That(value, Is.EqualTo(-1), "Wrong 5");
        }
        [Test]
        public void SumTest8()
        {
            Calc calc = new Calc();
            int value = calc.Sum(",2");
            Assert.That(value, Is.EqualTo(-1), "Wrong 5");
        }
        [Test]
        public void SumTest9()
        {
            Calc calc = new Calc();
            int value = calc.Sum("2,7,1");
            Assert.That(value, Is.EqualTo(-1), "Wrong 5");
        }
    }
}