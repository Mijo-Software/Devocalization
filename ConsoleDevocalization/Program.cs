using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ConsoleDevocalization
{
	/// <summary>
	/// Provides the main entry point for the ConsoleDevocalization application.
	/// This class is static and cannot be instantiated.
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		private static void Main(string[] args)
		{
			string line;
			uint numberReadChars = 0;    // Counter for the number of characters read from the input file
			uint numberWrittenChars = 0; // Counter for the number of characters written to the output file
			Console.WriteLine(value: "Devocalization Tool\n");

			// Check if no arguments are provided
			if (args.Length == 0)
			{
				Console.WriteLine(value: "No arguments found! Usage:\n");
				ProcessModule processModule = Process.GetCurrentProcess().MainModule;
				if (processModule != null)
				{
					// Print usage instructions with the executable name
					Console.WriteLine(
						value: $@"{Path.GetFileName(path: processModule.FileName)} <input_textfile> <output_textfile>");
				}
			}
			// Check if the output file argument is missing or empty
			else if (string.IsNullOrEmpty(value: args[1]))
			{
				Console.WriteLine(value: "No <output_textfile> found! Usage:\n");
				ProcessModule processModule = Process.GetCurrentProcess().MainModule;
				if (processModule != null)
				{
					// Print usage instructions with the executable name
					Console.WriteLine(
						value: $@"{Path.GetFileName(path: processModule.FileName)} <input_textfile> <output_textfile>");
				}
			}
			else
			{
				try
				{
					// Open the input and output files
					StreamReader sr = new StreamReader(path: args[0]);
					StreamWriter sw = new StreamWriter(path: args[1]);
					line = sr.ReadLine();
					// Process each line in the input file
					while (line != null)
					{
						numberReadChars += Convert.ToUInt32(value: line.Length);
						// Remove all specified vowels and related characters from the line
						new List<string>
						{
                            // List of vowels and related Unicode characters to remove
                            "A", "a", "À", "à", "Á", "á", "Â", "â", "Ã", "ã", "Ä", "ä", "Å", "å", "Ǻ", "ǻ",
							"Ā", "ā", "Ă", "ă", "Ą", "ą", "Ǎ", "ǎ", "Ǟ", "ǟ", "Ǡ", "ǡ", "Ȁ", "ȁ", "Ȧ", "ȧ",
							"Ⱥ", "ⱥ", "Ḁ", "ḁ", "ẚ", "Ạ", "ạ", "Ả", "ả", "Ấ", "ấ", "Ầ", "ầ", "Ấ", "ấ",
							"Ẩ", "ẩ", "Ẫ", "ẫ", "Ậ", "ậ", "Ắ", "ắ", "Ằ", "ằ", "Ẳ", "ẳ", "Ẵ", "ẵ", "Ặ", "ặ",
							"Æ", "æ", "Ǽ", "ǽ", "Ǣ", "ǣ", "Ɑ", "ɑ", "Ɐ", "ɐ", "Ɒ", "ɒ", "A̱", "a̱", "A̮", "a̮",
							"Aͤ", "aͤ", "E", "e", "È", "è", "É", "é", "Ê", "ê", "Ë", "ë", "Ē", "ē", "Ĕ", "ĕ",
							"Ė", "ė", "Ė̄", "ė̄", "Ę", "ę", "Ě", "ě", "Ǝ", "ǝ", "Ɛ", "ɛ", "Ə", "ə", "Ȅ", "ȅ",
							"Ȇ", "ȇ", "Ȩ", "ȩ", "Ɇ", "ɇ", "Ḕ", "ḕ", "Ḗ", "ḗ", "Ḙ", "ḙ", "Ḛ", "ḛ", "Ḝ", "ḝ",
							"Ẹ", "ẹ", "Ẻ", "ẻ", "Ẽ", "ẽ", "Ế", "ế", "Ề", "ề", "Ể", "ể", "Ễ", "ễ", "Ệ", "ệ",
							"I", "i", "Ì", "ì", "Í", "í", "Î", "î", "Ï", "ï", "Ĩ", "ĩ", "Ī", "ī", "Ĭ", "ĭ",
							"Į", "į", "İ", "i", "I", "ı", "Ĳ", "ĳ", "Ɩ", "ɩ", "Ɨ", "ɨ", "Ǐ", "ǐ", "Ȉ", "ȉ",
							"Ȋ", "ȋ", "Ḭ", "ḭ", "Ḯ", "ḯ", "Ỉ", "ỉ", "Ị", "ị", "O", "o", "Ò", "ò", "Ó", "ó",
							"Ô", "ô", "Õ", "õ", "Ö", "ö", "Ø", "ø", "Oͤ", "oͤ", "Ǿ", "ǿ", "Ō", "ō", "Ŏ", "ŏ",
							"Ő", "ő", "Ɔ", "ɔ", "Ɵ", "ɵ", "Ơ", "ơ", "Ǒ", "ǒ", "Ǫ", "ǫ", "Ǭ", "ǭ", "Ȍ", "ȍ",
							"Ȏ", "ȏ", "Ȫ", "ȫ", "Ȭ", "ȭ", "Ȯ", "ȯ", "Ȱ", "ȱ", "Ṍ", "ṍ", "Ṏ", "ṏ", "Ṑ", "ṑ",
							"Ṓ", "ṓ", "O̧", "o̧", "Ọ", "ọ", "Ỏ", "ỏ", "Ố", "ố", "Ồ", "ồ", "Ổ", "ổ", "Ỗ", "ỗ",
							"Ộ", "ộ", "Ớ", "ớ", "Ờ", "ờ", "Ở", "ở", "Ỡ", "ỡ", "Ợ", "ợ", "O͘", "o͘", "Ꝋ", "ꝋ",
							"Ꝍ", "ꝍ", "Ꝏ", "ꝏ", "ⱺ", "Œ", "œ", "Ȯ", "ȯ", "U", "u", "Ú", "ú", "Û", "û",
							"Ù", "ù", "Ü", "ü", "Ŭ", "ŭ", "Ũ", "ũ", "Ū", "ū", "Ů", "ů", "Ű", "ű", "Ų", "ų",
							"Ư", "ư", "Ǔ", "ǔ", "Ǖ", "ǖ", "Ǘ", "ǘ", "Ǚ", "ǚ", "Ǜ", "ǜ", "Ȕ", "ȕ", "Ȗ", "ȗ",
							"Ʉ", "ʉ", "Ṳ", "ṳ", "Ṵ", "ṵ", "Ṷ", "ṷ", "Ṹ", "ṹ", "Ṻ", "ṻ", "Ụ", "ụ", "Ủ", "ủ",
							"Ứ", "ứ", "Ừ", "ừ", "Ử", "ử", "Ữ", "ữ", "Ự", "ự", "Uͤ", "uͤ", "U̇", "u̇"
						}.ForEach(action: m => line = line.Replace(oldValue: m, newValue: string.Empty));
						numberWrittenChars += Convert.ToUInt32(value: line.Length);
						// Write the processed line to the output file
						sw.WriteLine(value: line);
						line = sr.ReadLine();
					}
					sr.Close();
					sw.Close();
					// Output statistics about the operation
					Console.WriteLine(value: $@"{numberReadChars} chars read");
					Console.WriteLine(value: $@"{numberWrittenChars} chars written");
					Console.WriteLine(value: $@"{numberReadChars - numberWrittenChars} chars removed");
				}
				catch (Exception e)
				{
					// Print any exception that occurs during file processing
					Console.WriteLine(value: $@"Exception: {e.Message}");
				}
			}
		}
	}
}