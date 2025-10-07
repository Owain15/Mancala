using Mancala.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala.cl
{
	public class Game
	{
		public void Run()
		{
			Mancala.cl.Code.Table table = new Mancala.cl.Code.Table(8);

			bool isRunning = true;

			while (isRunning)
			{
				// Turn set up
				table.SetPlayerIndex();

				//render display
				//Mancala.cl.UI.DisplayInterface.RenderTable();

				////Mancala.UI.ConsoleApp.RenderGame(table);


				//get input
				//Mancala.cl.UI.Command command = Mancala.cl.UI.InputInterface.GetCommand();
				////Mancala.UI.Input.GetCommand();

				//update game state
				//table.UpdateGameState(command);

				//evaluate gamestate

				isRunning = table.CheckForEndOfGame();

			}

		}
	}
}
