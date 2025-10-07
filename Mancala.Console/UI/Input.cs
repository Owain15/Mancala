using Mancala.cl.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala.Console._2.UI
{
	internal class Input
	{
		public static Mancala.cl.UI.Command GetCommand()
		{
			bool validInputFound = false;

			ConsoleKey key = ConsoleKey.None;

			while (!validInputFound)
			{
				key = System.Console.ReadKey(true).Key;

				if (
				   key == ConsoleKey.LeftArrow
				|| key == ConsoleKey.RightArrow
				|| key == ConsoleKey.Enter
				|| key == ConsoleKey.Escape
				   )
				{ validInputFound = true; }

			}

			if (key == ConsoleKey.LeftArrow)
			{ return Command.left; }
			else if (key == ConsoleKey.RightArrow)
			{ return Command.right; }
			else if (key == ConsoleKey.Enter)
			{ return Command.enter; }
			else if (key == ConsoleKey.Escape)
			{ return Command.escape; }
			else
			{ throw new Exception("Input Failed!"); }

		}

	}
	
}
