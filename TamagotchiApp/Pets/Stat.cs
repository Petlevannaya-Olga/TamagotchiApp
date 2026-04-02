using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
	public sealed class Stat
	{
		private int _value;
		private int _delta;

		/// <summary>
		/// Минимальное значение
		/// </summary>
		public int Min { get; }

		/// <summary>
		/// Минимальное значение
		/// </summary>
		public int Max { get; }

		/// <summary>
		/// Текущее значение
		/// </summary>
		public int Value
		{
			get => _value;
			set => _value = Math.Clamp(value, Min, Max);
		}

		/// <summary>
		/// Величина изменения параметра
		/// </summary>
		public int Delta
		{
			get => _delta;
			set => _delta = Math.Clamp(value, Min, Max);
		}

		/// <summary>
		/// Изменение текущего значения
		/// </summary>
		/// <param name="delta">Величина, на которую изменяется текущее значение</param>
		public void Increase(int delta)
		{
			Value += delta;
		}

		public void Increase()
		{
			Value += Delta;
		}

		public void IncreaseMax()
		{
			Value = Max;
		}

		public void Reduce(int delta)
		{
			Value -= delta;
		}

		public void Reduce()
		{
			Value -= Delta;
		}

		public Stat(int min, int max, int value, int delta)
		{
			if (min >= max)
			{
				throw new ArgumentException("Минимум не может быть больше или равен максимуму");
			}

			if (max % delta != 0)
			{
				throw new ArgumentException("Изменение значения должно быть кратно максимальному значению");
			}

			if (value > max || value < min)
			{
				throw new ArgumentException("Значение должно быть в пределах от минимума до максимума");
			}

			Min = min;
			Max = max;
			Value = value;
			Delta = delta;
		}
	}
}