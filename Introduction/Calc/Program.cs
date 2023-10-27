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
			string expression = Console.ReadLine();
			//Console.WriteLine(expression);
			expression = expression.Replace(",", ".");
			//Console.WriteLine(expression);
			string[] values = expression.Split('+', '-', '*', '/');
			double[] numbers = new double[values.Length];
			for (int i = 0; i < numbers.Length; i++) numbers[i] = Convert.ToDouble(values[i]);
			string[] operators = expression.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ' ');
			
			foreach(double i in numbers) Console.Write(i + " ");
			Console.WriteLine();
			foreach(string i in operators) Console.Write(i+" ");
			Console.WriteLine();
			/*double a = Convert.ToDouble(values[0]);
			double b = Convert.ToDouble(values[1]);

			if (expression.Contains('+')) Console.WriteLine($"{a} + {b} = {a + b}");
			else if (expression.Contains('-')) Console.WriteLine($"{a} - {b} = {a - b}");
			else if (expression.Contains('*')) Console.WriteLine($"{a} * {b} = {a * b}");
			else if (expression.Contains('/')) Console.WriteLine($"{a} / {b} = {a / b}");
			else Console.WriteLine("Нэт такой животный...");*/
		}
	}
}
