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

		//(Player P1, Player P2) players;
		Player[] players;

		int currentPlayer;

		int potCount;

		public Table(int PotCount)
		{
			potCount = PotCount;

			players = new Player[2];
			players[0] = new Player(potCount);
			players[1] = new Player(potCount);
			//players = (new Player(potCount), new Player(potCount));

			currentPlayer = 0;
		}


		public int GetCurrentPlayer()
		{ return currentPlayer; }

		public int[] GetP1Pots()
		{ return players[0].GetPots(); }

		public int[] GetP2Pots()
		{ return players[1].GetPots(); }

		public (int[] P1, int[] P2) GetPots()
		{ return (players[0].GetPots(), players[1].GetPots()); }

		public int[] GetPlayerPots(int player)
		{
			if (player < 0 || player > 1)
			{
				throw new Exception("Invalid player input!");
			}

			if (player == 0)
			{ return GetP1Pots(); }
			else if (player == 1)
			{ return GetP2Pots(); }
			else
			{ throw new Exception("Player Pot data not found!"); }
		}



		public int GetP1Home()
		{ return players[0].GetHome(); }

		public int GetP2Home()
		{ return players[1].GetHome(); }

		public (int P1 , int P2) GetHomes()
		{ return (players[0].GetHome(), players[1].GetHome()); }

		public int GetPlayerHome(int player)
		{
			if (player < 0 || player > 1)
			{
				throw new Exception("Invalid player input!");
			}

			if (player == 0)
			{ return GetP1Home(); }
			else if (player == 1)
			{ return GetP2Home(); }
			else
			{ throw new Exception("Player Home data not found!"); }
		}


		public int GetPlayerIndex(int player)
		{
			if(player < 0 || player > 1)
			{
				throw new Exception("Invalid player input!");
			}

			if(player == 0)
			{ return GetP1Index(); }
			else if(player == 1)
			{ return GetP2Index(); }
			else
			{ throw new Exception("Player index data not found!"); }

		}

		public int GetP1Index()
		{ return players[0].GetIndex(); }

		public int GetP2Index()
		{ return players[1].GetIndex(); }

		public (int P1, int P2) GetIndexs()
		{ return (players[0].GetIndex(), players[1].GetIndex()); }

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
			if (currentPlayer != 0 && currentPlayer != 1 )
			{ throw new Exception("Current player not found!"); }

			players[currentPlayer].UpdateIndex(input);
		}

		private void RunCommand()
		{
			int moveValue = 0;
			int index = -1;
			int cachedPlayer = currentPlayer;

			if(currentPlayer == 0)
			{ 
				moveValue = players[0].GetandClearCurrentPot();
				index = players[0].GetIndex() + 1;
			}
			if (currentPlayer == 1)
			{
				moveValue = players[1].GetandClearCurrentPot();
				index = players[1].GetIndex() + 1;
			}

			while (moveValue > 0)
			{
				if (currentPlayer == 0)
				{
					moveValue = players[0].UpdatePotValues(index, moveValue,(currentPlayer == cachedPlayer)); 
				}
				if (currentPlayer == 1)
				{
					moveValue = players[1].UpdatePotValues(index, moveValue, (currentPlayer == cachedPlayer)); 
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
			if(currentPlayer == 0)
			{ currentPlayer = 1; }
			else if(currentPlayer == 1)
			{ currentPlayer = 0; }
			else
			{ throw new Exception("Failed To Change Current Player!"); }
		
		}

		public bool CheckForEndOfGame()
		{
			return players[0].CanMakeMove() || players[1].CanMakeMove();
		}

		public void SetPlayerIndex()
		{
			if (players[currentPlayer].GetPot(players[currentPlayer].GetIndex()) == 0 )
			{ players[currentPlayer].UpdateIndex(UI.Input.Command.right); }
		}
	}
}
