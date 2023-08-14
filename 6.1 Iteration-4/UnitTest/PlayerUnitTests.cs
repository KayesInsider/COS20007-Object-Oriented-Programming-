using NUnit.Framework;
using Swin_Adventure;


namespace UnitTests
{

    public class PlayerUnitTests
    {
        Player player = new Player("Kayes", "Ready Player ONE");
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a Sword");
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestPlayerIdentifiable()
        {
            Assert.IsTrue(player.AreYou("me") && player.AreYou("inventory"));

        }

        [Test]
        public void TestPlayerLocateItems()
        {
            player.Inventory.Put(sword);

            Item itemLocated = (Item)player.Locate("sword");

            Assert.IsNotNull(itemLocated);
            Assert.That(itemLocated, Is.EqualTo(sword));
        }



        [Test]
        public void TestPlayerLocatesItself()
        {
            Assert.AreSame(player, player.Locate("me"));
        }
        


        [Test]
        public void TestPlayerLocateNothing()
        {
            Assert.That(player.Locate("Crash"), Is.EqualTo(null));
         
        }
        
        
        
        [Test]
        public void TestPlayerFullDescription()
        {
            player.Inventory.Put(sword);
            player.Inventory.Put(shovel);
            string expected = "Kayes, you are carrying:\n a sword (FirstId)\r\n a shovel (FirstId)\r\n";
            Assert.That(expected, Is.EqualTo(player.FullDesciption));
        }
    }
}
