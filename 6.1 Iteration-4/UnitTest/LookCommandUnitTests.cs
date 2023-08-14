using NUnit.Framework;
using Swin_Adventure;

namespace UnitTests
{
    public class LookCommandUnitTests
    {
        private LookCommand _look;
        private Player _playerReady;
        private Bag _bag;
        private Item _itemKL;       

        string notFind, noBag, notLength, badLook,badAt, badIn;

        [SetUp()]
        public void Setup()
        {
            _look = new();
            _playerReady = new("Kayes", "The key player of this Game ");
            _bag = new(new string[] { "Nike" }, "Nike", "The shoes Brand");
            _itemKL = new(new string[] { "Rifle" }, "Rifle", "Mine Craft");

            notFind = "I can't find the Rifle";
            noBag = "I cannot find the \n";
            notLength = "I don't know how to look like that\n";
            badLook = "Error in look input\n";
            badAt = "What do you want to look at?\n";
            badIn = "What do you want to look at?\n";
            _playerReady.Inventory.Put(_itemKL);
        }

        [Test()]
        public void TestLookAtMe()
        {
            string[] input = new string[] { "look", "at", "me" };
            string expected = _playerReady.FullDescription;
            string actual = _look.Execute(_playerReady, input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void TestLookAtItem()
        {
            string[] input = new string[] { "look", "at", "Rifle" };
            string expected = _itemKL.FullDescription;
            string actual = _look.Execute(_playerReady, input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void TestLookAtUnkn()
        {
            _playerReady.Inventory.Take("Rifle");
            string[] input = new string[] { "look", "at", "Rifle", "in", "inventory" };
            string expected = notFind;
            string actual = _look.Execute(_playerReady, input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void TestLookAtItemInInventory()
        {
            string[] input = new string[] { "look", "at", "Rifle", "in", "inventory" };
            string expected = _itemKL.FullDescription;
            string actual = _look.Execute(_playerReady, input);
            Assert.That(actual, Is.EqualTo(expected));
        }



        [Test()]
        public void TestLookAtItemInBag()
        {
            _playerReady.Inventory.Take("Rifle");
            _bag.Inventory.Put(_itemKL);
            _playerReady.Inventory.Put(_bag);
            string[] input = new string[] { "look", "at", "Rifle", "in", "Nike" };
            string expected = _itemKL.FullDescription;
            string actual = _look.Execute(_playerReady, input);
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test()]
        public void TestLookAtItemInNoBag()
        {
            string[] input = new string[] { "look", "at", "Rifle", "in", "" };
            string expected = noBag;
            string actual = _look.Execute(_playerReady, input);
            Assert.That(actual, Is.EqualTo(expected));
        }

     


        [Test()]
        public void TestLookAtNoItemInBag()
        {
            _playerReady.Inventory.Put(_bag);
            string[] input = new string[] { "look", "at", "Rifle", "in", "Nike" };
            string expected = notFind;
            string actual = _look.Execute(_playerReady, input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.AreEqual(notLength, _look.Execute(_playerReady, new string[] { "Cooool" }));
            Assert.AreEqual(badLook, _look.Execute(_playerReady, new string[] { "search", "at", "Rifle", "in", "Nike" }));
            Assert.AreEqual(badAt, _look.Execute(_playerReady, new string[] { "look", "for", "Rifle", "in", "Nike" }));
            Assert.AreEqual(badIn, _look.Execute(_playerReady, new string[] { "look", "for", "Rifle", "near", "Nike" }));
        }

       
    }
}