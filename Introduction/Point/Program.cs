using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
	class Program
	{
		const string delimiter = "\n--------------------------------\n";
		static void Main(string[] args)
		{
			//Console.BackgroundColor = ConsoleColor.Blue;
			//Console.CursorLeft = 22;
			//Console.CursorTop = 7;
			Point A = new Point();
			A.X = 30;
			A.Y = 3;
			A.Z = 5000;
			A.Info();
			A.Show();
			Point B = new Point(32, 3);
			B.Info();
			B.Show();
			Console.WriteLine(delimiter);
			Console.WriteLine($"Количество точек: {Point.Count}");
		}
	}
}
