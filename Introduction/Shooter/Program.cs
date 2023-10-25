//#define CHARACTERS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
	class Program
	{
		static void Main(string[] args)
		{
#if CHARACTERS
			char key;
			do
			{
				key = Console.ReadKey(true).KeyChar;
				Console.WriteLine((int)key + "\t" + key);
				switch (key)
				{
					case 'C': case 'c': Console.Clear(); break;
					case 'W': case 'w': Console.WriteLine("Вперед"); break;
					case 'S': case 's': Console.WriteLine("Назад"); break;
					case 'A': case 'a': Console.WriteLine("Влево"); break;
					case 'D': case 'd': Console.WriteLine("Вправо"); break;
					case ' ': Console.WriteLine("Прыжок"); break;
					case (char)13: Console.WriteLine("Огонь"); break;
					case (char)27: Console.WriteLine("Выход"); break;
					default: Console.WriteLine("Error"); break;
				}
			} while (key != 27); 
#endif
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.C:Console.Clear();break;
					case ConsoleKey.W:
					case ConsoleKey.UpArrow:	Console.WriteLine("Вперед"); break;
					case ConsoleKey.S:
					case ConsoleKey.DownArrow:	Console.WriteLine("Назад");  break;
					case ConsoleKey.A:
					case ConsoleKey.LeftArrow:	Console.WriteLine("Влево");  break;
					case ConsoleKey.D:
					case ConsoleKey.RightArrow:	Console.WriteLine("Вправо"); break;
					case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
					case ConsoleKey.Enter: Console.WriteLine("Огонь"); break;
					case ConsoleKey.Escape: Console.WriteLine("Выход"); break;
					default: Console.WriteLine("Error");break;
				}
			} while (key != ConsoleKey.Escape);
		}
	}
}
