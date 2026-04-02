using TamagotchiApp.Pets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TamagotchiApp
{
	public partial class MainForm : Form
	{
		private readonly StartupForm _startupForm;
		private readonly Pet _pet;
		private int _count = 0;

		public MainForm(Pet pet, StartupForm startupForm)
		{
			_startupForm = startupForm;
			_pet = pet;

			InitializeComponent();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			_count++;
			_pet.Discipline.Reduce();
			_pet.Hunger.Increase();
			_pet.Mood.Reduce();
			_pet.UpdateEnergy();

			pbHealth.Value = _pet.Health.Value;
			pbDiscipline.Value = _pet.Discipline.Value;
			pbHunger.Value = _pet.Hunger.Value;
			pbMood.Value = _pet.Mood.Value;
			pbEnergy.Value = _pet.Energy.Value;

			// Каждые 1000 тиков возраст увеличиваем на 0,2
			if (_count % 1000 == 0)
			{
				_pet.IncreaseAge();
				lblNameAndAge.Text = _pet.ToString();
			}

			// Каждые 2000 тиков питомец может заболеть
			if (_count % 2000 == 0)
			{
				_pet.UpdateHealth();
			}

			// Каждые 100 тиков говорит о своем состоянии
			if (_count % 10 == 0)
			{
				rtbDialog.Text = _pet.Say();
			}

			pictureBox1.BackgroundImage = _pet.Images[_pet.State];
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer1.Stop();
			_startupForm.Close();

			// TODO сохранить персонажа?
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Настройки изображения
			pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;

			lblNameAndAge.Text = _pet.ToString();

			if (_pet is Cat cat)
			{
				pictureBox1.BackgroundImage = cat.Images[PetState.Base];
			}

			if (_pet is Dog dog)
			{
				pictureBox1.BackgroundImage = dog.Images[PetState.Base];
			}

			timer1.Start();

			ConfigureProgress();
		}

		private void ConfigureProgress()
		{
			pbHealth.Minimum = _pet.Health.Min;
			pbHealth.Maximum = _pet.Health.Max;
			pbHealth.Value = _pet.Health.Value;

			pbHunger.Minimum = _pet.Hunger.Min;
			pbHunger.Maximum = _pet.Hunger.Max;
			pbHunger.Value = _pet.Hunger.Value;

			pbEnergy.Minimum = _pet.Energy.Min;
			pbEnergy.Maximum = _pet.Energy.Max;
			pbEnergy.Value = _pet.Energy.Value;

			pbMood.Minimum = _pet.Mood.Min;
			pbMood.Maximum = _pet.Mood.Max;
			pbMood.Value = _pet.Mood.Value;

			pbDiscipline.Minimum = _pet.Discipline.Min;
			pbDiscipline.Maximum = _pet.Discipline.Max;
			pbDiscipline.Value = _pet.Discipline.Value;
		}

		private void BtnFeed_Click(object sender, EventArgs e)
		{

		}

		private void BtnWalk_Click(object sender, EventArgs e)
		{

		}

		private void BtnPlay_Click(object sender, EventArgs e)
		{

		}

		private void BtnGiveTreat_Click(object sender, EventArgs e)
		{

		}

		private void BtnHeal_Click(object sender, EventArgs e)
		{

		}

		private void BtnStroke_Click(object sender, EventArgs e)
		{
			_pet.Stroke();
		}

		private void BtnLearn_Click(object sender, EventArgs e)
		{

		}
	}
}
