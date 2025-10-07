using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mancala.Code;
using Mancala.cl;

namespace Mancala.cl.Code
{
	public class Table
	{

		//(Player P1, Player P2) players;
		Player[] players;

		int currentPlayer;

		int potCount;

		bool displayMove;

		public Table(int PotCount)
		{
			potCount = PotCount;

			players = new Player[2];
			players[0] = new Player(potCount);
			players[1] = new Player(potCount);
			//players = (new Player(potCount), new Player(potCount));

			currentPlayer = 0;

			displayMove = true;
		
		}


		public bool GetDisplayMoveState()
		{ return displayMove; }

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


		public int GetPot(int player, int index)
		{
			// check player input
			if(player < 0 || player > players.Length)
			{
				throw new Exception("Table.GetPot Invalid player input!"); 
			}


			// check index input
			if (index < 0 || index > potCount)
			{
				throw new Exception("Table.GetPot Invalid player index!");
			}

			return players[player].GetPot(index);
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

		public void UpdateGameState(Mancala.cl.UI.Command input)
		{
			switch(input)
			{
				case Mancala.cl.UI.Command.left:
					{ UpdatePlayerIndex(input); break; }
				case Mancala.cl.UI.Command.right:
					{ UpdatePlayerIndex(input); break; }
				case Mancala.cl.UI.Command.enter:
					{ RunCommand(); break; }
				case Mancala.cl.UI.Command.escape:
					{ Environment.Exit(0); break; }
			}

		}

		private void UpdatePlayerIndex(Mancala.cl.UI.Command input)
		{
			if (currentPlayer != 0 && currentPlayer != 1 )
			{ throw new Exception("Current player not found!"); }

			if(currentPlayer == 0)
			{
				if(input == Mancala.cl.UI.Command.left)
				{ input = Mancala.cl.UI.Command.right; }
				else if (input == Mancala.cl.UI.Command.right)
				{ input = Mancala.cl.UI.Command.left; }
			}

			players[currentPlayer].UpdateIndex(input);
		}



		private void RunCommand()
		{
			int moveValue = 0;
			int index = -1;
			int cachedPlayer = currentPlayer;

			bool moveOnPot = false;

			if(currentPlayer != 0 && currentPlayer != 1)
			{ throw new Exception("Run command. Invalid current player!"); }

			moveValue = players[currentPlayer].GetandClearCurrentPot();
			index = players[currentPlayer].GetIndex() + 1;


			while (moveValue > 0)
			{
				(moveValue , index) = players[currentPlayer].UpdatePotValues(index, moveValue, (currentPlayer == cachedPlayer));

				// check if player landed on home
				if(moveValue == 0 && index == potCount)
				{
					moveOnPot = true;
				}
				// check if move ended on an empty pot.
				else if(index < potCount -1 && moveValue == 0 && currentPlayer == cachedPlayer && players[currentPlayer].GetPot(index) == 1 )
				{
					// Steal pot
					int targetPlayer = currentPlayer + 1;
					if(targetPlayer > players.Length-1)
					{ targetPlayer = 0; }

					int targetIndex = potCount - index - 1;

					players[currentPlayer].AddToHome(players[targetPlayer].GetandClearPot(targetIndex));

				}
				// setup next turn of the loop
				else 
				{
					UpdateCurrentPlayer();
					//set new index
					index = 0;
				}
	

			}

			currentPlayer = cachedPlayer;

			if(!moveOnPot)
			{ UpdateCurrentPlayer(); }
			

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
			{ players[currentPlayer].UpdateIndex(Mancala.cl.UI.Command.right); }
		}

		public (int[] P1 , int[] P2) GetMoveData()
		{

			int moveValue = players[currentPlayer].GetPot();

			int[] p1 = new int[potCount + 1];
			int[] p2 = new int[potCount + 1];


			int[] line = new int[p1.Length + p2.Length];
			
			int move = players[currentPlayer].GetPot();
			int index = players[currentPlayer].GetIndex();

			if(currentPlayer == 1)
			{
				index += potCount;
			}

			while(move > 0)
			{
				index++;

				// accout for not going in opponents home
				if (index == p1.Length-1 && currentPlayer == 1)
				{
					index++;
				}
				if (index == line.Length-1 && currentPlayer == 0)
				{
					index++;
				}

				if(index > line.Length-1)
				{ index = 0; }



				if(move == 1)
				{ line[index] = -1; }
				else
				{ line[index]++; }

				move--;
			}

			for(int i = 0; i < line.Length; i++)
			{
				if(i < p1.Length)
				{ p1[i] = line[i]; }
				else
				{ p2[i - p1.Length] = line[i]; }
			}



			return (p1,p2);
		}

	}
}
