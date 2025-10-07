
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

		public void AddToHome(int value)
		{ home += value; }

		public int GetHome()
		{ return home; }

		public int GetPot(int Index)
		{	
			if(Index < 0 || Index > pots.Length)
			{ throw new Exception("Pot data not found. Invalid index!"); }
			
			return pots[Index];
		}

		public int GetPot()
		{
			if (index < 0 || index > pots.Length)
			{ throw new Exception("Pot data not found. Invalid index!"); }

			return pots[index];
		}

		public int[] GetPots()
		{ return pots; }

		public int GetIndex()
		{ return index; }

		public void UpdateIndex(Mancala.cl.UI.Command input)
		{
			// check input is valid
			if( input != Mancala.cl.UI.Command.left && input != Mancala.cl.UI.Command.right )
			{ throw new Exception("Invalid player input!"); }

			//set increment value
			int increment = -1;
			if(input == Mancala.cl.UI.Command.right)
			{ increment = 1; }

			for(int i = 0; i < pots.Length; i++)
			{
				index += increment;
				ValidateIndex();
				if (pots[index] != 0)
				{ return; }
			}

			throw new Exception("No valid move found!");
			


			//switch(input)
			//{
			//	case Input.Command.left:
			//		{ index--; break; }

			//	case Input.Command.right:
			//		{ index++; break; }

			//	default: throw new Exception("Player Move Failed!");
			//}

			//ValidateIndex();

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

		public int GetandClearPot(int  Index)
		{
			int result = pots[Index];
			pots[Index] = 0;

			return result;
		}

		public (int moveValue , int index) UpdatePotValues(int index, int moveValue, bool isCurrentPlayersTurn)
		{
			int c_index = index;

			for(c_index = index; c_index < pots.Length; c_index++ )
			{
				pots[c_index]++;
				moveValue--;
				if(moveValue < 1)
				{ break; }
			}

			if(moveValue > 0 && isCurrentPlayersTurn)
			{
				home++;
				moveValue--;
			}

			return (moveValue , c_index);
		}

		public bool CanMakeMove()
		{
			return !(pots.All(i => i == 0));
		}
	}
}
