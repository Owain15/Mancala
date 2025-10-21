namespace Mancala.WinForms
{
	partial class TestUi
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			appTableLayout = new TableLayoutPanel();
			headderTableLayout = new TableLayoutPanel();
			player1HeadderLabel = new Label();
			player2HedderLabel = new Label();
			playerHedderIndicatorLabel = new Label();
			player1HedderIndicator = new Label();
			player2HedderIndicator = new Label();
			gameTableTableLayout = new TableLayoutPanel();
			player1TableLayout = new TableLayoutPanel();
			player1Pot6 = new Label();
			player1Pot5 = new Label();
			player1Pot4 = new Label();
			player1Pot3 = new Label();
			player1Pot2 = new Label();
			player1Pot1 = new Label();
			homeTableLayout = new TableLayoutPanel();
			player1PotHome = new Label();
			player2PotHome = new Label();
			player1MoveIndicatorPotHome = new Label();
			player2MoveIndicatorPotHome = new Label();
			gameResultLabel = new Label();
			player2TableLayout = new TableLayoutPanel();
			player2Pot1 = new Label();
			player2Pot2 = new Label();
			player2Pot3 = new Label();
			player2Pot4 = new Label();
			player2Pot5 = new Label();
			player2Pot6 = new Label();
			player1MoveIndicatorTableLayout = new TableLayoutPanel();
			player1MoveIndicatorPot6 = new Label();
			player1MoveIndicatorPot5 = new Label();
			player1MoveIndicatorPot4 = new Label();
			player1MoveIndicatorPot3 = new Label();
			player1MoveIndicatorPot2 = new Label();
			player1MoveIndicatorPot1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			player2MoveIndicatorPot1 = new Label();
			player2MoveIndicatorPot2 = new Label();
			player2MoveIndicatorPot3 = new Label();
			player2MoveIndicatorPot4 = new Label();
			player2MoveIndicatorPot5 = new Label();
			player2MoveIndicatorPot6 = new Label();
			appTableLayout.SuspendLayout();
			headderTableLayout.SuspendLayout();
			gameTableTableLayout.SuspendLayout();
			player1TableLayout.SuspendLayout();
			homeTableLayout.SuspendLayout();
			player2TableLayout.SuspendLayout();
			player1MoveIndicatorTableLayout.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// appTableLayout
			// 
			appTableLayout.BackColor = SystemColors.ActiveCaption;
			appTableLayout.ColumnCount = 3;
			appTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			appTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			appTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			appTableLayout.Controls.Add(headderTableLayout, 1, 2);
			appTableLayout.Controls.Add(gameTableTableLayout, 1, 3);
			appTableLayout.Dock = DockStyle.Fill;
			appTableLayout.Location = new Point(0, 0);
			appTableLayout.Name = "appTableLayout";
			appTableLayout.RowCount = 6;
			appTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			appTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			appTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			appTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
			appTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			appTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			appTableLayout.Size = new Size(916, 302);
			appTableLayout.TabIndex = 0;
			// 
			// headderTableLayout
			// 
			headderTableLayout.BackColor = SystemColors.Highlight;
			headderTableLayout.ColumnCount = 9;
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
			headderTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			headderTableLayout.Controls.Add(player1HeadderLabel, 1, 1);
			headderTableLayout.Controls.Add(player2HedderLabel, 7, 1);
			headderTableLayout.Controls.Add(playerHedderIndicatorLabel, 4, 1);
			headderTableLayout.Controls.Add(player1HedderIndicator, 3, 1);
			headderTableLayout.Controls.Add(player2HedderIndicator, 5, 1);
			headderTableLayout.Dock = DockStyle.Fill;
			headderTableLayout.Location = new Point(23, 4);
			headderTableLayout.Name = "headderTableLayout";
			headderTableLayout.RowCount = 3;
			headderTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			headderTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			headderTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
			headderTableLayout.Size = new Size(870, 44);
			headderTableLayout.TabIndex = 0;
			// 
			// player1HeadderLabel
			// 
			player1HeadderLabel.AutoSize = true;
			player1HeadderLabel.Dock = DockStyle.Fill;
			player1HeadderLabel.Location = new Point(125, 4);
			player1HeadderLabel.Name = "player1HeadderLabel";
			player1HeadderLabel.Size = new Size(194, 40);
			player1HeadderLabel.TabIndex = 0;
			player1HeadderLabel.Text = "Player 1";
			player1HeadderLabel.TextAlign = ContentAlignment.MiddleRight;
			// 
			// player2HedderLabel
			// 
			player2HedderLabel.AutoSize = true;
			player2HedderLabel.Dock = DockStyle.Fill;
			player2HedderLabel.Location = new Point(550, 4);
			player2HedderLabel.Name = "player2HedderLabel";
			player2HedderLabel.Size = new Size(194, 40);
			player2HedderLabel.TabIndex = 1;
			player2HedderLabel.Text = "Player 2";
			player2HedderLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// playerHedderIndicatorLabel
			// 
			playerHedderIndicatorLabel.AutoSize = true;
			playerHedderIndicatorLabel.Dock = DockStyle.Fill;
			playerHedderIndicatorLabel.Location = new Point(415, 4);
			playerHedderIndicatorLabel.Name = "playerHedderIndicatorLabel";
			playerHedderIndicatorLabel.Size = new Size(39, 40);
			playerHedderIndicatorLabel.TabIndex = 2;
			playerHedderIndicatorLabel.Text = "[⯀]";
			playerHedderIndicatorLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1HedderIndicator
			// 
			player1HedderIndicator.AutoSize = true;
			player1HedderIndicator.Dock = DockStyle.Fill;
			player1HedderIndicator.Location = new Point(375, 4);
			player1HedderIndicator.Name = "player1HedderIndicator";
			player1HedderIndicator.Size = new Size(34, 40);
			player1HedderIndicator.TabIndex = 3;
			player1HedderIndicator.Text = "<-";
			player1HedderIndicator.TextAlign = ContentAlignment.MiddleRight;
			// 
			// player2HedderIndicator
			// 
			player2HedderIndicator.AutoSize = true;
			player2HedderIndicator.Dock = DockStyle.Fill;
			player2HedderIndicator.Location = new Point(460, 4);
			player2HedderIndicator.Name = "player2HedderIndicator";
			player2HedderIndicator.Size = new Size(34, 40);
			player2HedderIndicator.TabIndex = 4;
			player2HedderIndicator.Text = "->";
			player2HedderIndicator.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// gameTableTableLayout
			// 
			gameTableTableLayout.BackColor = SystemColors.Highlight;
			gameTableTableLayout.ColumnCount = 1;
			gameTableTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			gameTableTableLayout.Controls.Add(player1TableLayout, 0, 1);
			gameTableTableLayout.Controls.Add(homeTableLayout, 0, 3);
			gameTableTableLayout.Controls.Add(player2TableLayout, 0, 5);
			gameTableTableLayout.Controls.Add(player1MoveIndicatorTableLayout, 0, 2);
			gameTableTableLayout.Controls.Add(tableLayoutPanel1, 0, 4);
			gameTableTableLayout.Dock = DockStyle.Fill;
			gameTableTableLayout.Location = new Point(23, 54);
			gameTableTableLayout.Name = "gameTableTableLayout";
			gameTableTableLayout.RowCount = 7;
			gameTableTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			gameTableTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			gameTableTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			gameTableTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			gameTableTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			gameTableTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			gameTableTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			gameTableTableLayout.Size = new Size(870, 244);
			gameTableTableLayout.TabIndex = 1;
			// 
			// player1TableLayout
			// 
			player1TableLayout.ColumnCount = 13;
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			player1TableLayout.Controls.Add(player1Pot6, 1, 0);
			player1TableLayout.Controls.Add(player1Pot5, 3, 0);
			player1TableLayout.Controls.Add(player1Pot4, 5, 0);
			player1TableLayout.Controls.Add(player1Pot3, 7, 0);
			player1TableLayout.Controls.Add(player1Pot2, 9, 0);
			player1TableLayout.Controls.Add(player1Pot1, 11, 0);
			player1TableLayout.Dock = DockStyle.Fill;
			player1TableLayout.Location = new Point(3, 23);
			player1TableLayout.Name = "player1TableLayout";
			player1TableLayout.RowCount = 1;
			player1TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			player1TableLayout.Size = new Size(864, 44);
			player1TableLayout.TabIndex = 0;
			// 
			// player1Pot6
			// 
			player1Pot6.AutoSize = true;
			player1Pot6.BackColor = SystemColors.ActiveCaption;
			player1Pot6.Dock = DockStyle.Fill;
			player1Pot6.Location = new Point(57, 0);
			player1Pot6.Name = "player1Pot6";
			player1Pot6.Size = new Size(74, 44);
			player1Pot6.TabIndex = 0;
			player1Pot6.Text = "XXX";
			player1Pot6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1Pot5
			// 
			player1Pot5.AutoSize = true;
			player1Pot5.BackColor = SystemColors.ActiveCaption;
			player1Pot5.Dock = DockStyle.Fill;
			player1Pot5.Location = new Point(191, 0);
			player1Pot5.Name = "player1Pot5";
			player1Pot5.Size = new Size(74, 44);
			player1Pot5.TabIndex = 1;
			player1Pot5.Text = "XXX";
			player1Pot5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1Pot4
			// 
			player1Pot4.AutoSize = true;
			player1Pot4.BackColor = SystemColors.ActiveCaption;
			player1Pot4.Dock = DockStyle.Fill;
			player1Pot4.Location = new Point(325, 0);
			player1Pot4.Name = "player1Pot4";
			player1Pot4.Size = new Size(74, 44);
			player1Pot4.TabIndex = 2;
			player1Pot4.Text = "XXX";
			player1Pot4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1Pot3
			// 
			player1Pot3.AutoSize = true;
			player1Pot3.BackColor = SystemColors.ActiveCaption;
			player1Pot3.Dock = DockStyle.Fill;
			player1Pot3.Location = new Point(459, 0);
			player1Pot3.Name = "player1Pot3";
			player1Pot3.Size = new Size(74, 44);
			player1Pot3.TabIndex = 3;
			player1Pot3.Text = "XXX";
			player1Pot3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1Pot2
			// 
			player1Pot2.AutoSize = true;
			player1Pot2.BackColor = SystemColors.ActiveCaption;
			player1Pot2.Dock = DockStyle.Fill;
			player1Pot2.Location = new Point(593, 0);
			player1Pot2.Name = "player1Pot2";
			player1Pot2.Size = new Size(74, 44);
			player1Pot2.TabIndex = 4;
			player1Pot2.Text = "XXX";
			player1Pot2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1Pot1
			// 
			player1Pot1.AutoSize = true;
			player1Pot1.BackColor = SystemColors.ActiveCaption;
			player1Pot1.Dock = DockStyle.Fill;
			player1Pot1.Location = new Point(727, 0);
			player1Pot1.Name = "player1Pot1";
			player1Pot1.Size = new Size(74, 44);
			player1Pot1.TabIndex = 5;
			player1Pot1.Text = "XXX";
			player1Pot1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// homeTableLayout
			// 
			homeTableLayout.ColumnCount = 9;
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			homeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
			homeTableLayout.Controls.Add(player1PotHome, 1, 1);
			homeTableLayout.Controls.Add(player2PotHome, 7, 1);
			homeTableLayout.Controls.Add(player1MoveIndicatorPotHome, 2, 1);
			homeTableLayout.Controls.Add(player2MoveIndicatorPotHome, 6, 1);
			homeTableLayout.Controls.Add(gameResultLabel, 4, 1);
			homeTableLayout.Dock = DockStyle.Fill;
			homeTableLayout.Location = new Point(3, 103);
			homeTableLayout.Name = "homeTableLayout";
			homeTableLayout.RowCount = 3;
			homeTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			homeTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			homeTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			homeTableLayout.Size = new Size(864, 44);
			homeTableLayout.TabIndex = 1;
			// 
			// player1PotHome
			// 
			player1PotHome.AutoSize = true;
			player1PotHome.BackColor = SystemColors.ActiveCaption;
			player1PotHome.Dock = DockStyle.Fill;
			player1PotHome.Location = new Point(3, 2);
			player1PotHome.Name = "player1PotHome";
			player1PotHome.Size = new Size(74, 40);
			player1PotHome.TabIndex = 0;
			player1PotHome.Text = "XXX";
			player1PotHome.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2PotHome
			// 
			player2PotHome.AutoSize = true;
			player2PotHome.BackColor = SystemColors.ActiveCaption;
			player2PotHome.Dock = DockStyle.Fill;
			player2PotHome.Location = new Point(787, 2);
			player2PotHome.Name = "player2PotHome";
			player2PotHome.Size = new Size(74, 40);
			player2PotHome.TabIndex = 1;
			player2PotHome.Text = "XXX";
			player2PotHome.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1MoveIndicatorPotHome
			// 
			player1MoveIndicatorPotHome.AutoSize = true;
			player1MoveIndicatorPotHome.Dock = DockStyle.Fill;
			player1MoveIndicatorPotHome.Location = new Point(83, 2);
			player1MoveIndicatorPotHome.Name = "player1MoveIndicatorPotHome";
			player1MoveIndicatorPotHome.Size = new Size(24, 40);
			player1MoveIndicatorPotHome.TabIndex = 2;
			player1MoveIndicatorPotHome.Text = ".";
			player1MoveIndicatorPotHome.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2MoveIndicatorPotHome
			// 
			player2MoveIndicatorPotHome.AutoSize = true;
			player2MoveIndicatorPotHome.Dock = DockStyle.Fill;
			player2MoveIndicatorPotHome.Location = new Point(757, 2);
			player2MoveIndicatorPotHome.Name = "player2MoveIndicatorPotHome";
			player2MoveIndicatorPotHome.Size = new Size(24, 40);
			player2MoveIndicatorPotHome.TabIndex = 3;
			player2MoveIndicatorPotHome.Text = ".";
			player2MoveIndicatorPotHome.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// gameResultLabel
			// 
			gameResultLabel.AutoSize = true;
			gameResultLabel.Dock = DockStyle.Fill;
			gameResultLabel.Location = new Point(350, 2);
			gameResultLabel.Name = "gameResultLabel";
			gameResultLabel.Size = new Size(164, 40);
			gameResultLabel.TabIndex = 4;
			gameResultLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2TableLayout
			// 
			player2TableLayout.ColumnCount = 13;
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player2TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player2TableLayout.Controls.Add(player2Pot1, 1, 1);
			player2TableLayout.Controls.Add(player2Pot2, 3, 1);
			player2TableLayout.Controls.Add(player2Pot3, 5, 1);
			player2TableLayout.Controls.Add(player2Pot4, 7, 1);
			player2TableLayout.Controls.Add(player2Pot5, 9, 1);
			player2TableLayout.Controls.Add(player2Pot6, 11, 1);
			player2TableLayout.Dock = DockStyle.Fill;
			player2TableLayout.Location = new Point(3, 183);
			player2TableLayout.Name = "player2TableLayout";
			player2TableLayout.RowCount = 3;
			player2TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			player2TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			player2TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			player2TableLayout.Size = new Size(864, 44);
			player2TableLayout.TabIndex = 2;
			// 
			// player2Pot1
			// 
			player2Pot1.AutoSize = true;
			player2Pot1.BackColor = SystemColors.ActiveCaption;
			player2Pot1.Dock = DockStyle.Fill;
			player2Pot1.Location = new Point(57, 2);
			player2Pot1.Name = "player2Pot1";
			player2Pot1.Size = new Size(74, 40);
			player2Pot1.TabIndex = 0;
			player2Pot1.Text = "XXX";
			player2Pot1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2Pot2
			// 
			player2Pot2.AutoSize = true;
			player2Pot2.BackColor = SystemColors.ActiveCaption;
			player2Pot2.Dock = DockStyle.Fill;
			player2Pot2.Location = new Point(191, 2);
			player2Pot2.Name = "player2Pot2";
			player2Pot2.Size = new Size(74, 40);
			player2Pot2.TabIndex = 1;
			player2Pot2.Text = "XXX";
			player2Pot2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2Pot3
			// 
			player2Pot3.AutoSize = true;
			player2Pot3.BackColor = SystemColors.ActiveCaption;
			player2Pot3.Dock = DockStyle.Fill;
			player2Pot3.Location = new Point(325, 2);
			player2Pot3.Name = "player2Pot3";
			player2Pot3.Size = new Size(74, 40);
			player2Pot3.TabIndex = 2;
			player2Pot3.Text = "XXX";
			player2Pot3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2Pot4
			// 
			player2Pot4.AutoSize = true;
			player2Pot4.BackColor = SystemColors.ActiveCaption;
			player2Pot4.Dock = DockStyle.Fill;
			player2Pot4.Location = new Point(459, 2);
			player2Pot4.Name = "player2Pot4";
			player2Pot4.Size = new Size(74, 40);
			player2Pot4.TabIndex = 3;
			player2Pot4.Text = "XXX";
			player2Pot4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2Pot5
			// 
			player2Pot5.AutoSize = true;
			player2Pot5.BackColor = SystemColors.ActiveCaption;
			player2Pot5.Dock = DockStyle.Fill;
			player2Pot5.Location = new Point(593, 2);
			player2Pot5.Name = "player2Pot5";
			player2Pot5.Size = new Size(74, 40);
			player2Pot5.TabIndex = 4;
			player2Pot5.Text = "XXX";
			player2Pot5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2Pot6
			// 
			player2Pot6.AutoSize = true;
			player2Pot6.BackColor = SystemColors.ActiveCaption;
			player2Pot6.Dock = DockStyle.Fill;
			player2Pot6.Location = new Point(727, 2);
			player2Pot6.Name = "player2Pot6";
			player2Pot6.Size = new Size(74, 40);
			player2Pot6.TabIndex = 5;
			player2Pot6.Text = "XXX";
			player2Pot6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1MoveIndicatorTableLayout
			// 
			player1MoveIndicatorTableLayout.ColumnCount = 13;
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			player1MoveIndicatorTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
			player1MoveIndicatorTableLayout.Controls.Add(player1MoveIndicatorPot6, 1, 1);
			player1MoveIndicatorTableLayout.Controls.Add(player1MoveIndicatorPot5, 3, 1);
			player1MoveIndicatorTableLayout.Controls.Add(player1MoveIndicatorPot4, 5, 1);
			player1MoveIndicatorTableLayout.Controls.Add(player1MoveIndicatorPot3, 7, 1);
			player1MoveIndicatorTableLayout.Controls.Add(player1MoveIndicatorPot2, 9, 1);
			player1MoveIndicatorTableLayout.Controls.Add(player1MoveIndicatorPot1, 11, 1);
			player1MoveIndicatorTableLayout.Dock = DockStyle.Fill;
			player1MoveIndicatorTableLayout.Location = new Point(3, 73);
			player1MoveIndicatorTableLayout.Name = "player1MoveIndicatorTableLayout";
			player1MoveIndicatorTableLayout.RowCount = 3;
			player1MoveIndicatorTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			player1MoveIndicatorTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
			player1MoveIndicatorTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			player1MoveIndicatorTableLayout.Size = new Size(864, 24);
			player1MoveIndicatorTableLayout.TabIndex = 3;
			// 
			// player1MoveIndicatorPot6
			// 
			player1MoveIndicatorPot6.AutoSize = true;
			player1MoveIndicatorPot6.Dock = DockStyle.Fill;
			player1MoveIndicatorPot6.Location = new Point(57, 0);
			player1MoveIndicatorPot6.Name = "player1MoveIndicatorPot6";
			player1MoveIndicatorPot6.Size = new Size(74, 25);
			player1MoveIndicatorPot6.TabIndex = 0;
			player1MoveIndicatorPot6.Text = ".";
			player1MoveIndicatorPot6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1MoveIndicatorPot5
			// 
			player1MoveIndicatorPot5.AutoSize = true;
			player1MoveIndicatorPot5.Dock = DockStyle.Fill;
			player1MoveIndicatorPot5.Location = new Point(191, 0);
			player1MoveIndicatorPot5.Name = "player1MoveIndicatorPot5";
			player1MoveIndicatorPot5.Size = new Size(74, 25);
			player1MoveIndicatorPot5.TabIndex = 1;
			player1MoveIndicatorPot5.Text = ".";
			player1MoveIndicatorPot5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1MoveIndicatorPot4
			// 
			player1MoveIndicatorPot4.AutoSize = true;
			player1MoveIndicatorPot4.Dock = DockStyle.Fill;
			player1MoveIndicatorPot4.Location = new Point(325, 0);
			player1MoveIndicatorPot4.Name = "player1MoveIndicatorPot4";
			player1MoveIndicatorPot4.Size = new Size(74, 25);
			player1MoveIndicatorPot4.TabIndex = 2;
			player1MoveIndicatorPot4.Text = ".";
			player1MoveIndicatorPot4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1MoveIndicatorPot3
			// 
			player1MoveIndicatorPot3.AutoSize = true;
			player1MoveIndicatorPot3.Dock = DockStyle.Fill;
			player1MoveIndicatorPot3.Location = new Point(459, 0);
			player1MoveIndicatorPot3.Name = "player1MoveIndicatorPot3";
			player1MoveIndicatorPot3.Size = new Size(74, 25);
			player1MoveIndicatorPot3.TabIndex = 3;
			player1MoveIndicatorPot3.Text = ".";
			player1MoveIndicatorPot3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1MoveIndicatorPot2
			// 
			player1MoveIndicatorPot2.AutoSize = true;
			player1MoveIndicatorPot2.Dock = DockStyle.Fill;
			player1MoveIndicatorPot2.Location = new Point(593, 0);
			player1MoveIndicatorPot2.Name = "player1MoveIndicatorPot2";
			player1MoveIndicatorPot2.Size = new Size(74, 25);
			player1MoveIndicatorPot2.TabIndex = 4;
			player1MoveIndicatorPot2.Text = ".";
			player1MoveIndicatorPot2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player1MoveIndicatorPot1
			// 
			player1MoveIndicatorPot1.AutoSize = true;
			player1MoveIndicatorPot1.Dock = DockStyle.Fill;
			player1MoveIndicatorPot1.Location = new Point(727, 0);
			player1MoveIndicatorPot1.Name = "player1MoveIndicatorPot1";
			player1MoveIndicatorPot1.Size = new Size(74, 25);
			player1MoveIndicatorPot1.TabIndex = 5;
			player1MoveIndicatorPot1.Text = ".";
			player1MoveIndicatorPot1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 13;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.Controls.Add(player2MoveIndicatorPot1, 1, 1);
			tableLayoutPanel1.Controls.Add(player2MoveIndicatorPot2, 3, 1);
			tableLayoutPanel1.Controls.Add(player2MoveIndicatorPot3, 5, 1);
			tableLayoutPanel1.Controls.Add(player2MoveIndicatorPot4, 7, 1);
			tableLayoutPanel1.Controls.Add(player2MoveIndicatorPot5, 9, 1);
			tableLayoutPanel1.Controls.Add(player2MoveIndicatorPot6, 11, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 153);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(864, 24);
			tableLayoutPanel1.TabIndex = 4;
			// 
			// player2MoveIndicatorPot1
			// 
			player2MoveIndicatorPot1.AutoSize = true;
			player2MoveIndicatorPot1.Dock = DockStyle.Fill;
			player2MoveIndicatorPot1.Location = new Point(57, 0);
			player2MoveIndicatorPot1.Name = "player2MoveIndicatorPot1";
			player2MoveIndicatorPot1.Size = new Size(74, 25);
			player2MoveIndicatorPot1.TabIndex = 0;
			player2MoveIndicatorPot1.Text = ".";
			player2MoveIndicatorPot1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2MoveIndicatorPot2
			// 
			player2MoveIndicatorPot2.AutoSize = true;
			player2MoveIndicatorPot2.Dock = DockStyle.Fill;
			player2MoveIndicatorPot2.Location = new Point(191, 0);
			player2MoveIndicatorPot2.Name = "player2MoveIndicatorPot2";
			player2MoveIndicatorPot2.Size = new Size(74, 25);
			player2MoveIndicatorPot2.TabIndex = 1;
			player2MoveIndicatorPot2.Text = ".";
			player2MoveIndicatorPot2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2MoveIndicatorPot3
			// 
			player2MoveIndicatorPot3.AutoSize = true;
			player2MoveIndicatorPot3.Dock = DockStyle.Fill;
			player2MoveIndicatorPot3.Location = new Point(325, 0);
			player2MoveIndicatorPot3.Name = "player2MoveIndicatorPot3";
			player2MoveIndicatorPot3.Size = new Size(74, 25);
			player2MoveIndicatorPot3.TabIndex = 2;
			player2MoveIndicatorPot3.Text = ".";
			player2MoveIndicatorPot3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2MoveIndicatorPot4
			// 
			player2MoveIndicatorPot4.AutoSize = true;
			player2MoveIndicatorPot4.Dock = DockStyle.Fill;
			player2MoveIndicatorPot4.Location = new Point(459, 0);
			player2MoveIndicatorPot4.Name = "player2MoveIndicatorPot4";
			player2MoveIndicatorPot4.Size = new Size(74, 25);
			player2MoveIndicatorPot4.TabIndex = 3;
			player2MoveIndicatorPot4.Text = ".";
			player2MoveIndicatorPot4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2MoveIndicatorPot5
			// 
			player2MoveIndicatorPot5.AutoSize = true;
			player2MoveIndicatorPot5.Dock = DockStyle.Fill;
			player2MoveIndicatorPot5.Location = new Point(593, 0);
			player2MoveIndicatorPot5.Name = "player2MoveIndicatorPot5";
			player2MoveIndicatorPot5.Size = new Size(74, 25);
			player2MoveIndicatorPot5.TabIndex = 4;
			player2MoveIndicatorPot5.Text = ".";
			player2MoveIndicatorPot5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// player2MoveIndicatorPot6
			// 
			player2MoveIndicatorPot6.AutoSize = true;
			player2MoveIndicatorPot6.Dock = DockStyle.Fill;
			player2MoveIndicatorPot6.Location = new Point(727, 0);
			player2MoveIndicatorPot6.Name = "player2MoveIndicatorPot6";
			player2MoveIndicatorPot6.Size = new Size(74, 25);
			player2MoveIndicatorPot6.TabIndex = 5;
			player2MoveIndicatorPot6.Text = ".";
			player2MoveIndicatorPot6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// TestUi
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(916, 302);
			Controls.Add(appTableLayout);
			MinimumSize = new Size(938, 358);
			Name = "TestUi";
			Text = "Mancala-TestUi";
			KeyDown += TestUi_KeyDown;
			appTableLayout.ResumeLayout(false);
			headderTableLayout.ResumeLayout(false);
			headderTableLayout.PerformLayout();
			gameTableTableLayout.ResumeLayout(false);
			player1TableLayout.ResumeLayout(false);
			player1TableLayout.PerformLayout();
			homeTableLayout.ResumeLayout(false);
			homeTableLayout.PerformLayout();
			player2TableLayout.ResumeLayout(false);
			player2TableLayout.PerformLayout();
			player1MoveIndicatorTableLayout.ResumeLayout(false);
			player1MoveIndicatorTableLayout.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel appTableLayout;
		private TableLayoutPanel headderTableLayout;
		private TableLayoutPanel gameTableTableLayout;
		private TableLayoutPanel player1TableLayout;
		private TableLayoutPanel homeTableLayout;
		private TableLayoutPanel player2TableLayout;
		private Label player1Pot6;
		private Label player1Pot5;
		private Label player1Pot4;
		private Label player1Pot3;
		private Label player1Pot2;
		private Label player1Pot1;
		private Label player1HeadderLabel;
		private Label player2HedderLabel;
		private Label playerHedderIndicatorLabel;
		private Label player1HedderIndicator;
		private Label player2HedderIndicator;
		private Label player1PotHome;
		private Label player2PotHome;
		private Label player2Pot1;
		private Label player2Pot2;
		private Label player2Pot3;
		private Label player2Pot4;
		private Label player2Pot5;
		private Label player2Pot6;
		private TableLayoutPanel player1MoveIndicatorTableLayout;
		private Label player1MoveIndicatorPot6;
		private Label player1MoveIndicatorPot5;
		private Label player1MoveIndicatorPot4;
		private Label player1MoveIndicatorPot3;
		private Label player1MoveIndicatorPot2;
		private Label player1MoveIndicatorPotHome;
		private Label player2MoveIndicatorPotHome;
		private Label player1MoveIndicatorPot1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label player2MoveIndicatorPot1;
		private Label player2MoveIndicatorPot2;
		private Label player2MoveIndicatorPot3;
		private Label player2MoveIndicatorPot4;
		private Label player2MoveIndicatorPot5;
		private Label player2MoveIndicatorPot6;
		private Label gameResultLabel;
	}
}