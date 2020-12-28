using System;
using System.IO;
using System.Collections;

namespace washWord
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] upper = new char[] { };
            char[] lower = new char[] { };
            Console.WriteLine("Starting Washing Word");
            ArrayList list = new ArrayList();
            using (StreamReader sr = new StreamReader(@$"{Environment.CurrentDirectory}\\Законы сохранения в механике.md"))
            {
                string line = "";
                int i = 0;
                while ((line = sr.ReadLine())!=null)
                {
                    if (line.Length != 0 && line[0] == '|')
                        if (!(line.Contains("русский") || line.Contains("-----")))
                        {
                            Console.WriteLine($"{i}\t{line.Split('|')[1].Trim()}\t{line.Split('|')[2].Trim()}");
                            list.Add($"{i++}\t{line.Split('|')[1].Trim()}\t{line.Split('|')[2].Trim()}");
                        }
                }
            }
            using(StreamWriter sr = new StreamWriter($@"{Environment.CurrentDirectory}\\wordlist"))
            {
                foreach(string line in list)
                {
                    sr.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
