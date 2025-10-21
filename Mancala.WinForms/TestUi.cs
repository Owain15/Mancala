using Mancala.WinForms.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala.WinForms
{
	public partial class TestUi : Form
	{
		int potCount = 6;

		List<Keys> validInputs = new List<Keys> 
		{ Keys.Enter , Keys.Left , Keys.Right , Keys.Escape };

		Label[] player1PotList;
		Label[] player2PotList;

		Label[] player1MoveList;
		Label[] player2MoveList;

		Mancala.cl.Game game;

		public TestUi()
		{
			InitializeComponent();

			player1PotList = new Label[]
			{
				player1Pot1,
				player1Pot2,
				player1Pot3,
				player1Pot4,
				player1Pot5,
				player1Pot6,
				player1PotHome
			};

			player2PotList = new Label[]
			{
				player2Pot1,
				player2Pot2,
				player2Pot3,
				player2Pot4,
				player2Pot5,
				player2Pot6,
				player2PotHome
			};

			player1MoveList = new Label[]
{
				player1MoveIndicatorPot1,
				player1MoveIndicatorPot2,
				player1MoveIndicatorPot3,
				player1MoveIndicatorPot4,
				player1MoveIndicatorPot5,
				player1MoveIndicatorPot6,
				player1MoveIndicatorPotHome
};

			player2MoveList = new Label[]
			{
				player2MoveIndicatorPot1,
				player2MoveIndicatorPot2,
				player2MoveIndicatorPot3,
				player2MoveIndicatorPot4,
				player2MoveIndicatorPot5,
				player2MoveIndicatorPot6,
				player2MoveIndicatorPotHome
			};

			game = new Mancala.cl.Game(potCount);

			RenderGameState();

		}

		private void RenderGameState()
		{
			//Render.GameState(this);

			RenderCurrentPlayerIndicator();
			RenderPlayerPots(1, player1PotList);
			RenderPlayerPots(2, player2PotList);
			RenderPlayerMoveIndicators(player1MoveList,player2MoveList);
		}

		private void RenderCurrentPlayerIndicator()
		{
			int currentPlayerIndex = game.GetCurrentPlayer();

			player1HedderIndicator.Text = (currentPlayerIndex == 0) ? "<-" : "> -";
			player2HedderIndicator.Text = (currentPlayerIndex == 1) ? "->" : "- <";

		}

		private void RenderPlayerPots(int inputPlayerIndex , Label[] inputUiPots)
		{
			bool isCurrentTurn = (game.GetCurrentPlayer() == (inputPlayerIndex -1));
			int playerIndex = game.GetIndex(inputPlayerIndex);
			int[] potValues = game.GetPots(inputPlayerIndex);
			int homeValue = game.GetHomeValue(inputPlayerIndex);
			Label[] uiPots = inputUiPots;
		

			for(int i = 0; i < potCount; i ++)
			{
				RenderPot(uiPots[i], potValues[i],i, playerIndex, isCurrentTurn);
			}

			RenderPot(uiPots[potCount], homeValue,-1, playerIndex, isCurrentTurn);

		}
		
		private void RenderPot(Label pot, int value,int potIndex, int playerIndex, bool isCurrentTurn)
		{
			pot.Text = value.ToString();

			pot.BackColor = (isCurrentTurn && potIndex == playerIndex) ? SystemColors.ActiveCaption : SystemColors.MenuHighlight;
		}

		private void RenderPlayerMoveIndicators(Label[] p1Labels , Label[]p2Labels)
		{

			(int[] p1 , int[] p2 ) moveData = game.GetMoveIndicatorValues();

			for( int i = 0; i < moveData.p1.Length; i ++)
			{
				p1Labels[i].Text = (moveData.p1[i] != -1) ? moveData.p1[i].ToString() : "X";
			}

			for (int i = 0; i < moveData.p2.Length; i++)
			{
				p2Labels[i].Text = (moveData.p2[i] != -1) ? moveData.p2[i].ToString() : "X";
			}

		}

	
		private void TestUi_KeyDown(object sender, KeyEventArgs e)
		{
			if(!validInputs.Contains(e.KeyCode) )
			{
				e.SuppressKeyPress = true;
				return;
			}

			Mancala.cl.UI.Command input = ConvertUiInputToUiCommand(e.KeyCode);

			//update game state
			game.UpdateGameState(input);

			// render new game state
			RenderGameState();

		}

		private Mancala.cl.UI.Command ConvertUiInputToUiCommand(Keys input)
		{
			return input switch
			{
				Keys.Left => cl.UI.Command.left,
				Keys.Right => cl.UI.Command.right,
				Keys.Enter => cl.UI.Command.enter,
				Keys.Escape => cl.UI.Command.escape,

				_ => cl.UI.Command.InvalidInput,
			};

			//return cl.UI.Command.InvalidInput;
		}

		

	}
}
