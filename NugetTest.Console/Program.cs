using System;

namespace NugetTest.Core
{
	class Program
	{
		static void Main()
		{
			var calculator = new Calculator();
			bool restart = true;
			while (restart)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine(
@"Choose from the following options:
Add
Subtract
Divide
Multiply
Exit
				");
				Console.ForegroundColor = ConsoleColor.Green;
				var operation = Console.ReadLine();
				Console.WriteLine();

				Console.WriteLine("Enter a number: ");
				var num1 = Console.ReadLine();
				Console.WriteLine("Enter another number: ");
				var num2 = Console.ReadLine();
				Console.WriteLine();

				if (operation.ToLower() == "exit")
				{
					restart = false;
				}
				else 
				{
					var num1Type = num1.TryGetTypeFromString();
					var num2Type = num2.TryGetTypeFromString();
					if (num1Type != null && num2Type != null && num1Type == num2Type)
					{
						operation = operation[0].ToString().ToUpper() + operation[1..];
						var method = calculator.GetType().GetMethod(operation, new Type[] { num1Type, num2Type });
						if (method != null)
						{
							var result = method.Invoke(calculator, new object[] { Convert.ChangeType(num1, num1Type), Convert.ChangeType(num2, num2Type) });
							Console.WriteLine($"Result is: {result}");
						}
						else
						{
							Console.WriteLine("Invalid operation. Try again.");
						}
					}
					else
					{
						Console.WriteLine("Invalid inputs. Try again.");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
