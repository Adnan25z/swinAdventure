using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    [TestFixture]
    public class TestPlayer
    {
        Player _player;
        Item TestItem;
        [SetUp]
        public void Setup()
        {
            _player = new Player("Adnan", "player 1");
            TestItem = new Item(new string[] { "sword", "shield" }, "bronze sword", "A grand bronze sword from years ago");
            _player.Inventory.Put(TestItem);
        }

        [Test]
        public void TestPlayerIsIdentifiable()
        {
            Assert.True(_player.AreYou("me"));
            Assert.True(_player.AreYou("inventory"));
        }

        [Test]
        public void TestPlayerLocatesItems()
        {
            Assert.AreSame(TestItem, _player.Locate("sword"));
        }

        [Test]
        public void TestPlayerLocatesItself()
        {
            Assert.AreSame(_player, _player.Locate("me"));
        }

        [Test]
        public void TestPlayerLocatesNothing()
        {
            Assert.AreEqual(null, _player.Locate("fail"));
        }

        [Test]
        public void TestPlayerFullDescription()
        {
            Assert.AreEqual("You are Adnan player 1\nYou are carrying:\n\n\tA bronze sword (sword)", _player.FullDescription);
        }
    }
}
