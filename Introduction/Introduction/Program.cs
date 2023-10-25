//#define CONSOLE_PARAMETERS
//#define STRING_OPERATIONS
//#define DATA_TYPES
//#define LITERALS
//#define TYPE_CONVERSIONS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
	class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE_PARAMETERS
			Console.Title = "Introduction to .NET";
			Console.Write("\t\t\t\tHello .NET\n");
			Console.Write("Сам привет!\n");

			Console.SetCursorPosition(25, 15);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine("SetConsoleCursorPosition");
			Console.ResetColor();
			Console.Beep(37, 1000);
			Console.CursorTop = 7;
			Console.CursorLeft = 25;
			Console.WriteLine("От и сказочке конец");
			Console.CursorSize = 100;
			Console.CursorVisible = true; 
#endif

#if STRING_OPERATIONS
			Console.Write("Введите Ваше имя: ");
			string first_name = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ваше имя: " + first_name + ", Ваша фамилия: " + last_name + ", Ваш возраст: " + age + " лет.");  //Конкатенация строк
			Console.WriteLine(string.Format("Ваше имя: {0}, Ваша фамилия: {1}, Ваш возраст: {2} лет.", first_name, last_name, age));    //Форматирование строк
			Console.WriteLine($"Ваше имя: {first_name}, Ваша фамилия: {last_name}, Ваш возраст: {age} лет.");   //Интерполяция строк  
#endif
#if DATA_TYPES
			#region LOGICAL_TYPES
			//Console.WriteLine(true);
			//Console.WriteLine(false);
			////Console.WriteLine((bool).00000000000001);
			//Console.WriteLine(Convert.ToBoolean(.000000000000100));
			#endregion

			#region CHARACTER_TYPES
			//char - занимает 2 Байта памяти, и хранит один единственный символ в кодировке Unicode.
			//2^16 = 65 536.
			#endregion

			#region NUMERIC_TYPES
			Console.WriteLine(sizeof(int));
			Console.WriteLine(int.MinValue + " ... " + int.MaxValue);
			Console.WriteLine(delimiter);
			Console.WriteLine(
				$"Переменная типа {typeof(int)} занимает {sizeof(int)} Байт,\n" +
				$"и принимает значения в диапазоне:{int.MinValue} ... {int.MaxValue};");
			Console.WriteLine(
				$"Переменная типа {typeof(uint)} занимает {sizeof(uint)} Байт,\n" +
				$"и принимает значения в диапазоне:{uint.MinValue} ... {uint.MaxValue};");
			Console.WriteLine(delimiter);
			Console.WriteLine(
				$"Переменная типа {typeof(float)} занимает {sizeof(float)} Байт,\n" +
				$"и принимает значения в диапазоне:{float.MinValue} ... {float.MaxValue};");
			//					   typeof(typename)
			//Console.WriteLine(typeof(int));
			Console.WriteLine(delimiter);
			Console.WriteLine(
				$"Переменная типа {typeof(double)} занимает {sizeof(double)} Байт,\n" +
				$"и принимает значения в диапазоне:{double.MinValue} ... {double.MaxValue};");
			//					   typeof(typename)
			//Console.WriteLine(typeof(int));
			Console.WriteLine(delimiter);
			Console.WriteLine(
				$"Переменная типа {typeof(decimal)} занимает {sizeof(decimal)} Байт,\n" +
				$"и принимает значения в диапазоне:{decimal.MinValue} ... {decimal.MaxValue};");
			//					   typeof(typename)
			//Console.WriteLine(typeof(int));
			Console.WriteLine(delimiter);

			double a = 2;
			System.Int32 b = 2;
			Console.WriteLine(a.GetType());
			Console.WriteLine(b.GetType());
			Console.WriteLine(Object.Equals(a, b));
			#endregion
#endif

#if LITERALS
			Console.WriteLine(5.GetType());     //int
			Console.WriteLine(.5);
			Console.WriteLine(.5f.GetType());	//float
			Console.WriteLine(.5.GetType());    //double
			Console.WriteLine(5.0.GetType());

			Console.WriteLine('+'.GetType());
#endif

#if TYPE_CONVERSIONS
			//(type)value; - C-like notation (С-подобная форма записи)
			//type(value); - Functional notation (Функциональная форма записи, в C# НЕ используется)
			//expression - выражение 2+3
			//(type)(2+3)
			//(type)(expression)
			int a = 2;
			uint b = (uint)a;
			int c = (int)b;
			//int (Integer - Целое число) +-
			//uint - Unsigned Integer (Беззнаковое целое число) только +  
#endif
			int i = 3;

			i = i++ + ++i;

			Console.WriteLine(i);
		}

		static readonly string delimiter = "\n------------------------------------------\n";
	}
}
