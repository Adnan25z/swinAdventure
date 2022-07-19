using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public class MoveCommand : Command
    {
        public MoveCommand() : base(new string[] { "move", "go", "head", "leave" })
        { }

        public override string Execute(Player p, string[] text)
        {
            // Check whether text is a valid length
            if (text.Length > 2 && text.Length == 0)
                return "I don't know how to move like that.";

            Location currentLocation = p.Location;  // get players location

            // check if first word is move. otherwise this is an error
            if (text[0] != "move" && text[0] != "leave" && text[0] != "go" && text[0] != "head")
                return "Error in command";

            // get the next path from the location
            Path nextPath = currentLocation.GetPath(text[1]);

            if (nextPath is null) // There is no path
                return "Invalid path identifier";
            else
            {
                nextPath.MovePlayer(p); // There is a path, path moves player to its location
                return nextPath.FullDescription;    // returns paths description
            }
        }

       
    }
}
