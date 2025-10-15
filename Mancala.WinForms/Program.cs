namespace Mancala.WinForms
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			//System.Windows.Forms.Application.Run(new Application()); 
			System.Windows.Forms.Application.Run(new TestUi());
		}
	}
}