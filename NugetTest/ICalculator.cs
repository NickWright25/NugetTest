using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetTest
{
	public interface ICalculator
	{
		int Add(int num1, int num2);
		decimal Add(decimal num1, decimal num2);
		decimal Divide(int num1, int num2);
		decimal Divide(decimal num1, decimal num2);
		int Multiply(int num1, int num2);
		decimal Multiply(decimal num1, decimal num2);
		int Subtract(int num1, int num2);
		decimal Subtract(decimal num1, decimal num2);
	}
}
