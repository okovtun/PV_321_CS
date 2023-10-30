using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{
			//NumberFormatInfo nfi = new NumberFormatInfo();
			//nfi.NumberDecimalSeparator = ",";
			//Console.WriteLine(nfi.NumberDecimalSeparator);

			/////////////////////////////////////////////////////////////

			Console.Write("Введите выражение: ");
			string expression = "22+33/2+4*5";  //Console.ReadLine();
												//Console.WriteLine(expression);
			expression = expression.Replace(",", ".");
			//Console.WriteLine(expression);
			string[] values = expression.Split('+', '-', '*', '/');
			double[] numbers = new double[values.Length + 1];
			for (int i = 0; i < values.Length; i++) numbers[i] = Convert.ToDouble(values[i]);
			string[] operations = expression.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ' ');
			operations = operations.Where(val => val != "").ToArray();//https://stackoverflow.com/questions/496896/how-to-delete-an-element-from-an-array-in-c-sharp

			foreach (double i in numbers) Console.Write(i + "\t");
			Console.WriteLine();
			foreach (string i in operations) Console.Write(i + "\t");
			Console.WriteLine();
			/*double a = Convert.ToDouble(values[0]);
			double b = Convert.ToDouble(values[1]);

			if (expression.Contains('+')) Console.WriteLine($"{a} + {b} = {a + b}");
			else if (expression.Contains('-')) Console.WriteLine($"{a} - {b} = {a - b}");
			else if (expression.Contains('*')) Console.WriteLine($"{a} * {b} = {a * b}");
			else if (expression.Contains('/')) Console.WriteLine($"{a} / {b} = {a / b}");
			else Console.WriteLine("Нэт такой животный...");*/

			//while (operations.Contains("*") || operations.Contains("/"))
			{
				for (int i = 0; i < operations.Length; i++)
				{
					if (operations[i] == null) break;
					if (operations[i] == "*")
					{
						numbers[i] *= numbers[i + 1];
						for (int j = i + 1; j < numbers.Length - 1; j++) numbers[j] = numbers[j + 1];
						for (int j = i; j < operations.Length - 1; j++) operations[j] = operations[j + 1];
					}
					if (operations[i] == "/")
					{
						numbers[i] /= numbers[i + 1];
						for (int j = i + 1; j < numbers.Length - 1; j++) numbers[j] = numbers[j + 1];
						for (int j = i; j < operations.Length - 1; j++) operations[j] = operations[j + 1];
					}
					operations[operations.Length - 1] = null;
				}
			}
			//while (operations.Contains("+") || operations.Contains("-"))
			{
				for (int i = 0; i < operations.Length; i++)
				{
					if (operations[i] == null) break;
					if (operations[i] == "+")
					{
						numbers[i] += numbers[i + 1];
						for (int j = i + 1; j < numbers.Length - 1; j++) numbers[j] = numbers[j + 1];
						for (int j = i; j < operations.Length - 1; j++) operations[j] = operations[j + 1];
					}
					if (operations[i] == "-")
					{
						numbers[i] -= numbers[i + 1];
						for (int j = i + 1; j < numbers.Length - 1; j++) numbers[j] = numbers[j + 1];
						for (int j = i; j < operations.Length - 1; j++) operations[j] = operations[j + 1];
					}
				}
			}
			Console.WriteLine(numbers[0]);
		}
	}
}
