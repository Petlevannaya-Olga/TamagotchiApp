using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
	/// <summary>
	/// Настройки питомца
	/// </summary>
	public class PetConfig
	{
		/// <summary>
		/// Здоровье
		/// </summary>
		public required Stat Health { get; set; }

		/// <summary>
		/// Голод
		/// </summary>
		public required Stat Hunger { get; set; }

		/// <summary>
		/// Настроение
		/// </summary>
		public required Stat Mood { get; set; }

		/// <summary>
		/// Энергия
		/// </summary>
		public required Stat Energy { get; set; }

		/// <summary>
		/// Дисциплина
		/// </summary>
		public required Stat Discipline { get; set; }
	}
}
