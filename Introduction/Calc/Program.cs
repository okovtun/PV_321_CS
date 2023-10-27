using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите выражение: ");
			string expression = Console.ReadLine();
			//Console.WriteLine(expression);
			expression = expression.Replace(",", ".");
			//Console.WriteLine(expression);
			string[] values = expression.Split('+', '-', '*', '/');
			//for (int i = 0; i < values.Length; i++) Console.Write(values[i] + "\t");
			//Console.WriteLine();
			double a = Convert.ToDouble(values[0]);
			double b = Convert.ToDouble(values[1]);
			//Console.WriteLine($"a = {a}");
			//Console.WriteLine($"b = {b}");
			if (expression.Contains('+')) Console.WriteLine($"{a} + {b} = {a + b}");
			else if (expression.Contains('-')) Console.WriteLine($"{a} - {b} = {a - b}");
			else if (expression.Contains('*')) Console.WriteLine($"{a} * {b} = {a * b}");
			else if (expression.Contains('/')) Console.WriteLine($"{a} / {b} = {a / b}");
			else Console.WriteLine("Нэт такой животный...");
		}
	}
}
