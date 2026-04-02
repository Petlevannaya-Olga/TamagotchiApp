using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
	internal class Cat(string name, double age) : Pet(name, age, PetConfigPresets.Cat)
	{
		public override Dictionary<PetState, Image> Images => new()
		{
			{ PetState.Base, Image.FromFile(@"..\..\..\Resources\Cat\cat_1.png") },
			{ PetState.Sleeping, Image.FromFile(@"..\..\..\Resources\Cat\cat_sleeping.png")},
			{ PetState.Enamored, Image.FromFile(@"..\..\..\Resources\Cat\cat_enamored.png") },
			{ PetState.Sick, Image.FromFile(@"..\..\..\Resources\Cat\cat_sick.png") }
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
				sb.Append($"{Name}: Я разрушу твой дом!!!");
				sb.Append(Environment.NewLine);
			}

			if (Energy.Value < Energy.Delta)
			{
				sb.Append($"{Name}: Я хочу спать!!!");
				sb.Append(Environment.NewLine);
			}

			return sb.ToString();
		}

		public override void Sleep()
		{
			Energy.Increase();
		}

		public override void Stroke()
		{
			Mood.Increase();
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
				if (Energy.Value < (Energy.Max - Energy.Min) / 2)
				{
					State = PetState.Sleeping;
				}
				Energy.Reduce();
			}
		}
	}
}
