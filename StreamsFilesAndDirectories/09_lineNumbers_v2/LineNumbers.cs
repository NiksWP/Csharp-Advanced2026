namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"text.txt";
            string outputFilePath = @"output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var lines = File.ReadAllLines(inputFilePath);
            var list = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                list.Add($"Line {i + 1}: {lines[i]} ({lines[i].Where(x => char.IsLetter(x)).Count()})({lines[i].Where(x => char.IsPunctuation(x)).Count()})");
            }

            using var writer = new StreamWriter(outputFilePath);
            foreach (var sentance  in list)
            {
                writer.WriteLine(sentance);
            }
        }
    }
}
