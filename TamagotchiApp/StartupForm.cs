using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TamagotchiApp
{
	public partial class StartupForm : Form
	{
		public StartupForm()
		{
			InitializeComponent();
		}

		private void BtnNew_Click(object sender, EventArgs e)
		{
			var form = new SettingsForm(this);
			form.Show();
			//Hide(); // Close нельзя, иначе приложение закроется
		}

		private void BtnOpen_Click(object sender, EventArgs e)
		{

		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
