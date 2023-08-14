using NUnit.Framework;
using Swin_Adventure;

namespace UnitTests
{

    public class BagUnitTests
    {
        private Bag _bag;
        private Item _item;
        private Bag _innerBag;

        [SetUp]
        public void SetUp()
        {
            _bag = new Bag(new string[] { "bag", "satchel" }, "bag", "A bag");
            _item = new Item(new string[] { "item" }, "item", "An item");
            _innerBag = new Bag(new string[] { "innerbag" }, "inner bag", "An inner bag");
        }

        [Test]
        public void TestBagLocatesItems()
        {
            _bag.Inventory.Put(_item);

            GameObject foundItem = _bag.Locate("item");

            Assert.AreEqual(_item, foundItem);
        }

        [Test]
        public void TestBagLocatesItself()
        {
            GameObject foundBag = _bag.Locate("bag");

            Assert.AreEqual(_bag, foundBag);
        }

        [Test]
        public void TestBagLocatesNothing()
        {
            GameObject foundObject = _bag.Locate("invalid");

            Assert.IsNull(foundObject);
        }

        [Test]
        public void TestBagFullDescription()
        {
            _bag.Inventory.Put(_item);

            string expectedDescription = $"In the {_bag.Name} you can see:\n{_bag.Inventory.ItemList}";
            string actualDescription = _bag.FullDesciption;

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestBagInBag()
        {
            Bag b1 = new Bag(new string[] { "bag1" }, "bag1", "Bag 1");
            Bag b2 = new Bag(new string[] { "bag2" }, "bag2", "Bag 2");
            Item item1 = new Item(new string[] { "item1" }, "item1", "Item 1");
            Item item2 = new Item(new string[] { "item2" }, "item2", "Item 2");

            b1.Inventory.Put(b2);
            b1.Inventory.Put(item1);
            b2.Inventory.Put(item2);

            GameObject foundBag2 = b1.Locate("bag2");
            GameObject foundItem1 = b1.Locate("item1");
            GameObject foundItem2InBag2 = b1.Locate("item2");

            Assert.AreEqual(b2, foundBag2);
            Assert.AreEqual(item1, foundItem1);
            Assert.IsNull(foundItem2InBag2);
        }


    }
}
