//#define ARRAYS_1
//#define ARRAYS_2

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
			Random rand = new Random(0);
#if ARRAYS_1
			//Console.Write("Введите размер массива: ");
			int n = 5;// Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine(arr.GetLength(0));
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
			#region STATISTICS
			//int sum = 0;
			//foreach (int i in arr)
			//{
			//	sum += i;
			//}
			//Console.WriteLine("Сумма элементов массива: " + sum);
			//Console.WriteLine("Среднее-арифметическое элементов массива: " + (double)sum/arr.Length);
			//int min, max;
			//min = max = arr[0];
			//foreach (int i in arr)
			//{
			//	if (i < min) min = i;
			//	if (i > max) max = i;
			//}
			//Console.WriteLine("Минимальное значение в массиве: " + min);
			//Console.WriteLine("Максимальное значение в массиве: " + max); 
			#endregion

			Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");
			Array.Sort(arr);
			foreach (int i in arr) Console.Write(i + "\t"); Console.WriteLine();
#endif

#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());
			int[,] arr = new int[rows, cols];
			Console.WriteLine($"Количество измерений массива: {arr.Rank}");
			Console.WriteLine($"Общее количество элементов:   {arr.Length}");
			Console.WriteLine($"Количество строк массива:\t {arr.GetLength(0)}");
			Console.WriteLine($"Количество элементов строки:\t {arr.GetLength(1)}");
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j] + "\t");
				}
				Console.WriteLine();
			}
			foreach (int i in arr) Console.Write(i + "\t"); Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {arr.Cast<int>().Sum()}");
			//Метод Cast<>() преобразует двумерный массив в набор значений 'Enumerable', 
			//и уже для этого набора значений можно вычислить сумму.
			Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Cast<int>().Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {arr.Cast<int>().Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {arr.Cast<int>().Max()}");
#endif
			//					Зубчатые массивы:
			int[][] arr =
			{
				new int[]{ 3, 5, 8, 13, 21 },
				new int[]{ 34, 55, 89 },
				new int[]{ 144, 233, 377, 610 }
			};
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.Write(arr[i][j] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}
