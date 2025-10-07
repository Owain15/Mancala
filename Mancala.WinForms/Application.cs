


using Mancala.cl;

namespace Mancala.WinForms
{
	public partial class Application : Form
	{

		Mancala.cl.Game game;

		public Application()
		{
			InitializeComponent();

			game = new cl.Game();

			//game.Run();
		}

		private void Application_Shown(object sender, EventArgs e)
		{
			game.Run();
		}
	}
}
