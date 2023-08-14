using NUnit.Framework;
using Swin_Adventure;

namespace UnitTests
{
    public class InventoryUnitTests
    {
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestFindItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.IsTrue(i.HasItem(shovel.FirstId));
        }

        [Test]
        public void TestNoFindItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.IsFalse(i.HasItem(sword.FirstId));
        }

        [Test]
        public void TestFetchItems()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Item fetchItem = i.Fetch(shovel.FirstId);

            Assert.IsTrue(fetchItem == shovel);
            Assert.IsTrue(i.HasItem(shovel.FirstId));
        }

        [Test]
        public void TestTakenItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Take(shovel.FirstId);
            Assert.IsFalse(i.HasItem(shovel.FirstId));
        }
        [Test]
        
         public void TestItemList()
         {
             Inventory inventory = new Inventory();
             inventory.Put(shovel);
             inventory.Put(sword);

             Assert.IsTrue(inventory.HasItem(shovel.FirstId));
             Assert.IsTrue(inventory.HasItem(sword.FirstId));

             string expectedOutput = " a shovel (FirstId)\r\n a sword (FirstId)\r\n";
             Assert.That(expectedOutput, Is.EqualTo(inventory.ItemList));
         }


    }
}
