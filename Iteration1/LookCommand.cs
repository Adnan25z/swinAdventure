using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] {"look"})
        { }

        public override string Execute(Player p, string[] text)
        {
            if(text.Length != 3 && text.Length != 5)
            {
                return "I don't know how to look like that\n";
            }
            
            if (text[0] != "look")
            {
                return "Error in look input\n";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?\n";
            }

            if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in?\n";
                }
            }

            if (text.Length == 3)
            {
                if (LookAtIn(text[2], p as IHaveInventory) == null)
                {
                    return LookAtIn(text[2], p.Location);
                }
                return LookAtIn(text[2], p as IHaveInventory);
            }

            if (text.Length == 5)
            {
                string itemToFind = text[2];
                string placeToLookIn = text[4];
                IHaveInventory container = FetchContainer(p, placeToLookIn);
                if (container is null)
                {
                    return $"I cannot find the {placeToLookIn}\n";
                }
                return LookAtIn(itemToFind, container);
            }

            return "Success";
        }

        public IHaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                return container.Locate(thingId).FullDescription;
            }

            return $"I can't find the {thingId}\n";
            
        }
    }
}
