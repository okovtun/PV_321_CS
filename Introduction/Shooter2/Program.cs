using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine($"Window size: {Console.WindowWidth}x{Console.WindowHeight}");
			//Console.WriteLine($"Buffer size: {Console.BufferWidth}x{Console.BufferHeight}");
			Random rand = new Random();
			int x = rand.Next(Console.WindowWidth - 1);
			int y = rand.Next(Console.WindowHeight - 1);

			Console.CursorVisible = false;

			ConsoleKey key;
			do
			{
				Console.Clear();
				Console.WriteLine($"Location: {x}x{y}");
				Console.SetCursorPosition(x, y);
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("+");
				Console.ResetColor();
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.W: case ConsoleKey.UpArrow:		y--; break;
					case ConsoleKey.S: case ConsoleKey.DownArrow:	y++; break;
					case ConsoleKey.A: case ConsoleKey.LeftArrow:	x--; break;
					case ConsoleKey.D: case ConsoleKey.RightArrow:	x++; break;
				}
				if (x == 0) { x++; Console.Beep(); }
				if (y == 0) { y++; Console.Beep(); }
				if (x == Console.WindowWidth - 1)  { x--; Console.Beep(); }
				if (y == Console.WindowHeight - 1) { y--; Console.Beep(); }
			} while (key != ConsoleKey.Escape);
		}
	}
}
