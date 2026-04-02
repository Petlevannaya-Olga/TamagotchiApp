using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
	/// <summary>
	/// Персонаж
	/// </summary>
	public abstract class Pet(string name, double age, PetConfig petConfig)
	{
		/// <summary>
		/// Имя
		/// </summary>
		public string Name { get; } = name;

		/// <summary>
		/// Возраст
		/// </summary>
		public double Age { get; private set; } = age;

		/// <summary>
		/// Состояние питомца
		/// </summary>
		public PetState State { get; set; } = PetState.Base;

		/// <summary>
		/// Здоровье
		/// </summary>
		public Stat Health { get; } = new Stat(
				petConfig.Health.Min,
				petConfig.Health.Max,
				petConfig.Health.Value,
				petConfig.Health.Delta);

		/// <summary>
		/// Голод
		/// </summary>
		public Stat Hunger { get; } = new Stat(
				petConfig.Hunger.Min,
				petConfig.Hunger.Max,
				petConfig.Hunger.Value,
				petConfig.Hunger.Delta);

		/// <summary>
		/// Настроение
		/// </summary>
		public Stat Mood { get; } = new Stat(
				petConfig.Mood.Min,
				petConfig.Mood.Max,
				petConfig.Mood.Value,
				petConfig.Mood.Delta);

		/// <summary>
		/// Энергия
		/// </summary>
		public Stat Energy { get; } = new Stat(
				petConfig.Energy.Min,
				petConfig.Energy.Max,
				petConfig.Energy.Value,
				petConfig.Energy.Delta);

		/// <summary>
		/// Дисциплина
		/// </summary>
		public Stat Discipline { get; } = new Stat(
				petConfig.Discipline.Min,
				petConfig.Discipline.Max,
				petConfig.Discipline.Value,
				petConfig.Discipline.Delta);

		/// <summary>
		/// Изображения
		/// </summary>
		public abstract Dictionary<PetState, Image> Images { get; }

		public override string ToString()
		{
			return $"{Name}, {Age} лет";
		}

		/// <summary>
		/// Покормить
		/// </summary>
		public abstract void Feed();

		/// <summary>
		/// Погладить
		/// </summary>
		public abstract void Stroke();

		/// <summary>
		/// Играть
		/// </summary>
		public abstract void Play();

		/// <summary>
		/// Говорить
		/// </summary>
		public abstract string Say();

		/// <summary>
		/// Спать
		/// </summary>
		public abstract void Sleep();

		/// <summary>
		/// Увеличить возраст
		/// </summary>
		public void IncreaseAge()
		{
			Age += 0.2;
		}

		/// <summary>
		/// Изменить энергию
		/// </summary>
		public abstract void UpdateEnergy();

		/// <summary>
		/// Изменить здоровье, питомец может заболеть
		/// </summary>
		public virtual void UpdateHealth()
		{
			var random = new Random();
			var maySick = random.NextDouble();

			// Заболел
			if (maySick > 0.6)
			{
				var health = random.Next(0, (Health.Max - Health.Min) / 4);
				Health.Reduce(health);
				State = PetState.Sick;
			}
		}
	}
}
