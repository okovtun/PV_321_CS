using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//internal - поля доступны только в методах данной сборки
//protected internal
//-----------------------------------
//static - статическое поле
//const  - константное поле, обязательно должно юыть проинициализировано при оъявлении прямо в классе
//readonly - 

namespace Point
{
	class Point
	{
		const int MAX_X = 95;
		const int MAX_Y = 22;
		double x;
		double y;
		static int count;
		static ConsoleColor color;
		//Properties:
		public double X
		{
			get { return x; }
			set
			{
				if (value > MAX_X) value = MAX_X;
				if (value < 0) value = 0;
				x = value;
			}
			//value - это ключевое слово
		}
		public double Y
		{
			get { return y; }
			set
			{
				if (value > MAX_Y) value = MAX_Y;
				if (value < 0) value = 0;
				y = value;
			}
		}
		public double Z //автосвойства
		{
			//автосвойства создают переменную-член неявно
			get;
			set;
		}
		public static int Count
		{
			get { return count; }
		}
		//Constructors:
		public Point(double x = 0, double y = 0)
		{
			this.X = x;
			this.Y = y;
			count++;
			Console.WriteLine($"Constryctor:\t{this.GetHashCode()}");
		}
		static Point()
		{
			color = ConsoleColor.Blue;
		}
		//Methods:
		public void Info()
		{
			Console.WriteLine($"X = {x},\tY = {y};");
		}
		public void Show()
		{
			Console.BackgroundColor = color;
			Console.ForegroundColor = color;
			int x = Console.CursorLeft;
			int y = Console.CursorTop;
			Console.SetCursorPosition((int)X, (int)Y);
			Console.WriteLine(" ");
			Console.SetCursorPosition(x, y);
			Console.ResetColor();
		}
	}
}
