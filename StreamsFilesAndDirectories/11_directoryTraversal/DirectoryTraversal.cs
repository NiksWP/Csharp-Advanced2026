namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolderPath);
            Dictionary<string, List<FileInfo>> filesByExtension = new Dictionary<string, List<FileInfo>>();

            StringBuilder sb = new StringBuilder();
            foreach (FileInfo file in directoryInfo.EnumerateFiles())
            {
                if (!filesByExtension.ContainsKey(file.Extension)) filesByExtension[file.Extension] = new List<FileInfo>();
                filesByExtension[file.Extension].Add(file);
            }

            foreach (var (extension, files) in filesByExtension.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.AppendLine(extension);
                foreach (FileInfo file in files.OrderBy(x => x.Length))
                {
                    var size = file.Length / 1024.0;
                    sb.AppendLine($"--{file.Name} - {size}KB");
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            // string pathToDesktop = Environment.GetFolderPath
            // (Environment.SpecialFolder.CommonDesktopDirectory);

            // string fullPath = Path.Combine(pathToDesktop, reportFileName);

            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fullPath = Path.Combine(pathToDesktop, reportFileName);


            Console.WriteLine(fullPath);
            Console.WriteLine(pathToDesktop);
            File.WriteAllText(fullPath, textContent);
        }
    }
}
