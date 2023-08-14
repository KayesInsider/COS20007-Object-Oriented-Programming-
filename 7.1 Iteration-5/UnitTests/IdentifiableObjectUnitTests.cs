using NUnit.Framework;
using Swin_Adventure;

namespace UnitTests
{
    public class IdentifiableObjectUnitTests
    {

        private IdentifiableObject testObject;
        private IdentifiableObject testlbject2;

        [SetUp]
        public void Setup()
        {
            testObject = new IdentifiableObject(new string[] { "fred", "bob" });
            testlbject2 = new IdentifiableObject(new string[0]);
        }

        [Test]
        public void TestAreYou()
        {

            Assert.IsTrue(testObject.AreYou("fred"));
        }
        [Test]
        public void TestNotAreYou()
        {

            Assert.IsFalse(testObject.AreYou("wilma"));
        }
        [Test]
        public void TestCaseSensitive()
        {

            Assert.IsTrue(testObject.AreYou("FRED"));
        }
        [Test]
        public void TestFirstNoId()
        {
            Assert.AreEqual("", testlbject2.FirstId);
        }
        [Test]

        public void TestFirstId()
        {

            Assert.AreEqual("fred", testObject.FirstId);
        }
        [Test]
        public void TestAddId()
        {


            testObject.AddIdentifier("wilma");
            Assert.IsTrue(testObject.AreYou("fred"));
            Assert.IsTrue(testObject.AreYou("bob"));
            Assert.IsTrue(testObject.AreYou("wilma"));
        }

    }
}
