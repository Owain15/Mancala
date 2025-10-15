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

#region Properties

		private Mancala.cl.Code.Table table;

		private int potCount;

		#endregion

		public Game()
		{
			potCount = 8;

			table = new Code.Table(potCount); 
		}

		public Game(int gamePotCount)
		{
			potCount = gamePotCount;

			table = new Code.Table(potCount);
		}


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

		public void UpdateGameState(Mancala.cl.UI.Command input)
		{
			table.UpdateGameState(input);
		}

		public int GetCurrentPlayer()
		{
			return table.GetCurrentPlayer();
		}

		public int[] GetPots(int playerIndex)
		{ return table.GetPlayerPots(playerIndex - 1); }

		public int GetIndex(int playerIndex)
		{ return table.GetPlayerIndex(playerIndex - 1); }

		public int GetHomeValue(int playerIndex)
		{ return table.GetPlayerHome(playerIndex - 1); }

	
	}

}
