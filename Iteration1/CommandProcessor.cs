using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public class CommandProcessor : Command
	{
		private List<Command> _commands;

		public CommandProcessor() : base(new string[] {"commandprocessor"})
		{
			_commands = new List<Command>();
			_commands.Add(new LookCommand());
			_commands.Add(new MoveCommand());
			_commands.Add(new TakeCommand());
			_commands.Add(new PutCommand());
			_commands.Add(new QuitCommand());
		}


		public override string Execute(Player p, string[] text)
		{
			foreach (Command c in _commands)
			{
				if (c.AreYou(text[0].ToLower()))
				{
					return c.Execute(p, text);
				}
			}
			return "Invalid command.";
		}

	}
}
