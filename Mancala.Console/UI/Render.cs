using Mancala.cl.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala.Console._2.UI
{
	internal class Render 
	{
		private static string blankPot = "         ";
		private static string markPot = "    .    ";
		private static string markLastPot = "    X    ";

		public static void RenderTable(Mancala.cl.Code.Table table)
		{
			System.Console.Clear();


			int potIndex = 0;
			int potCount = table.GetP1Pots().Count();
			int currentPlayer = table.GetCurrentPlayer();

			(int[] p1, int[] p2) moveData;

			if (table.GetDisplayMoveState())
			{ moveData = table.GetMoveData(); }
			else { moveData = (new int[0], new int[0]); }

			// Title

			System.Console.WriteLine("Mancala\n\r\n\r");

			//Player Indecator

			System.Console.Write(blankPot);

			for (int i = 0; i < ((potCount / 2) - 2); i++)
			{ System.Console.Write(blankPot); }

			System.Console.Write("Player 1     ");

			if (currentPlayer == 0)
			{ System.Console.Write("  < []   "); }
			else if (currentPlayer == 1)
			{ System.Console.Write("    [] > "); }
			else
			{ throw new Exception("Console UI. Player line. Invalid player index!"); }

			System.Console.Write("     Player 2");

			System.Console.Write("\n\r\n\r");

			// Player 1 Pots

			int p1Index = table.GetP1Index();

			potIndex = potCount - 1;

			System.Console.Write(blankPot);

			foreach (var pot in table.GetP1Pots().Reverse())
			{
				//Console.Write("  ");
				if (currentPlayer == 0 && p1Index == potIndex)
				{ System.Console.Write(HighlightPot(pot, currentPlayer)); }
				else
				{ System.Console.Write(FormatPot(pot)); }

				potIndex--;
			}

			System.Console.Write("\n\r");

			// Move Indcator?

			if (table.GetDisplayMoveState())
			{
				System.Console.Write(blankPot);

				for (int i = moveData.p1.Length - 2; i > -1; i--)
				{
					PrintMoveIndicator(moveData.p1[i]);
				}

				System.Console.Write("\n\r");

			}
			else { System.Console.WriteLine(); }

			// Home pots (Move Indecator?)


			System.Console.Write(FormatPot(table.GetP1Home()));

			if (table.GetDisplayMoveState())
			{
				PrintMoveIndicator(moveData.p1[potCount]);
			}
			else
			{ System.Console.Write(blankPot); }

			for (int i = 0; i < (potCount - 2); i++)
			{
				System.Console.Write(blankPot);
			}

			if (table.GetDisplayMoveState())
			{
				PrintMoveIndicator(moveData.p2[potCount]);
			}
			else
			{ System.Console.Write(blankPot); }

			System.Console.Write(FormatPot(	table.GetP2Home()));

			System.Console.Write("\n\r");

			// Move Indicator?

			if (table.GetDisplayMoveState())
			{
				System.Console.Write(blankPot);

				for (int i = 0; i < moveData.p2.Length - 1; i++)
				{
					//Console.Write(markPot);
					PrintMoveIndicator(moveData.p2[i]);
				}

				System.Console.Write("\n\r");

			}
			else { System.Console.WriteLine(); }

			// Player 2 Pots

			int p2Index = table.GetP2Index();

			potIndex = 0;

			System.Console.Write(blankPot);

			foreach (var pot in table.GetP2Pots())
			{
				//Console.Write("  ");
				if (currentPlayer == 1 && p2Index == potIndex)
				{ System.Console.Write(HighlightPot(pot, currentPlayer)); }
				else
				{ System.Console.Write(FormatPot(pot)); }

				potIndex++;
			}

			System.Console.Write("\n\r\n\r");

		}

		private static void PrintMoveIndicator(int indicator)
		{
			switch (indicator)
			{
				case -1: { System.Console.Write(markLastPot); break; }
				case 0: { System.Console.Write(blankPot); break; }
				default: { System.Console.Write(markPot); break; }
			}

		}

		private static string FormatPot(int pot)
		{
			if (pot < 10)
			{ return $"  [ {pot} ]  "; }
			else if (pot > 9 && pot < 100)
			{ return $"  [{pot} ]  "; }
			else
			{ return $"  {pot}  "; }

		}

		private static String HighlightPot(int pot, int playerIndex)
		{
			String highlight;

			if (playerIndex == 0)
			{ highlight = "<"; }
			else if (playerIndex == 1)
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
