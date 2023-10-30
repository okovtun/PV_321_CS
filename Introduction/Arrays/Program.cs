using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Введите размер массива: ");
			int n = 5;// Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];

			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();

			int sum = 0;
			foreach (int i in arr)
			{
				sum += i;
			}
			Console.WriteLine("Сумма элементов массива: " + sum);
		}
	}
}
