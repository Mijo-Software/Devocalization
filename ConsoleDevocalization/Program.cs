using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleDevocalization
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			string line;
			uint numberReadedChars = 0;
			uint numberWrittenChars = 0;
			Console.WriteLine(value: "Devocalization Tool\n");
			if (args.Length == 0)
			{
				Console.WriteLine(value: "No arguments found! Usage:\n");
				Console.WriteLine(value: $"{Path.GetFileName(path: System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)} <input_textfile> <output_textfile>");
			}
			else if (string.IsNullOrEmpty(value: args[1]))
			{
				Console.WriteLine(value: "No <output_textfile> found! Usage:\n");
				Console.WriteLine(value: $"{Path.GetFileName(path: System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)} <input_textfile> <output_textfile>");
			}
			else
			{
				try
				{
					StreamReader sr = new StreamReader(path: args[0]);
					StreamWriter sw = new StreamWriter(path: args[1]);
					line = sr.ReadLine();
					while (line != null)
					{
						numberReadedChars += Convert.ToUInt32(value: line.Length);
						new List<string> { "A", "a", "E", "e", "I", "i", "O", "o", "U", "u" }.ForEach(m => line = line.Replace(oldValue: m, newValue: string.Empty));
						numberWrittenChars += Convert.ToUInt32(value: line.Length);
						sw.WriteLine(value: line);
						line = sr.ReadLine();
					}
					sr.Close();
					sw.Close();
					Console.WriteLine(value: $"{numberReadedChars} chars readed");
					Console.WriteLine(value: $"{numberWrittenChars} chars written");
					Console.WriteLine(value: $"{numberReadedChars - numberWrittenChars} chars removed");
				}
				catch (Exception e)
				{
					Console.WriteLine(value: $"Exception: {e.Message}");
				}
			}
		}
	}
}
