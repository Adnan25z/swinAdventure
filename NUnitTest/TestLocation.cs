using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Iteration1
{
    public class TestLocation
    {
        private Location _location;
        private Player _p;
        private Item _weapon;
        private Item _armour;
        private Item _potion;

        [SetUp]
        public void Setup()
        {
            _location = new Location(new string[] {"north"}, "north", "Follow the north star");
            _p = new Player("Adnan", "player 1");
            _potion = new Item(new string[] { "potion", "energy" }, "healing potion", "Heals Player when consumed");
            _weapon = new Item(new string[] { "shovel", "spade" }, "shovel", "This is a might fine");
            _armour = new Item(new string[] { "armour", "shield" }, "armour", "The most enduring netherite armour");


            _location.InventoryAtLoc.Put(_weapon);
            _location.InventoryAtLoc.Put(_armour);
            _location.InventoryAtLoc.Put(_potion);
        }

        [Test]
        public void TestLocationIsIdentifiable()
        {
            Assert.True(_location.AreYou("North"));
        }

        [Test]
        public void TestLocationLocatesItems()
        {
            Assert.AreSame(_weapon, _location.Locate("shovel"));
            Assert.AreSame(_armour, _location.Locate("armour"));
            Assert.AreSame(_potion, _location.Locate("potion"));
        }

        [Test]
        public void TestLocationLocatesItself()
        {
            Assert.AreSame(_location, _location.Locate("North"));
        }

        [Test]
        public void TestLocationLocatesNothing()
        {
            Assert.AreEqual(null, _location.Locate("West"));
        }

        [Test]
        public void TestLocationFullDescription()
        {
            Assert.AreEqual("You are going north.\nFollow the north star\nIn this place you can view:\n\tA shovel (shovel)\n\tA armour (armour)\n\tA healing potion (potion)", _location.FullDescription);
        }

        [Test]
        public void TestLocationName()
        {
            Assert.AreEqual("north", _location.Name);
        }

        [Test]
        public void PlayerLocateTest()
        {
            _p.Location = _location;
            Assert.IsTrue(_p.Location.Locate("armour") == _armour);
        }
    }
}

