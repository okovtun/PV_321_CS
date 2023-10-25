//#define CONSOLE_PARAMETRS
//#define STRING_OPERATIONS
//#define FIGURE
//#define DATA_TYPES
//#define LITERALS
#define CHESS_BOARD

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCS
{
	class Program
	{
		static void printSquare(int width, int height, int color, int x, int y)
		{
			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.White;
			}
			else if (color == 1) Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(x, y);
			for (int i = 0; i < height; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < width; j++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}
			Console.ResetColor();
		}
		static void printField(int width, int height, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			for (int i = 0; i < height; i++)
			{
				Console.SetCursorPosition(x, y + i);
				for (int j = 0; j < width; j++)
				{
					if (i == 0 || i == height - 1) Console.Write("_");
					else if (j == 0 || j == width - 1) Console.Write("|");
					else
					{
						Console.ForegroundColor = ConsoleColor.Black;
						Console.Write(" ");
						Console.ResetColor();
					}
				}
			}
			Console.ResetColor();
		}
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
#if FIGURE
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
#endif
#if DATA_TYPES
			#region LOGICAL_TYPES
			//Console.WriteLine(true);
			//Console.WriteLine(false);
			//// Console.WriteLine((bool).0000000001);
			//Console.WriteLine(Convert.ToBoolean(.000000001));
			#endregion
			#region CHARACTER_TYPES
			// char занимает 2 бавйта в памяти и хранит один единственный символ
			// всего 2^16 = 65 536
			#endregion
			#region Numeric_TYPES
			//Console.WriteLine(sizeof(int)); // размер типа
			//Console.WriteLine(int.MinValue + " . . . " + int.MaxValue); // мин.значение и макс.значение данного типа
			Console.WriteLine($"Переменная типа {typeof(int)} занимает {sizeof(int)} Байт.\n" +
				$" Принимает значения в диапозоне:{int.MinValue} ... {int.MaxValue};");
			// typeof(typename) где typename - тип переменной
			//Console.WriteLine(typeof(int));
			Console.WriteLine(delimiter);
			Console.WriteLine($"Переменная типа {typeof(double)} занимает {sizeof(double)} Байт.\n" +
				$" Принимает значения в диапозоне:{double.MinValue} ... {double.MaxValue};");
			//Console.WriteLine(typeof(double));
			Console.WriteLine(delimiter);
			Console.WriteLine($"Переменная типа {typeof(decimal)} занимает {sizeof(decimal)} Байт.\n" +
				$" Принимает значения в диапозоне:{decimal.MinValue} ... {decimal.MaxValue};");
			//Console.WriteLine(typeof(decimal));
			Console.WriteLine(delimiter);
			double a = 2;
			System.Int32 b = 3;
			Console.WriteLine(a.GetType());
			Console.WriteLine(b.GetType());
			Console.WriteLine(Object.Equals(a, b));
			#endregion
#endif
#if LITERALS
			Console.WriteLine(5.GetType()); // int
			Console.WriteLine(.5f.GetType()); // float
			Console.WriteLine(.5.GetType()); // double
			Console.WriteLine(5.0.GetType()); // double

			Console.WriteLine('+'.GetType());
#endif
#if CHESS_BOARD
			int width = 5, height = 4, color = 1, x = 5, y = 1, reserve = 4;
			Console.Write("Введите размер шахматной доски: ");
			int size = Convert.ToInt32(Console.ReadLine());
			int size_temp = size * size;
			printField(width * size + reserve, height * size + reserve, x, y);
			x += reserve / 2;
			y += reserve / 2;
			do
			{
				color = color > 0 ? 0 : 1; 
				//if (color > 0) color = 0;
				//else color = 1;
				printSquare(width, height, color, x, y);
				x += width;
				size_temp--;
				if (size_temp % size == 0)
				{
					x = 5 + reserve / 2;
					y += height;
				}
			} while (size_temp != 0);
			Console.Write("\n\n\n");
#endif
		}
		readonly static string delimiter = "\n----------------------\n";
	}
}
