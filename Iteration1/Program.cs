using System;

namespace Iteration1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Swin Adventure!");
            Console.Write("Enter your player name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your player description: ");
            string description = Console.ReadLine();
            Player player = new Player(name, description);

            Item weapon = new Item(new string[] { "shovel", "spade" }, "shovel", "This is a might fine");
            Item armour = new Item(new string[] { "armour", "shield" }, "armour", "The most enduring netherite armour");

            Item map = new Item(new string[] { "map" }, "map", "Find your way out");

            player.Inventory.Put(weapon);
            player.Inventory.Put(armour);

            Bag bag = new Bag(new string[] { "bag", "level_1" }, "level_1 bag", "low storage capacity bag");
            player.Inventory.Put(bag);

            Item potion = new Item(new string[] {"potion", "energy"}, "healing potion", "Heals Player when consumed");
            bag.Inventory.Put(potion);

            Location WestWoods = new Location(new string[] { "cabin" }, "cabin", "a cozy cabin");
            Location EastCompany = new Location(new string[] { "company" }, "company", "the profit generator");
            Location NorthPole = new Location(new string[] { "igloo" }, "igloo", "Follow the north star");
            Location Southpole = new Location(new string[] { "freezer" }, "freezer", "Witness the aurora australis");
            Path wToe = new Path(new string[] { "opp"}, "opp_direction", "Towrards the eastern sky", WestWoods, EastCompany);
            Path wTon = new Path(new string[] { "north" }, "north_direction", "Towards the northpole", WestWoods, NorthPole);
            Path wTos = new Path(new string[] { "south" }, "south_direction", "Towards the southpole", WestWoods, Southpole);

            player.Location = WestWoods;

            player.Location.AddPath(wToe);
            player.Location.AddPath(wTon);
            WestWoods.AddPath(wTos);

            WestWoods.InventoryAtLoc.Put(map);

            Command newCommand = new CommandProcessor();
           
            Console.WriteLine("Type 'quit' to exit.");
            string[] choiceList = new[] {""};
            while (true)
            {
                Console.Write("\nCommand: ");
                string choice = Console.ReadLine();
                choiceList = choice.Split(" ");
                Console.Write(newCommand.Execute(player, choiceList));
                if(choiceList[0]=="quit" || choiceList[0]=="Quit")
                {
                    break;
                }
            }
        }
    }
}
