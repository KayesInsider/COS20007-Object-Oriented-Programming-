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
            _bag.Inventory.Put(_innerBag);

            GameObject foundInnerBag = _bag.Locate("innerbag");
            GameObject foundItem = _bag.Locate("item");

            Assert.AreEqual(_innerBag, foundInnerBag);
            Assert.IsNull(foundItem);
        }
    }
}
