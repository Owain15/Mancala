using Mancala;
using Mancala.Code;

Console.CursorVisible = false;

Table table = new Table(8);

bool isRunning = true;

while(isRunning)
{
	// Turn set up
	table.SetPlayerIndex();

	//render display
	Console.Clear();
	//Mancala.UI.ConsoleApp.DevReadout(table);
	Mancala.UI.ConsoleApp.RenderGame(table);
	//Mancala.UI.ConsoleApp.PrintTable(table);
	//Mancala.UI.ConsoleApp.HighlghtPlayer(table);

	//get input
	//Mancala.UI.Input.GetCommand();

	//update game state
	table.UpdateGameState(Mancala.UI.Input.GetCommand());

	//evaluate gamestate

	isRunning = table.CheckForEndOfGame();

}
