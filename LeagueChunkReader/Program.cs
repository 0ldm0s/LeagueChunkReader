using System;
using System.IO;
using LeagueChunkReader.Types;

namespace LeagueChunkReader
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Args: <source>");
                return;
            }

            string source = args[0];

            if (!Directory.Exists(source))
            {
                Console.WriteLine("Error: directory not found: {0}", source);
                return;
            }

            foreach (string file in Directory.GetFiles(source))
            {
                if (file.ToLower().Contains("chunk"))
                {
                    Chunk chunk = new Chunk(file);
                }
            }
        }
    }
}