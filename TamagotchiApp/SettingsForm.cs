using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TamagotchiApp.Pets;

namespace TamagotchiApp
{
	public partial class SettingsForm : Form
	{
		private readonly StartupForm _startupForm;

		public SettingsForm(StartupForm startupForm)
		{
			InitializeComponent();
			cbType.SelectedIndex = 0;
			_startupForm = startupForm;
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show("Имя не заполнено", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Pet pet = cbType.SelectedIndex switch
				{
					0 => new Cat(txtName.Text, 0),
					1 => new Dog(txtName.Text, 0),
					_ => throw new NotImplementedException()
				};

				var form = new MainForm(pet, _startupForm);
				form.Show();
				Close();
			}
		}

		private void BtnBack_Click(object sender, EventArgs e)
		{
			Close();
			_startupForm.Show();
		}
	}
}
