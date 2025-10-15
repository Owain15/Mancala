namespace Mancala.WinForms
{
	partial class Pot
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			layout = new TableLayoutPanel();
			pictureBox = new PictureBox();
			prompt = new Label();
			layout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			SuspendLayout();
			// 
			// layout
			// 
			layout.ColumnCount = 3;
			layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			layout.Controls.Add(pictureBox, 1, 1);
			layout.Controls.Add(prompt, 1, 2);
			layout.Dock = DockStyle.Fill;
			layout.Location = new Point(0, 0);
			layout.Name = "layout";
			layout.RowCount = 4;
			layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			layout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			layout.Size = new Size(150, 150);
			layout.TabIndex = 0;
			// 
			// pictureBox
			// 
			pictureBox.Dock = DockStyle.Fill;
			pictureBox.Location = new Point(33, 33);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(84, 54);
			pictureBox.TabIndex = 0;
			pictureBox.TabStop = false;
			// 
			// prompt
			// 
			prompt.AutoSize = true;
			prompt.Dock = DockStyle.Fill;
			prompt.Location = new Point(33, 90);
			prompt.Name = "prompt";
			prompt.Size = new Size(84, 30);
			prompt.TabIndex = 1;
			prompt.Text = "xxx";
			prompt.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Pot
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(layout);
			Name = "Pot";
			layout.ResumeLayout(false);
			layout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel layout;
		private PictureBox pictureBox;
		private Label prompt;
	}
}
