namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"Files/example.png";
            string bytesFilePath = @"Files/bytes.txt";
            string outputPath = @"Files/output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] bytes = File.ReadAllBytes(binaryFilePath);
            int[] specialBytes = File.ReadAllText(bytesFilePath).Split("\n").Select(int.Parse).ToArray();
            using var writer = new FileStream(outputPath, FileMode.Create);

            foreach (var _byte in bytes)
            {
                if (specialBytes.Contains(_byte))
                {
                    writer.WriteByte(_byte);
                }
            }
        }
    }
}
