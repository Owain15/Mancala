

using Mancala.Console._2.UI;

Console.CursorVisible = false;

Mancala.cl.Code.Table table = new Mancala.cl.Code.Table(8);

bool isRunning = true;

while (isRunning)
{
	// Turn set up
	table.SetPlayerIndex();

	//render display
	Mancala.Console._2.UI.Render.RenderTable(table);

	//get input
	Mancala.cl.UI.Command command = Mancala.Console._2.UI.Input.GetCommand();

	//update game state
	table.UpdateGameState(command);

	//evaluate gamestate

	isRunning = table.CheckForEndOfGame();

}


