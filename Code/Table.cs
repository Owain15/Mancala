using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mancala.Code;

namespace Mancala.Code
{
	internal class Table
	{

		(Player P1, Player P2) players;

		int currentPlayer;

		int potCount;

		public Table(int PotCount)
		{
			potCount = PotCount;

			players = (new Player(potCount), new Player(potCount));

			currentPlayer = 1;
		}


		public int GetCurrentPlayer()
		{ return currentPlayer; }

		public int[] GetP1Pots()
		{ return players.P1.GetPots(); }

		public int[] GetP2Pots()
		{ return players.P2.GetPots(); }

		public (int[] P1, int[] P2) GetPots()
		{ return (players.P1.GetPots(), players.P2.GetPots()); }

		public int[] GetPlayerPots(int player)
		{
			if (player < 1 || player > 2)
			{
				throw new Exception("Invalid player input!");
			}

			if (player == 1)
			{ return GetP1Pots(); }
			else if (player == 2)
			{ return GetP2Pots(); }
			else
			{ throw new Exception("Player Pot data not found!"); }
		}



		public int GetP1Home()
		{ return players.P1.GetHome(); }

		public int GetP2Home()
		{ return players.P2.GetHome(); }

		public (int P1 , int P2) GetHomes()
		{ return (players.P1.GetHome(), players.P2.GetHome()); }

		public int GetPlayerHome(int player)
		{
			if (player < 1 || player > 2)
			{
				throw new Exception("Invalid player input!");
			}

			if (player == 1)
			{ return GetP1Home(); }
			else if (player == 2)
			{ return GetP2Home(); }
			else
			{ throw new Exception("Player Home data not found!"); }
		}


		public int GetPlayerIndex(int player)
		{
			if(player < 1 || player > 2)
			{
				throw new Exception("Invalid player input!");
			}

			if(player == 1)
			{ return GetP1Index(); }
			else if(player == 2)
			{ return GetP2Index(); }
			else
			{ throw new Exception("Player index data not found!"); }

		}

		public int GetP1Index()
		{ return players.P1.GetIndex(); }

		public int GetP2Index()
		{ return players.P2.GetIndex(); }

		public (int P1, int P2) GetIndexs()
		{ return (players.P1.GetIndex(), players.P2.GetIndex()); }

		public void UpdateGameState(Mancala.UI.Input.Command input)
		{
			switch(input)
			{
				case UI.Input.Command.left:
					{ UpdatePlayerIndex(input); break; }
				case UI.Input.Command.right:
					{ UpdatePlayerIndex(input); break; }
				case UI.Input.Command.enter:
					{ RunCommand(); break; }
				case UI.Input.Command.escape:
					{ Environment.Exit(0); break; }
			}

		}

		private void UpdatePlayerIndex(Mancala.UI.Input.Command input)
		{
			if (currentPlayer == 1)
			{ players.P1.UpdateIndex(input); }
			if (currentPlayer == 2)
			{ players.P2.UpdateIndex(input); }
		}

		private void RunCommand()
		{
			int moveValue = 0;
			int index = -1;
			int cachedPlayer = currentPlayer;

			if(currentPlayer == 1)
			{ 
				moveValue = players.P1.GetandClearCurrentPot();
				index = players.P1.GetIndex() + 1;
			}
			if (currentPlayer == 2)
			{
				moveValue = players.P2.GetandClearCurrentPot();
				index = players.P2.GetIndex() + 1;
			}

			while (moveValue > 0)
			{
				if (currentPlayer == 1)
				{
					moveValue = players.P1.UpdatePotValues(index, moveValue,(currentPlayer == cachedPlayer)); 
				}
				if (currentPlayer == 2)
				{
					moveValue = players.P2.UpdatePotValues(index, moveValue, (currentPlayer == cachedPlayer)); 
				}

				UpdateCurrentPlayer();
				
				//set new index
				index = 0; 

			}

			currentPlayer = cachedPlayer;
			UpdateCurrentPlayer();

		}


		private void UpdateCurrentPlayer()
		{ 
			if(currentPlayer == 1)
			{ currentPlayer = 2; }
			else if(currentPlayer == 2)
			{ currentPlayer = 1; }
			else
			{ throw new Exception("Failed To Change Current Player!"); }
		
		}
	}
}
