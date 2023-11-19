using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			try
			{
				Console.WriteLine(Factorial(n));
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		static int Factorial(int n)
		{
			if (n > 12) throw new Exception("Arithmetical overflow");
			int f = 1;
			for (int i = 1; i <= n; i++)
			{
				//if (i > 12) throw new Exception("Arithmetical overflow");
				f *= i;
				Console.WriteLine($"{i}! = {f}");
			}
			return f;
		}
	}
}
