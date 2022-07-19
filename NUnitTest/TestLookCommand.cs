using NUnit.Framework;
using System;

namespace Iteration1
{
    [TestFixture()]
    public class LookCommandTests
    {
        private Item _shovel, _sword, _gem;
        private Player _me;
        private Bag _bag1;
        private LookCommand _look;

        [SetUp]
        public void Setup()
        {
            _sword = new Item(new string[] { "sword", "bronze" }, "bronze sword", "a grand bronze sword from years ago");
            _shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "This is a might fine");
            _gem = new Item(new string[] { "gem", "shiny" }, "shiny gem", "this is a shiny gem ");
            _me = new Player("Adnan", "player 1");
            _look = new LookCommand();
            _bag1 = new Bag(new string[] { "bag", "level_1" }, "level_1 bag", "low storage capacity bag");
        }
        

        [Test()]
        public void TestLookAtMe()
        {
            _me.Inventory.Put(_sword);
            Assert.AreEqual(_look.Execute(_me, new string[] { "look", "at", "inventory" }), _me.FullDescription);
        }


        [Test()]
        public void TestLookAtGem()
        {
            _me.Inventory.Put(_gem);
            Assert.AreEqual(_look.Execute(_me, new string[] { "look", "at", "gem" }), _gem.FullDescription);
        }


        [Test()]
        public void TestLookAtUnk()
        {
            Assert.AreEqual(_look.Execute(_me, new string[] { "look", "at", "gem" }), "I can't find the gem\n");
        }

        [Test()]
        public void TestLookAtGemInMe()
        {
            _me.Inventory.Put(_gem);
            Assert.AreEqual(_look.Execute(_me, new string[] { "look", "at", "gem", "in", "inventory" }), _gem.FullDescription);
        }

        [Test()]
        public void TestLookAtGemInBag()
        {
            _bag1.Inventory.Put(_gem);
            _me.Inventory.Put(_bag1);


            Assert.AreEqual(_look.Execute(_me, new string[] { "look", "at", "gem", "in", "bag" }),_gem.FullDescription);
        }

        [Test()]
        public void TestLookAtGemInNoBag()
        {   
            _me.Inventory.Put(_gem);
            Assert.AreEqual(_look.Execute(_me, new string[] { "look", "at", "gem", "in", "bag" }), "I cannot find the bag\n");
        }

        [Test()]
        public void TestLookAtNoGemInBag()
        {
            _me.Inventory.Put(_bag1);
            Assert.AreEqual(_look.Execute(_me, new string[] { "look", "at", "gem", "in", "bag" }), "I can't find the gem\n");
        }

        [Test()]
        public void TestInvalidLook()
        {
            Assert.AreEqual(_look.Execute(_me, new string[] { "stare", "at", "gem" }), "Error in look input\n");
        }
    }
}
