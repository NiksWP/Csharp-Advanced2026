namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Threading;

    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using var reader = new StreamReader(inputFilePath);
            using var writer = new StreamWriter(outputFilePath);

            int count = 1;
            while (true)
            {
                var line = reader.ReadLine();
                if (line == null) break;

                writer.WriteLine($"{count}. {line}");
                count++;
            }
        }
    }
}
