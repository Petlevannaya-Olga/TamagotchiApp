using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
	internal class Dog(string name, double age) : Pet(name, age, PetConfigPresets.Dog)
	{
		public override Dictionary<PetState, Image> Images => new()
		{
			{ PetState.Base, Image.FromFile(@"..\..\..\Resources\Dog\dog_1.png") },
			{ PetState.Sleeping, Image.FromFile(@"..\..\..\Resources\Dog\dog_sleeping.png") },
			{ PetState.Enamored, Image.FromFile(@"..\..\..\Resources\Dog\dog_2.png") },
			{ PetState.Sick, Image.FromFile(@"..\..\..\Resources\Dog\dog_sick.png") }
		};

		public override void Feed()
		{
			throw new NotImplementedException();
		}

		public override void Play()
		{
			throw new NotImplementedException();
		}

		public override string Say()
		{
			var sb = new StringBuilder();

			if (Discipline.Value < Discipline.Delta)
			{
				sb.Append($"{Name}: А я съел твой тапок!!!");
			}

			return sb.ToString();
		}

		public override void Sleep()
		{
			Energy.Increase();
		}

		public override void Stroke()
		{
			if (State != PetState.Sleeping)
			{
				Mood.IncreaseMax();
				State = PetState.Enamored;
			}
		}

		public override void UpdateEnergy()
		{
			if (State == PetState.Sleeping)
			{
				if (Energy.Value == Energy.Max)
				{
					State = PetState.Base;
				}
				Energy.Increase();
			}
			else
			{
				if (Energy.Value < Energy.Delta * 10)
				{
					State = PetState.Sleeping;
				}
				Energy.Reduce();
			}
		}
	}
}
