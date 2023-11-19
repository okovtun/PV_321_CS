//Files
//#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //Потоки ввода/вывода

namespace Files
{
	class Program
	{
		static void Main(string[] args)
		{
			string current_directory = Directory.GetCurrentDirectory();
			string filename = "File.txt";
			Console.WriteLine(current_directory);
#if WRITE_TO_FILE
			//StreamWriter sw = new StreamWriter(filename);
			//sw.WriteLine("Hello files");
			//sw.Close();

			StreamWriter aw = File.AppendText(filename);
			aw.WriteLine("Append");
			aw.Close();

			string cmd = $"{current_directory}\\{filename}";
			System.Diagnostics.Process.Start("notepad", cmd);
			//System.Diagnostics.Process.Start("copy.bat");  
#endif
			//Exception - это ошибка на этапе выполнения
			try
			{
				//throw new Exception("Нет такого файла");	//ключевое слово 'throw' бросает исключение
				StreamReader sr = new StreamReader("File1.txt");
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					Console.WriteLine(buffer);
				}
				sr.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				//throw;
			}
			
		}
	}
}
