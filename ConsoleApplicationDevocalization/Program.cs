using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplicationDevocalization
{
	class Program
	{
		static void Main(string[] args)
		{
			string line;
			uint numberReadedChars = 0;
			uint numberWrittenChars = 0;
			Console.WriteLine("Devocalization Tool\n");
			if (args.Length == 0)
			{
				Console.WriteLine("No arguments found! Usage:\n");
				Console.WriteLine(Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + " <input_textfile> <output_textfile>");
			}
			else if (string.IsNullOrEmpty(args[1]))
			{
				Console.WriteLine("No <output_textfile> found! Usage:\n");
				Console.WriteLine(Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + " <input_textfile> <output_textfile>");
			}
			else
			{
				try
				{
					StreamReader sr = new StreamReader(args[0]);
					StreamWriter sw = new StreamWriter(args[1]);
					line = sr.ReadLine();
					while (line != null)
					{
						numberReadedChars += Convert.ToUInt32(line.Length);
						new List<string> { "A", "a", "E", "e", "I", "i", "O", "o", "U", "u" }.ForEach(m => line = line.Replace(m, ""));
						numberWrittenChars += Convert.ToUInt32(line.Length);
						sw.WriteLine(line);
						line = sr.ReadLine();
					}
					sr.Close();
					sw.Close();
					Console.WriteLine(numberReadedChars.ToString() + " chars readed");
					Console.WriteLine(numberWrittenChars.ToString() + " chars written");
					Console.WriteLine((numberReadedChars - numberWrittenChars).ToString() + " chars removed");
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception: " + e.Message);
				}
			}
		}
	}
}
