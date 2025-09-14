using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala.UI
{
	internal static class ConsoleApp
	{
		public static void PrintTable(Mancala.Code.Table gameState)
		{

			int[] p1Pots = gameState.GetP1Pots();
			int[] p2Pots = gameState.GetP2Pots();
			
			string p1 = "  ";
			string home = "  ";
			string p2 = "  ";

			foreach(int pot in p1Pots)
			{
				if(pot < 10)
				{
					p1 += $"[ {pot.ToString()} ]  ";
				}
				else { p1 += $"[{pot.ToString()} ]  "; }

			}

			
			home += $"[ X ]  ";
			for(int i = 0; i < p1Pots.Length -2; i++)
			{ home += "       "; }
			home += $"[ X ]  ";

			foreach (int pot in p2Pots)
			{
				if (pot < 10)
				{
					p2 += $"[ {pot.ToString()} ]  ";
				}
				else { p2 += $"[{pot.ToString()} ]  "; }

			}

			Console.WriteLine("Mancala\n\r\n\r");
			Console.WriteLine(p1); 
			Console.WriteLine(home);
			Console.WriteLine(p2);

		}
	}
}
