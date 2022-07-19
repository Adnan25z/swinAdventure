using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public class QuitCommand : Command
    {
        public QuitCommand() : base(new string[] { "quit" })
        { }
        public override string Execute(Player p, string[] text)
        {
            if (text[0] == "quit")
            {
                return "bye!";
            }
            return null;
        }
    }
}
