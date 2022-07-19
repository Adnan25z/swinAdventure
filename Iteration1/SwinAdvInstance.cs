using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration1
{
    public enum GameState
    {
        ReadingName,
        ReadingDesc,
        PlayingGame
    }

    public class SwinAdvInstance
    {
        string _output;

        GameState _gameState;
        string _name, _desc;

        Player _player;
        Command c = new CommandProcessor();

        Bag bag = new Bag(new string[] { "bag", "level_1" }, "level_1 bag", "low storage capacity bag");

        Item weapon = new Item(new string[] { "shovel", "spade" }, "shovel", "This is a might fine");
        Item armour = new Item(new string[] { "armour", "shield" }, "armour", "The most enduring netherite armour");
        Item gem = new Item(new string[] { "gem" }, "phosphophyllite", "An emerald-green gem of about three-and-a-half hardness.");
        Item map = new Item(new string[] { "map" }, "map", "Find your way out");


        Item potion = new Item(new string[] { "potion", "energy" }, "healing potion", "Heals Player when consumed");

        Location WestWoods = new Location(new string[] { "cabin" }, "cabin", "a cozy cabin");
        Location EastCompany = new Location(new string[] { "company" }, "company", "the profit generator");
        Location NorthPole = new Location(new string[] { "igloo" }, "igloo", "Follow the north star");
        Location Southpole = new Location(new string[] { "freezer" }, "freezer", "Witness the aurora australis");

        public SwinAdvInstance()
        {
            Path wToe = new Path(new string[] { "opp" }, "opp_direction", "Towrards the eastern sky", WestWoods, EastCompany);
            Path wTon = new Path(new string[] { "north" }, "north_direction", "Towards the northpole", WestWoods, NorthPole);
            Path wTos = new Path(new string[] { "south" }, "south_direction", "Towards the southpole", WestWoods, Southpole);

            WestWoods.AddPath(wToe);
            WestWoods.AddPath(wTon);
            WestWoods.AddPath(wTos);

            WestWoods.InventoryAtLoc.Put(map);
            bag.Inventory.Put(potion);

            _gameState = GameState.ReadingName;

            _output = "Welcome to SwinAdventure !\n " +
                "What is your name?\n";
        }

        public string Output
        {
            get
            {
                return _output;
            }
        }

        public string InputCommand(string cmd)
        {
            switch (_gameState)
            {
                case GameState.ReadingName:
                    _name = cmd;
                    _gameState = GameState.ReadingDesc;
                    return _name + "\nPlease describe yourself?\n";

                case GameState.ReadingDesc:
                    _desc = cmd;
                    _gameState = GameState.PlayingGame;

                    _player = new Player(_name, _desc);

                    _player.Location = WestWoods;

                    _player.Inventory.Put(weapon);
                    _player.Inventory.Put(armour);
                    bag.Inventory.Put(gem);
                    _player.Inventory.Put(bag);

                    return "Welcome, " + _name + ", " + _desc + "! \nYou are stuck at this maze which never seems to end.\nFind your way out!\n";
            }
        
            return c.Execute(_player, cmd.Split());
           
        }
    }
}
