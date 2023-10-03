﻿using System;
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
                Console.WriteLine(
                    value: $"{Path.GetFileName(path: System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)} <input_textfile> <output_textfile>");
            }
            else if (string.IsNullOrEmpty(value: args[1]))
            {
                Console.WriteLine(value: "No <output_textfile> found! Usage:\n");
                Console.WriteLine(
                    value: $"{Path.GetFileName(path: System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)} <input_textfile> <output_textfile>");
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
                        new List<string>
                        {
                            "A",
                            "a",
                            "À",
                            "à",
                            "Á",
                            "á",
                            "Â",
                            "â",
                            "Ã",
                            "ã",
                            "Ä",
                            "ä",
                            "Å",
                            "å",
                            "Ǻ",
                            "ǻ",
                            "Ā",
                            "ā",
                            "Ă",
                            "ă",
                            "Ą",
                            "ą",
                            "Ǎ",
                            "ǎ",
                            "Ǟ",
                            "ǟ",
                            "Ǡ",
                            "ǡ",
                            "Ȁ",
                            "ȁ",
                            "Ȧ",
                            "ȧ",
                            "Ⱥ",
                            "ⱥ",
                            "Ḁ",
                            "ḁ",
                            "ẚ",
                            "Ạ",
                            "ạ",
                            "Ả",
                            "ả",
                            "Ấ",
                            "ấ",
                            "Ầ",
                            "ầ",
                            "Ấ",
                            "ấ",
                            "Ẩ",
                            "ẩ",
                            "Ẫ",
                            "ẫ",
                            "Ậ",
                            "ậ",
                            "Ắ",
                            "ắ",
                            "Ằ",
                            "ằ",
                            "Ẳ",
                            "ẳ",
                            "Ẵ",
                            "ẵ",
                            "Ặ",
                            "ặ",
                            "Æ",
                            "æ",
                            "Ǽ",
                            "ǽ",
                            "Ǣ",
                            "ǣ",
                            "Ɑ",
                            "ɑ",
                            "Ɐ",
                            "ɐ",
                            "Ɒ",
                            "ɒ",
                            "A̱",
                            "a̱",
                            "A̮",
                            "a̮",
                            "Aͤ",
                            "aͤ",
                            "E",
                            "e",
                            "È",
                            "è",
                            "É",
                            "é",
                            "Ê",
                            "ê",
                            "Ë",
                            "ë",
                            "Ē",
                            "ē",
                            "Ĕ",
                            "ĕ",
                            "Ė",
                            "ė",
                            "Ė̄",
                            "ė̄",
                            "Ę",
                            "ę",
                            "Ě",
                            "ě",
                            "Ǝ",
                            "ǝ",
                            "Ɛ",
                            "ɛ",
                            "Ə",
                            "ə",
                            "Ȅ",
                            "ȅ",
                            "Ȇ",
                            "ȇ",
                            "Ȩ",
                            "ȩ",
                            "Ɇ",
                            "ɇ",
                            "Ḕ",
                            "ḕ",
                            "Ḗ",
                            "ḗ",
                            "Ḙ",
                            "ḙ",
                            "Ḛ",
                            "ḛ",
                            "Ḝ",
                            "ḝ",
                            "Ẹ",
                            "ẹ",
                            "Ẻ",
                            "ẻ",
                            "Ẽ",
                            "ẽ",
                            "Ế",
                            "ế",
                            "Ề",
                            "ề",
                            "Ể",
                            "ể",
                            "Ễ",
                            "ễ",
                            "Ệ",
                            "ệ",
                            "I",
                            "i",
                            "Ì",
                            "ì",
                            "Í",
                            "í",
                            "Î",
                            "î",
                            "Ï",
                            "ï",
                            "Ĩ",
                            "ĩ",
                            "Ī",
                            "ī",
                            "Ĭ",
                            "ĭ",
                            "Į",
                            "į",
                            "İ",
                            "i",
                            "I",
                            "ı",
                            "Ĳ",
                            "ĳ",
                            "Ɩ",
                            "ɩ",
                            "Ɨ",
                            "ɨ",
                            "Ǐ",
                            "ǐ",
                            "Ȉ",
                            "ȉ",
                            "Ȋ",
                            "ȋ",
                            "Ḭ",
                            "ḭ",
                            "Ḯ",
                            "ḯ",
                            "Ỉ",
                            "ỉ",
                            "Ị",
                            "ị",
                            "O",
                            "o",
                            "Ò",
                            "ò",
                            "Ó",
                            "ó",
                            "Ô",
                            "ô",
                            "Õ",
                            "õ",
                            "Ö",
                            "ö",
                            "Ø",
                            "ø",
                            "Oͤ",
                            "oͤ",
                            "Ǿ",
                            "ǿ",
                            "Ō",
                            "ō",
                            "Ŏ",
                            "ŏ",
                            "Ő",
                            "ő",
                            "Ɔ",
                            "ɔ",
                            "Ɵ",
                            "ɵ",
                            "Ơ",
                            "ơ",
                            "Ǒ",
                            "ǒ",
                            "Ǫ",
                            "ǫ",
                            "Ǭ",
                            "ǭ",
                            "Ȍ",
                            "ȍ",
                            "Ȏ",
                            "ȏ",
                            "Ȫ",
                            "ȫ",
                            "Ȭ",
                            "ȭ",
                            "Ȯ",
                            "ȯ",
                            "Ȱ",
                            "ȱ",
                            "Ṍ",
                            "ṍ",
                            "Ṏ",
                            "ṏ",
                            "Ṑ",
                            "ṑ",
                            "Ṓ",
                            "ṓ",
                            "O̧",
                            "o̧",
                            "Ọ",
                            "ọ",
                            "Ỏ",
                            "ỏ",
                            "Ố",
                            "ố",
                            "Ồ",
                            "ồ",
                            "Ổ",
                            "ổ",
                            "Ỗ",
                            "ỗ",
                            "Ộ",
                            "ộ",
                            "Ớ",
                            "ớ",
                            "Ờ",
                            "ờ",
                            "Ở",
                            "ở",
                            "Ỡ",
                            "ỡ",
                            "Ợ",
                            "ợ",
                            "O͘",
                            "o͘",
                            "Ꝋ",
                            "ꝋ",
                            "Ꝍ",
                            "ꝍ",
                            "Ꝏ",
                            "ꝏ",
                            "ⱺ",
                            "Œ",
                            "œ",
                            "Ȯ",
                            "ȯ",
                            "U",
                            "u",
                            "Ú",
                            "ú",
                            "Û",
                            "û",
                            "Ù",
                            "ù",
                            "Ü",
                            "ü",
                            "Ŭ",
                            "ŭ",
                            "Ũ",
                            "ũ",
                            "Ū",
                            "ū",
                            "Ů",
                            "ů",
                            "Ű",
                            "ű",
                            "Ų",
                            "ų",
                            "Ư",
                            "ư",
                            "Ǔ",
                            "ǔ",
                            "Ǖ",
                            "ǖ",
                            "Ǘ",
                            "ǘ",
                            "Ǚ",
                            "ǚ",
                            "Ǜ",
                            "ǜ",
                            "Ȕ",
                            "ȕ",
                            "Ȗ",
                            "ȗ",
                            "Ʉ",
                            "ʉ",
                            "Ṳ",
                            "ṳ",
                            "Ṵ",
                            "ṵ",
                            "Ṷ",
                            "ṷ",
                            "Ṹ",
                            "ṹ",
                            "Ṻ",
                            "ṻ",
                            "Ụ",
                            "ụ",
                            "Ủ",
                            "ủ",
                            "Ứ",
                            "ứ",
                            "Ừ",
                            "ừ",
                            "Ử",
                            "ử",
                            "Ữ",
                            "ữ",
                            "Ự",
                            "ự",
                            "Uͤ",
                            "uͤ",
                            "U̇",
                            "u̇"
                        }.ForEach(action: m => line = line.Replace(oldValue: m, newValue: string.Empty));
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
