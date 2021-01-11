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
                                //Console.WriteLine($"{i}\t{line.Split('|')[1].Trim()}\t{line.Split('|')[2].Trim()}");
                                list.Add($"{i++}\t{line.Split('|')[1].Trim()}\t{line.Split('|')[2].Trim()}");
                            }
                    }
                }
            }
            ArrayList word = new ArrayList();
            string[,] j = new string[list.Count, 2];
            int ind = 0;
            foreach(string x in list)
            {
                j[ind, 0] =x.Split('\t')[1];
                j[ind++, 1] =x.Split('\t')[2];
            }
            ArrayList zncn = new ArrayList();
            for(int f = 0; f < j.Length/2-1; f++)
            {
                if (!zncn.Contains(j[f, 1])) 
                { zncn.Add(j[f, 1]); }
                else 
                { continue; }
                string zh = j[f, 1];
                ArrayList ru = new ArrayList();
                ru.Add(j[f, 0]);
                bool has = false;
                for(int x = f + 1; x < j.Length/2; x++)
                {
                    if (j[x, 1]==j[f, 1]&&j[f,1]!=""&& j[x, 0] != j[f, 0])
                    {
                        has = true;
                        ru.Add(j[x, 0]);
                    }
                }
                if (has)
                {
                    Console.WriteLine(zh);
                    foreach(string rru in ru)
                    {
                        Console.WriteLine(rru);
                    }
                }
            }
            //using (StreamWriter sr = new StreamWriter($@"{Environment.CurrentDirectory}\\wordlist"))
            //{
            //    foreach (string line in list)
            //    {
            //        sr.WriteLine(line);
            //    }
            //}

            Console.WriteLine("down!");
            Console.ReadLine();
        }
    }
}
