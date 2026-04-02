namespace TamagotchiApp
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			pictureBox1 = new PictureBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			label1 = new Label();
			pbHealth = new ProgressBar();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			pbMood = new ProgressBar();
			pbEnergy = new ProgressBar();
			pbDiscipline = new ProgressBar();
			pbHunger = new ProgressBar();
			panel1 = new Panel();
			lblNameAndAge = new Label();
			panel2 = new Panel();
			btnLearn = new Button();
			btnStroke = new Button();
			btnHeal = new Button();
			btnGiveTreat = new Button();
			btnPlay = new Button();
			btnWalk = new Button();
			btnFeed = new Button();
			rtbDialog = new RichTextBox();
			timer1 = new System.Windows.Forms.Timer(components);
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel3.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0624237F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9375763F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(panel2, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(801, 522);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(pictureBox1, 0, 1);
			tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
			tableLayoutPanel2.Controls.Add(panel1, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
			tableLayoutPanel2.Size = new Size(395, 516);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = SystemColors.Window;
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Location = new Point(3, 63);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(389, 290);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Controls.Add(label1, 0, 0);
			tableLayoutPanel3.Controls.Add(pbHealth, 1, 0);
			tableLayoutPanel3.Controls.Add(label2, 0, 1);
			tableLayoutPanel3.Controls.Add(label3, 0, 2);
			tableLayoutPanel3.Controls.Add(label4, 0, 3);
			tableLayoutPanel3.Controls.Add(label5, 0, 4);
			tableLayoutPanel3.Controls.Add(pbMood, 1, 2);
			tableLayoutPanel3.Controls.Add(pbEnergy, 1, 3);
			tableLayoutPanel3.Controls.Add(pbDiscipline, 1, 4);
			tableLayoutPanel3.Controls.Add(pbHunger, 1, 1);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 359);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 6;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.Size = new Size(389, 154);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(76, 20);
			label1.TabIndex = 0;
			label1.Text = "Здоровье";
			// 
			// pbHealth
			// 
			pbHealth.Dock = DockStyle.Fill;
			pbHealth.Location = new Point(113, 3);
			pbHealth.Name = "pbHealth";
			pbHealth.Size = new Size(273, 24);
			pbHealth.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 30);
			label2.Name = "label2";
			label2.Size = new Size(50, 20);
			label2.TabIndex = 2;
			label2.Text = "Голод";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 60);
			label3.Name = "label3";
			label3.Size = new Size(93, 20);
			label3.TabIndex = 3;
			label3.Text = "Настроение";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(3, 90);
			label4.Name = "label4";
			label4.Size = new Size(67, 20);
			label4.TabIndex = 4;
			label4.Text = "Энергия";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 120);
			label5.Name = "label5";
			label5.Size = new Size(96, 20);
			label5.TabIndex = 5;
			label5.Text = "Дисциплина";
			// 
			// pbMood
			// 
			pbMood.Dock = DockStyle.Fill;
			pbMood.Location = new Point(113, 63);
			pbMood.Name = "pbMood";
			pbMood.Size = new Size(273, 24);
			pbMood.TabIndex = 7;
			// 
			// pbEnergy
			// 
			pbEnergy.Dock = DockStyle.Fill;
			pbEnergy.Location = new Point(113, 93);
			pbEnergy.Name = "pbEnergy";
			pbEnergy.Size = new Size(273, 24);
			pbEnergy.TabIndex = 8;
			// 
			// pbDiscipline
			// 
			pbDiscipline.Dock = DockStyle.Fill;
			pbDiscipline.Location = new Point(113, 123);
			pbDiscipline.Name = "pbDiscipline";
			pbDiscipline.Size = new Size(273, 24);
			pbDiscipline.TabIndex = 9;
			// 
			// pbHunger
			// 
			pbHunger.Dock = DockStyle.Fill;
			pbHunger.Location = new Point(113, 33);
			pbHunger.Name = "pbHunger";
			pbHunger.Size = new Size(273, 24);
			pbHunger.TabIndex = 10;
			// 
			// panel1
			// 
			panel1.Controls.Add(lblNameAndAge);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(3, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(389, 54);
			panel1.TabIndex = 2;
			// 
			// lblNameAndAge
			// 
			lblNameAndAge.AutoSize = true;
			lblNameAndAge.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
			lblNameAndAge.Location = new Point(6, 3);
			lblNameAndAge.Name = "lblNameAndAge";
			lblNameAndAge.Size = new Size(252, 41);
			lblNameAndAge.TabIndex = 2;
			lblNameAndAge.Text = "lblNameAndAge";
			// 
			// panel2
			// 
			panel2.Controls.Add(btnLearn);
			panel2.Controls.Add(btnStroke);
			panel2.Controls.Add(btnHeal);
			panel2.Controls.Add(btnGiveTreat);
			panel2.Controls.Add(btnPlay);
			panel2.Controls.Add(btnWalk);
			panel2.Controls.Add(btnFeed);
			panel2.Controls.Add(rtbDialog);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(404, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(394, 516);
			panel2.TabIndex = 1;
			// 
			// btnLearn
			// 
			btnLearn.Location = new Point(3, 303);
			btnLearn.Name = "btnLearn";
			btnLearn.Size = new Size(382, 47);
			btnLearn.TabIndex = 1;
			btnLearn.Text = "Учить";
			btnLearn.UseVisualStyleBackColor = true;
			btnLearn.Click += BtnLearn_Click;
			// 
			// btnStroke
			// 
			btnStroke.Location = new Point(3, 253);
			btnStroke.Name = "btnStroke";
			btnStroke.Size = new Size(382, 47);
			btnStroke.TabIndex = 1;
			btnStroke.Text = "Погладить";
			btnStroke.UseVisualStyleBackColor = true;
			btnStroke.Click += BtnStroke_Click;
			// 
			// btnHeal
			// 
			btnHeal.Location = new Point(3, 203);
			btnHeal.Name = "btnHeal";
			btnHeal.Size = new Size(382, 47);
			btnHeal.TabIndex = 1;
			btnHeal.Text = "Лечить";
			btnHeal.UseVisualStyleBackColor = true;
			btnHeal.Click += BtnHeal_Click;
			// 
			// btnGiveTreat
			// 
			btnGiveTreat.Location = new Point(3, 153);
			btnGiveTreat.Name = "btnGiveTreat";
			btnGiveTreat.Size = new Size(382, 47);
			btnGiveTreat.TabIndex = 1;
			btnGiveTreat.Text = "Дать лакомство";
			btnGiveTreat.UseVisualStyleBackColor = true;
			btnGiveTreat.Click += BtnGiveTreat_Click;
			// 
			// btnPlay
			// 
			btnPlay.Location = new Point(3, 103);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(382, 47);
			btnPlay.TabIndex = 1;
			btnPlay.Text = "Играть";
			btnPlay.UseVisualStyleBackColor = true;
			btnPlay.Click += BtnPlay_Click;
			// 
			// btnWalk
			// 
			btnWalk.Location = new Point(3, 53);
			btnWalk.Name = "btnWalk";
			btnWalk.Size = new Size(382, 47);
			btnWalk.TabIndex = 1;
			btnWalk.Text = "Гулять";
			btnWalk.UseVisualStyleBackColor = true;
			btnWalk.Click += BtnWalk_Click;
			// 
			// btnFeed
			// 
			btnFeed.Location = new Point(3, 3);
			btnFeed.Name = "btnFeed";
			btnFeed.Size = new Size(382, 47);
			btnFeed.TabIndex = 1;
			btnFeed.Text = "Кормить";
			btnFeed.UseVisualStyleBackColor = true;
			btnFeed.Click += BtnFeed_Click;
			// 
			// rtbDialog
			// 
			rtbDialog.BackColor = SystemColors.Window;
			rtbDialog.Location = new Point(3, 359);
			rtbDialog.Name = "rtbDialog";
			rtbDialog.ReadOnly = true;
			rtbDialog.Size = new Size(382, 154);
			rtbDialog.TabIndex = 0;
			rtbDialog.Text = "";
			// 
			// timer1
			// 
			timer1.Tick += Timer1_Tick;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(801, 522);
			Controls.Add(tableLayoutPanel1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Тамагочи";
			FormClosed += MainForm_FormClosed;
			Load += MainForm_Load;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private PictureBox pictureBox1;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label1;
		private ProgressBar pbHealth;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private ProgressBar pbMood;
		private ProgressBar pbEnergy;
		private ProgressBar pbDiscipline;
		private Panel panel1;
		private Label lblNameAndAge;
		private System.Windows.Forms.Timer timer1;
		private ProgressBar pbHunger;
		private Panel panel2;
		private Button btnPlay;
		private Button btnWalk;
		private Button btnFeed;
		private RichTextBox rtbDialog;
		private Button btnLearn;
		private Button btnStroke;
		private Button btnHeal;
		private Button btnGiveTreat;
	}
}
