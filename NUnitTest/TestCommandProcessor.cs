using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Iteration1
{
    [TestFixture]
    public class TestCommandProcessor
    {
        private Player _player;
        private LookCommand _testLook;
        private MoveCommand _testMove;
        private CommandProcessor _processor;
        private Location WestWoods;
        private Location EastCompany;
        private Path west;

        [SetUp()]
        public void SetUp()
        {
            _player = new Player("Adnan", "Player 1");
            _testLook = new LookCommand();
            _testMove = new MoveCommand();
            _processor = new CommandProcessor();
            EastCompany = new Location(new string[] { "company" }, "company", "the profit generator");
            WestWoods = new Location(new string[] { "cabin" }, "cabin", "a cozy cabin");
            west = new Path(new string[] { "west" }, "west", "Towards the western horizon", WestWoods, EastCompany);

            //For setting location and path for player.
            _player.Location = WestWoods;
            WestWoods.AddPath(west);
        }

        [Test()]
        public void LookTest()
        {
            Console.WriteLine(_processor.Execute(_player, new string[3] { "look", "at", "me" }));
            Assert.IsTrue(_processor.Execute(_player, new string[3] { "look", "at", "me" }) == _player.FullDescription);
        }

        [Test()]
        public void MoveTest()
        { 
            Assert.AreEqual("You are heading in west.\n i.e. Towards the western horizon", _processor.Execute(_player, new string[] { "move", "west" }));
        }
    }
}
