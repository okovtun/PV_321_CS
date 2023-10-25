using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.OutputEncoding.
			//Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
			Console.WriteLine(Console.OutputEncoding.CodePage);
			Console.WriteLine(Console.OutputEncoding.EncodingName);
			for (int i = 0; i < 65536; i++)
			{
				if (i % 32 == 0) Console.WriteLine();
				Console.Write((char)i + " ");
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("██");
			Console.WriteLine("◘◘");
		}
	}
}
