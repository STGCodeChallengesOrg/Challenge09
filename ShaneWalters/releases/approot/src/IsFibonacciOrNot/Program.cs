using System;
using System.Collections.Generic;

namespace IsFibonacciOrNot
{
	public class Program
	{
		public void Main(string[] args)
		{
			// Prompt for and retrieve user input
			Console.WriteLine("Please enter a number, or list of numbers");
			Console.Write("separated by commas, for testing: ");
			var inputs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			var result = new List<string>();

			// Iterate over each number input
			foreach (var input in inputs)
			{
				int value;

				if (int.TryParse(input, out value))
				{
					if (IsFibonacciNumber(value))
					{
						result.Add("IsFibo");
					}
					else
					{
						result.Add("IsNotFibo");
					}
				}
				else
				{
					result.Add("<Unknown>");
				}
			}

			// Output the results and exit
			Console.WriteLine(string.Join(",", result));
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		/// <summary>
		/// This is a nice little method that tests a given number and determine if it's a Fibonacci number or not. Short and sweet.
		/// </summary>
		/// <param name="value">The number to test.</param>
		/// <returns><b>True</b> if the number belongs to the Fibonacci number series; otherwise, <b>false</b>.</returns>
		private bool IsFibonacciNumber(int value)
		{
			// 5x^2 + 4 a perfect square?
			var test1 = Math.Sqrt(5 * Math.Pow(value, 2) + 4);

			// 5x^2 - 4 a perfect square?
			var test2 = Math.Sqrt(5 * Math.Pow(value, 2) - 4);

			// A simple test for a perfect squares. Only one needs to be true to be in the Fibonacci series.
			return test1 % 1 == 0
				|| test2 % 1 == 0;
        }
	}
}
