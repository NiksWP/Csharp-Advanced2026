namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            //string inputFilePath = @"..\..\..\Files\input.txt";
            //string outputFilePath = @"..\..\..\Files\output.txt";
            string inputFilePath = "Files/input.txt";
            string outputFilePath = "Files/output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using var reader = new StreamReader(inputFilePath);
            using var writer = new StreamWriter(outputFilePath, true);

            var counter = 0;
            while (true)
            {
                var line = reader.ReadLine();
                if (line == null) break;

                if (counter % 2 == 1)
                {
                    writer.WriteLine(line);
                }

                counter++;
            }
        }
    }
}
