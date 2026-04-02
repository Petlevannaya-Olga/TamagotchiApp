using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
	public static class PetConfigPresets
	{
		public static PetConfig Dog => new()
		{
			Discipline = new Stat(0, 100, 50, 1),
			Energy = new Stat(0, 500, 90, 1),
			Health = new Stat(0, 5000, 5000, 1),
			Hunger = new Stat(0, 500, 50, 1),
			Mood = new Stat(0, 500, 500, 1)
		};

		public static PetConfig Cat => new()
		{
			Discipline = new Stat(0, 100, 10, 1),
			Energy = new Stat(0, 300, 90, 1),
			Health = new Stat(0, 5000, 5000, 1),
			Hunger = new Stat(0, 100, 50, 1),
			Mood = new Stat(0, 200, 30, 1)
		};
	}
}
