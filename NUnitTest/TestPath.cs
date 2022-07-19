using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Iteration1
{
    [TestFixture]
    public class TestPath
    {
        private Location _north;
        private Location _south;
        private Player _player;
        private Path _northsouthpath;

        private MoveCommand Move;
        

        [SetUp]
        public void SetUp()
        {
            _north = new Location(new string[] { "north" }, "north", "Follow the north star");
            _south = new Location(new string[] { "south" }, "south", "Witness the aurora australis");
            _player = new Player("Adnan", "Player 1");
            _northsouthpath = new Path(new string[] { "From north to the south" }, "NSPath", "the path from the north to the south", _north, _south);
            Move = new MoveCommand();

            //For setting location and path for player.
            _player.Location = _north;
            _north.AddPath(_northsouthpath);
        }

        [Test]
        public void TestGetPath()
        {
            Location expected = _south;
            Location actual = _northsouthpath.Final;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPathDescription()
        {
            string expected = "You are heading in NSPath.\n i.e. the path from the north to the south";
            string actual = _northsouthpath.FullDescription;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPlayerMoveNorthSouth()
        {
            Assert.AreEqual(_north, _player.Location);
            _northsouthpath.MovePlayer(_player);
            Assert.AreEqual(_south, _player.Location);
        }

        [Test]
        public void TestMovingCommand()
        {
            Location WestWoods = new Location(new string[] { "cabin" }, "cabin", "a cozy cabin");
            Location EastCompany = new Location(new string[] { "company" }, "company", "the profit generator");
            Path west = new Path(new string[] { "west" }, "west", "Towards the western horizon", WestWoods, EastCompany);
            Path east = new Path(new string[] { "east" }, "east", "Towrards the eastern sky", EastCompany, WestWoods);
            Player playertest = new Player("Ayaan", "player 2");
            playertest.Location = WestWoods;

            WestWoods.AddPath(west);

            Assert.AreEqual("You are heading in west.\n i.e. Towards the western horizon", Move.Execute(playertest, new string[] { "move", "west" }));
        }

        [Test]
        public void TestMoveInvalidPath()
        {
            Assert.AreEqual("Invalid path identifier", Move.Execute(_player, new string[] { "leave", "down" }));
        }
    }
}
