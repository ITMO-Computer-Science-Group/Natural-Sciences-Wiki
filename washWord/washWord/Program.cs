using System;
using System.IO;
using System.Collections;

namespace washWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles($"{Environment.CurrentDirectory}\\raw");
            char[] upper = new char[] { };
            char[] lower = new char[] { };
            Console.WriteLine("Starting Washing Word");
            ArrayList list = new ArrayList();
            string[] filename = new string[files.Length];

            foreach (var file in files)
            {
                int index = int.Parse(file.Split("\\")[file.Split("\\").Length-1].Split(' ')[0]);
                filename[index] = file;
            }
            int i = 0;
            foreach (var file in filename)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Length != 0 && line[0] == '|')
                            if (!(line.Contains("русский") || line.Contains("-----")))
                            {
                                Console.WriteLine($"{i}\t{line.Split('|')[1].Trim()}\t{line.Split('|')[2].Trim()}");
                                list.Add($"{i++}\t{line.Split('|')[1].Trim()}\t{line.Split('|')[2].Trim()}");
                            }
                    }
                }
            }
            using (StreamWriter sr = new StreamWriter($@"{Environment.CurrentDirectory}\\wordlist"))
            {
                foreach (string line in list)
                {
                    sr.WriteLine(line);
                }
            }
            Console.WriteLine("down!");
            Console.ReadLine();
        }
    }
}
