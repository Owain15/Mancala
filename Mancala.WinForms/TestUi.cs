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

			game = new Mancala.cl.Game(potCount);

			RenderGameState();

		}

		private void RenderGameState()
		{
			RenderCurrentPlayerIndicator();
			RenderPlayerPots(1, player1PotList);
			RenderPlayerPots(2, player2PotList);

		}

		private void RenderCurrentPlayerIndicator()
		{
			int currentPlayerIndex = game.GetCurrentPlayer();

			player1HedderIndicator.Text = (currentPlayerIndex == 0) ? "<-" : "";
			player2HedderIndicator.Text = (currentPlayerIndex == 1) ? "->" : "";

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
				RenderPot(uiPots[i], potValues[i], playerIndex, isCurrentTurn);
			}

			RenderPot(uiPots[potCount], homeValue, playerIndex, isCurrentTurn);

		}
		
		private void RenderPot(Label pot, int value, int playerIndex, bool isCurrentTurn)
		{
			pot.Text = value.ToString();
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
