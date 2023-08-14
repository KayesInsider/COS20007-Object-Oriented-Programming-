using NUnit.Framework;
using ClockClass;


namespace ClockTests
{
    public class TestClock
    {
        Clock _clock;
        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }

        [Test]
        public void TestClockTimeFormat()
        {
            Assert.AreEqual("00:00:00", _clock.GetTime());
        }

        [TestCase(0, "00:00:00")]
        [TestCase(59, "00:00:59")]
        [TestCase(60, "00:01:00")]
        [TestCase(3600, "01:00:00")]
        [TestCase(86399, "23:59:59")]
        public void TestClockTick(int ticks, string expectedResult)
        {
            for (int i = 0; i < ticks; i++)
            {
                _clock.Ticks();
            }
            Assert.AreEqual(expectedResult, _clock.GetTime(), "Clock didn't tick correctly");
        }

        [Test]
        public void testClockReset()
        {
            for (int i = 0; i < 3650; i++)
            {
                _clock.Ticks();
            }
            _clock.Reset();
            Assert.AreEqual("00:00:00", _clock.GetTime(), "Clock reset didn't reset to 0");
        }
    }
}