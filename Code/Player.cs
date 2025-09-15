using Mancala.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala.Code
{
	internal class Player
	{
		int home;

		int[] pots;

		int index;

		public Player(int potCount)
		{
			home = 0;

			pots = InitializePots(potCount);

			index = 3;
		}

		private int[] InitializePots(int potCount)
		{
			if(potCount < 1) 
			{ potCount = 1; }

			int[] result = new int[potCount];

			for(int i = 0; i < result.Length; i ++)
			{ result[i] = 4; }

			return result;

		}

		public int GetHome()
		{ return home; }

		public int[] GetPots()
		{ return pots; }

		public int GetIndex()
		{ return index; }

		public void UpdateIndex(Input.Command input)
		{
			switch(input)
			{
				case Input.Command.left:
					{ index--; break; }

				case Input.Command.right:
					{ index++; break; }

				default: throw new Exception("Player Move Failed!");
			}

			ValidateIndex();
			
		}

		private void ValidateIndex()
		{

			if(index < 0 )
			{ index = pots.Length-1; }
			else if (index > pots.Length-1 )
			{ index = 0; }

		}

		public int GetandClearCurrentPot()
		{
			int result = pots[index];
			pots[index] = 0;

			return result;
		}

		public int UpdatePotValues(int index, int moveValue)
		{
			for(int i = index; i < pots.Length - 1; i ++ )
			{
				pots[i]++;
				moveValue--;
				if(moveValue < 1)
				{ break; }
			}

			if(moveValue > 0)
			{
				home++;
				moveValue--;
			}

			return moveValue;
		}
	}
}
