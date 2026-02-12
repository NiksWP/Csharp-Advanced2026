namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            //string folderPath = @"../../../Files/TestFolder";
            //sstring outputPath = @"../../../Files/output.txt";
            string folderPath = @"Files/TestFolder";
            string outputPath = @"Files/output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            var directories = Directory.GetDirectories(folderPath + @"/..", "*", SearchOption.AllDirectories);

            double sum = 0;
            foreach (var directory in directories)
            {
                var files = Directory.GetFiles(directory);

                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    sum+= fileInfo.Length;
                }
            }

            var totalSizeKB = sum / 1024;

            File.WriteAllText(outputFilePath, $"{totalSizeKB} KB");
        }
    }
}
