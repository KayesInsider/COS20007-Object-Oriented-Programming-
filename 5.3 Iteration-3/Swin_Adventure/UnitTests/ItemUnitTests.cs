using NUnit.Framework;
using Swin_Adventure;

namespace UnitTests
{
    public class ItemUnitTests
    {
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");

  

        [Test()]
        public void TestItemIsIdentifiable()
        {
            Assert.That(shovel.AreYou("shovel"), Is.True);
            Assert.That(sword.AreYou("sword"), Is.True);
            Assert.That(shovel.AreYou("sword"), Is.False);
            Assert.That(sword.AreYou("shovel"), Is.False);

           
        }

        [Test()]
        public void TestItemShortDescription()
        {
            Assert.That(shovel.ShortDescription, Is.EqualTo("a shovel (FirstId)"));
        }

        [Test()]
        public void TestItemFullDescription()
        {
            Assert.That(shovel.FullDesciption, Is.EqualTo("This is a shovel"));
            
        }
    }
}
