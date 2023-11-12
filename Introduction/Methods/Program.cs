//#define TRANSFER_PARAMETERS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
#if TRANSFER_PARAMETERS
			//ref и out
			int a, b;
			Console.Write("Введите два целых числа: ");
			Init(out a, out b);
			Console.WriteLine($"{a}\t{b}");
			//Program prog = new Program();
			//prog.Exchange(a, b);
			Program.Exchange(ref a, ref b);
			Console.WriteLine($"{a}\t{b}");

			int sum, product;
			Operations(ref a, ref b, out sum, out product);
			Console.WriteLine($"Sum:     {sum}");
			Console.WriteLine($"Product: {product}"); 
#endif
			Console.WriteLine(Sum(3, 5, 8, 13, 21, 34));
			//params
		}
		static void Init(out int a, out int b)
		{
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
		}
		static void Exchange(ref int a, ref int b)
		{
			int buffer = a;
			a = b;
			b = buffer;
		}

		static void Operations(ref int a, ref int b, out int sum, out int product)
		{
			sum = a + b;
			product = a * b;
		}
		static int Sum(params int[] values)
		{
			int sum = 0;
			foreach (int i in values) sum += i;
			return sum;
		}
	}
}
