namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"copyMe.png";
            string outputFilePath = @"copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using var inputFile = new FileStream(inputFilePath, FileMode.Open);
            using var outputFile = new FileStream(outputFilePath, FileMode.Create);

            var buffer = new byte[4096];
            int bufferLength;

            while ((bufferLength = inputFile.Read(buffer, 0, buffer.Length)) > 0)
            {
                outputFile.Write(buffer, 0, bufferLength);
            }
        }
    }
}
