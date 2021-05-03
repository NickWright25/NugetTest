using System;

namespace NugetTest
{
	public class Calculator : ICalculator
	{
		public int Add(int num1, int num2)
		{
			return num1 + num2;
		}

		public decimal Add(decimal num1, decimal num2)
		{
			return num1 + num2;
		}

		public decimal Divide(int num1, int num2)
		{
			return num1 / num2;
		}

		public decimal Divide(decimal num1, decimal num2)
		{
			return num1 / num2;
		}

		public int Multiply(int num1, int num2)
		{
			return num1 * num2;
		}

		public decimal Multiply(decimal num1, decimal num2)
		{
			return num1 * num2;
		}

		public int Subtract(int num1, int num2)
		{
			return num1 - num2;
		}

		public decimal Subtract(decimal num1, decimal num2)
		{
			return num1 - num2;
		}
	}
}
