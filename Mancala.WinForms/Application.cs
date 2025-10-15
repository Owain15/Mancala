

using Mancala.cl;
using Mancala.cl.Code;

namespace Mancala.WinForms
{

	

	public partial class Application : Form
	{
		float padding = 20;

		Mancala.cl.Game game;

		public Application()
		{
			InitializeComponent();

			game = new cl.Game();

			InitializeTable();

			//game.Run();
		}

#region Events
	private void Application_Shown(object sender, EventArgs e)
	{
		//game.Run();
	}

	private void Application_KeyDown(object sender, KeyEventArgs e)
	{

	}

#endregion

#region Methods

		private void InitializeTable()
		{
			TableLayoutPanel applicationPadding = new TableLayoutPanel();

			PictureBox paddingTest = new PictureBox();

			TableLayoutPanel tableBorder = new TableLayoutPanel();

			PictureBox tableBorderTest = new PictureBox();

			// tableBorder
			// 
			tableBorder.ColumnCount = 3;
			tableBorder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableBorder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableBorder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableBorder.Controls.Add(tableBorderTest, 1, 1);
			tableBorder.Dock = DockStyle.Fill;
			tableBorder.BackColor = SystemColors.ActiveCaption;
			tableBorder.Location = new Point(0, 0);
			tableBorder.Name = "tableBorder";
			tableBorder.RowCount = 3;
			tableBorder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableBorder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableBorder.Size = new Size(800, 450);
			tableBorder.TabIndex = 0;
			// 

			// tableBorderTest
			// 
			tableBorderTest.BackColor = SystemColors.ControlDarkDark;
			tableBorderTest.Dock = DockStyle.Fill;
			tableBorderTest.Location = new Point(23, 23);
			tableBorderTest.Name = "tableBorderTest";
			tableBorderTest.Size = new Size(754, 404);
			tableBorderTest.TabIndex = 0;
			tableBorderTest.TabStop = false;
			// 

			// applicationPadding
			// 
			applicationPadding.ColumnCount = 3;
			applicationPadding.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			applicationPadding.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			applicationPadding.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			applicationPadding.Controls.Add(tableBorder, 1, 1);
			applicationPadding.Dock = DockStyle.Fill;
			//applicationPadding.BackColor = SystemColors.ActiveCaption;
			applicationPadding.Location = new Point(0, 0);
			applicationPadding.Name = "applicationPadding";
			applicationPadding.RowCount = 3;
			applicationPadding.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			applicationPadding.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			applicationPadding.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			applicationPadding.Size = new Size(800, 450);
			applicationPadding.TabIndex = 0;
			// 

			// paddingTest
			// 
			paddingTest.BackColor = SystemColors.ActiveCaption;
			paddingTest.Dock = DockStyle.Fill;
			paddingTest.Location = new Point(23, 23);
			paddingTest.Name = "paddingTest";
			paddingTest.Size = new Size(754, 404);
			paddingTest.TabIndex = 0;
			paddingTest.TabStop = false;
			// 

			Controls.Add(applicationPadding);
		}

		////private void InitializeComponent()
		////{
		////	tableLayoutPanel1 = new TableLayoutPanel();
		////	pictureBox1 = new PictureBox();
		////	tableLayoutPanel1.SuspendLayout();
		////	((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		////	SuspendLayout();
		////	// 
		////	// tableLayoutPanel1
		////	// 
		////	tableLayoutPanel1.ColumnCount = 3;
		////	tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
		////	tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
		////	tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
		////	tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
		////	tableLayoutPanel1.Dock = DockStyle.Fill;
		////	tableLayoutPanel1.Location = new Point(0, 0);
		////	tableLayoutPanel1.Name = "tableLayoutPanel1";
		////	tableLayoutPanel1.RowCount = 3;
		////	tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
		////	tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
		////	tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
		////	tableLayoutPanel1.Size = new Size(800, 450);
		////	tableLayoutPanel1.TabIndex = 0;
		////	// 
		////	// pictureBox1
		////	// 
		////	pictureBox1.BackColor = SystemColors.ActiveCaption;
		////	pictureBox1.Dock = DockStyle.Fill;
		////	pictureBox1.Location = new Point(23, 23);
		////	pictureBox1.Name = "pictureBox1";
		////	pictureBox1.Size = new Size(754, 404);
		////	pictureBox1.TabIndex = 0;
		////	pictureBox1.TabStop = false;
		////	// 
		////	// Application
		////	// 
		////	AutoScaleDimensions = new SizeF(10F, 25F);
		////	AutoScaleMode = AutoScaleMode.Font;
		////	ClientSize = new Size(800, 450);
		////	Controls.Add(tableLayoutPanel1);
		////	Name = "Application";
		////	Text = "Mancala";
		////	Shown += Application_Shown;
		////	KeyDown += Application_KeyDown;
		////	tableLayoutPanel1.ResumeLayout(false);
		////	((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		////	ResumeLayout(false);
		////}

		////#endregion

		////private TableLayoutPanel tableLayoutPanel1;
		////private PictureBox pictureBox1;


#endregion

	}
}
