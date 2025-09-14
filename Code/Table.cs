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

		(int[] p1 , int[] p2)pots;
		
		(int p1, int p2) homes;

		//int p1Home;
		//int p2Home;

		public Table(int potCount)
		{
			pots.p1 = new int[potCount];
			pots.p2 = new int[potCount];

			homes.p1 = 0;
			homes.p2 = 0;

			//p1Home = 0;
			//p2Home = 0;
		}

		public int[] GetP1Pots()
		{ return pots.p1; }

		public int[]GetP2Pots()
		{ return pots.p2; }

		public (int[]p1 , int[]p2) GetPots()
		{ return pots; }

		public int GetP1Home()
		{ return homes.p1; }

		public int GetP2Home()
		{ return homes.p2; }

		public (int P1, int P2) GetHomes()
		{ return homes; }


	}
}
