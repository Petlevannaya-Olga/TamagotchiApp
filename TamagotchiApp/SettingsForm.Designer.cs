namespace TamagotchiApp
{
	partial class SettingsForm
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
			label1 = new Label();
			txtName = new TextBox();
			cbType = new ComboBox();
			label2 = new Label();
			btnStart = new Button();
			btnBack = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(104, 20);
			label1.TabIndex = 0;
			label1.Text = "Имя питомца";
			// 
			// txtName
			// 
			txtName.Location = new Point(12, 32);
			txtName.Multiline = true;
			txtName.Name = "txtName";
			txtName.Size = new Size(346, 28);
			txtName.TabIndex = 1;
			// 
			// cbType
			// 
			cbType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbType.FormattingEnabled = true;
			cbType.Items.AddRange(new object[] { "Кошка ", "Собака" });
			cbType.Location = new Point(12, 86);
			cbType.Name = "cbType";
			cbType.Size = new Size(346, 28);
			cbType.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 63);
			label2.Name = "label2";
			label2.Size = new Size(100, 20);
			label2.TabIndex = 3;
			label2.Text = "Вид питомца";
			// 
			// btnStart
			// 
			btnStart.Location = new Point(12, 132);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(346, 41);
			btnStart.TabIndex = 4;
			btnStart.Text = "Начать игру";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += BtnStart_Click;
			// 
			// btnBack
			// 
			btnBack.Location = new Point(12, 179);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(346, 41);
			btnBack.TabIndex = 4;
			btnBack.Text = "Вернуться назад";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += BtnBack_Click;
			// 
			// SettingsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(370, 236);
			Controls.Add(btnBack);
			Controls.Add(btnStart);
			Controls.Add(label2);
			Controls.Add(cbType);
			Controls.Add(txtName);
			Controls.Add(label1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SettingsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Настройка игры";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtName;
		private ComboBox cbType;
		private Label label2;
		private Button btnStart;
		private Button btnBack;
	}
}