//#define CONSOLE_PARAMETRS
#define STRING_OPERATIONS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCS
{
	class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE_PARAMETRS
			Console.Title = "Introduction to .NET";
			Console.Write("\tHello .NET\n");
			Console.Write("Сам привет!");

			Console.SetCursorPosition(25, 15);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine("SerConsoleCursorPosition");
			Console.ResetColor();
			Console.Beep(370, 1000);
			Console.CursorTop = 7;
			Console.CursorLeft = 25;
			Console.Clear();
			Console.WriteLine("От и сказочке конец");
			Console.CursorSize = 100;
			Console.CursorVisible = false; 
#endif

#if STRING_OPERATION
			Console.Write("Введите ваше имя: ");
			string first_name = Console.ReadLine();

			Console.Write("Введите вашу фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ваше имя: " + first_name + ", Ваша фамилия: " + last_name + ", Ваш возраст: " + age + " лет."); // конкатенация строк
			Console.WriteLine(string.Format("Ваше имя: {0}, Ваша фамилия: {1}, Ваш возраст: {2} лет.", first_name, last_name, age)); //форматирование строк
			Console.WriteLine($"Ваше имя: {first_name}, Ваша фамилия: {last_name}, Ваш возраст: {age} лет."); // интерполяция строк
#endif
			// задание №0
			int number = 5, x = 0, y = 0, step = 8;
			for (int i = 0; i < number; i++)
			{
				for (int j = 0; j < number; j++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}

			// задание №1
			y += step;
			Console.SetCursorPosition(x, y);
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if (j > i) Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("*");
					Console.ResetColor();
				}
				Console.Write("\n");
			}

			// задание №2
			y += step;
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if (j + i >= number) Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("*");
					Console.ResetColor();
				}
				Console.Write("\n");
			}

			// задание №3
			y += step;
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if (j < i) Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("*");
					Console.ResetColor();
				}
				Console.Write("\n");
			}

			// задание №4
			y += step;
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if (j + i < number - 1) Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("*");
					Console.ResetColor();
				}
				Console.Write("\n");
			}

			// задание №5
			y += step;
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if (j + i != number - 1) Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("/");
					Console.ResetColor();
				}
				Console.Write("\n");
			}
			x += number;
			Console.SetCursorPosition(x, y);
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if (j != i) Console.ForegroundColor = ConsoleColor.Black;
					Console.Write(@"\");
					Console.ResetColor();
				}
				Console.Write("\n");
			}
			x = 0;
			y += number;
			Console.SetCursorPosition(x, y);
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if (j != i) Console.ForegroundColor = ConsoleColor.Black;
					Console.Write(@"\");
					Console.ResetColor();
				}
				Console.Write("\n");
			}
			x += number;
			Console.SetCursorPosition(x, y);
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if (j + i != number - 1) Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("/");
					Console.ResetColor();
				}
				Console.Write("\n");
			}

			// задание №6
			y += step;
			x = 0;
			for (int i = 0; i < number; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < number; j++)
				{
					if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0)) Console.Write("+");
					else if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0)) Console.Write("-");
				}
				Console.Write("\n");
			}
		}
	}
}
