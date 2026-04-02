namespace TamagotchiApp
{
	partial class StartupForm
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
			btnNew = new Button();
			btnOpen = new Button();
			btnClose = new Button();
			SuspendLayout();
			// 
			// btnNew
			// 
			btnNew.Location = new Point(12, 12);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(370, 40);
			btnNew.TabIndex = 0;
			btnNew.Text = "Новая игра";
			btnNew.UseVisualStyleBackColor = true;
			btnNew.Click += BtnNew_Click;
			// 
			// btnOpen
			// 
			btnOpen.Location = new Point(12, 58);
			btnOpen.Name = "btnOpen";
			btnOpen.Size = new Size(370, 40);
			btnOpen.TabIndex = 0;
			btnOpen.Text = "Загрузить из файла";
			btnOpen.UseVisualStyleBackColor = true;
			btnOpen.Click += BtnOpen_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(12, 104);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(370, 40);
			btnClose.TabIndex = 0;
			btnClose.Text = "Выход";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += BtnClose_Click;
			// 
			// StartupForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(394, 156);
			Controls.Add(btnClose);
			Controls.Add(btnOpen);
			Controls.Add(btnNew);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "StartupForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Тамагочи";
			ResumeLayout(false);
		}

		#endregion

		private Button btnNew;
		private Button btnOpen;
		private Button btnClose;
	}
}