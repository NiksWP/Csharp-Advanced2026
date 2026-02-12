namespace SplitMergeBinaryFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"Files/example.png";
            string joinedFilePath = @"Files/example-joined.png";
            string partOnePath = @"Files/part-1.bin";
            string partTwoPath = @"Files/part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            var binaryFile = File.ReadAllBytes(sourceFilePath);

            var firstBinaryFile = new List<byte>();
            var secondBinaryFile = new List<byte>();

            for (int i = 0; i < binaryFile.Length; i++)
            {
                var partOneLength = binaryFile.Length % 2 == 0
                ? binaryFile.Length / 2
                : binaryFile.Length / 2 + 1;

                if (i < partOneLength)
                {
                   firstBinaryFile.Add(binaryFile[i]);
                }
                else
                {
                    secondBinaryFile.Add(binaryFile[i]);
                }
            }

            File.WriteAllBytes(partOneFilePath, firstBinaryFile.ToArray());
            File.WriteAllBytes(partTwoFilePath, secondBinaryFile.ToArray());
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            var firstBytes = File.ReadAllBytes(partOneFilePath);
            var secondBytes = File.ReadAllBytes(partTwoFilePath);
            using var stream = new FileStream(joinedFilePath, FileMode.Create);
            stream.Write(firstBytes);
            stream.Write(secondBytes);
        }
    }
}