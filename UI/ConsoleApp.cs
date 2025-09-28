using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala.UI
{
	internal static class ConsoleApp
	{
		private static string blankPot = "         ";


		public static void DevReadout(Mancala.Code.Table gameState)
		{

			int playerCount = 2;
			int currentPlayer = gameState.GetCurrentPlayer();

			Console.WriteLine("Mancala\n\r\n\r");

			for(int i = 0; i < playerCount; i ++)
			{
				Console.WriteLine(".....................................");
				Console.WriteLine("Player " + (i + 1).ToString());
				Console.WriteLine(".....................................");
				Console.WriteLine("pots : ");
				string potReadout="";
				foreach(int pot in gameState.GetPlayerPots(i))
				{ potReadout += FormatPot(pot); }
				Console.WriteLine(potReadout);
				Console.WriteLine("home : ");
				Console.WriteLine(FormatPot(gameState.GetPlayerHome(i)));
				Console.WriteLine("current turn : " + (i == currentPlayer).ToString() + "\n\r");
				Console.WriteLine("index : " + (gameState.GetPlayerIndex(i)).ToString());
				Console.WriteLine(".....................................\n\r");
			}

		}

		public static void RenderGame(Mancala.Code.Table gameState)
		{
			int potCount = gameState.GetP1Pots().Count();
			int currentPlayer = gameState.GetCurrentPlayer();
			int potIndex = 0;

// Title

			Console.WriteLine("Mancala\n\r\n\r");

//Player Indecator

			for(int i = 0; i < ((potCount/2)-2); i++)
			{ Console.Write(blankPot); }
			Console.Write("Player 1     ");
			
			if (currentPlayer == 0)
			{ Console.Write("  < []   "); }
			else if (currentPlayer == 1)
			{ Console.Write("    [] > "); }
			else
			{ throw new Exception("Console UI. Player line. Invalid player index!"); }
				
			Console.Write("     Player 2");

			Console.Write("\n\r\n\r");

// Player 1 Pots
			
			int p1Index = gameState.GetP1Index();
			
			potIndex = 0;

			foreach( var pot in gameState.GetP1Pots().Reverse())
			{
				//Console.Write("  ");
				if(currentPlayer == 0 && p1Index == potIndex)
				{ Console.Write(HighlightPot(pot,currentPlayer)); }
				else
				{ Console.Write(FormatPot(pot)); }
				
				potIndex++;
			}

			Console.Write("\n\r\n\r");

// Move Indcator?

// Home pots (Move Indecator?)

			Console.Write(FormatPot(gameState.GetP1Home()));

			for (int i = 0; i < (potCount - 2); i++)
			{ Console.Write(blankPot); }

			Console.Write(FormatPot(gameState.GetP2Home()));

			Console.Write("\n\r\n\r");

			// Move Indcator?

			// Player 2 Pots

			int p2Index = gameState.GetP2Index();

			potIndex = 0;

			foreach (var pot in gameState.GetP2Pots())
			{
				//Console.Write("  ");
				if (currentPlayer == 1 && p2Index == potIndex)
				{ Console.Write(HighlightPot(pot, currentPlayer)); }
				else
				{ Console.Write(FormatPot(pot)); }

				potIndex++;
			}

			Console.Write("\n\r\n\r");

		}

		public static void PrintTable(Mancala.Code.Table gameState)
		{
			Console.ForegroundColor = ConsoleColor.Gray;

			int[] p1Pots = gameState.GetP1Pots();
			int[] p2Pots = gameState.GetP2Pots();

			int p1Home = gameState.GetP1Home();
			int p2Home = gameState.GetP2Home();

			
			
			string p1 = blankPot;
			string home = "";
			string p2 = blankPot;

			

			foreach(int pot in p1Pots)
			{ p1 += FormatPot(pot); }

			home += FormatPot(p1Home);
			
			for(int i = 0; i < p1Pots.Length; i++)
			{ home += blankPot; }
			
			home += FormatPot(p2Home);

			foreach (int pot in p2Pots)
			{ p2 += FormatPot(pot); }

			Console.WriteLine("Mancala\n\r\n\r");
			Console.WriteLine(p1); 
			Console.WriteLine(home);
			Console.WriteLine(p2);

			Console.ResetColor();

		}

		public static void HighlghtPlayer(Mancala.Code.Table gameState)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;

			if(gameState.GetCurrentPlayer() == 1)
			{
				int index = gameState.GetP1Index();

				Console.SetCursorPosition((index+1) * blankPot.Length+2,3);
				Console.Write("<");
				Console.SetCursorPosition((index + 1) * blankPot.Length + (blankPot.Length - 3), 3);
				Console.Write("<");

			}
			else if (gameState.GetCurrentPlayer() == 2)
			{
				int index = gameState.GetP2Index();

				Console.SetCursorPosition((index + 1) * blankPot.Length + 2, 5);
				Console.Write(">");
				Console.SetCursorPosition((index + 1) * blankPot.Length + (blankPot.Length - 3), 5);
				Console.Write(">");

			}

			Console.ResetColor();
		
		}

		private static string FormatPot(int pot)
		{
			if(pot <10)
			{ return $"  [ {pot} ]  "; }
			else if (pot > 9 && pot < 100)
			{ return $"  [{pot} ]  "; }
			else
			{ return $"  {pot}  "; }

		}

		private static String HighlightPot(int pot, int playerIndex)
		{
			String highlight;

			if(playerIndex == 0)
			{ highlight = "<"; }
			else if(playerIndex == 1)
			{ highlight = ">"; }
			else
			{ throw new Exception("ConsoleApp UI.HighlightPot.Invaild player index!"); }

			if (pot < 10)
			{ return $"  {highlight} {pot} {highlight}  "; }
			else if (pot > 9 && pot < 100)
			{ return $"  {highlight}{pot} {highlight}  "; }
			else
			{ return $"  {highlight}{pot}{highlight}  "; }

		}

	}
}
