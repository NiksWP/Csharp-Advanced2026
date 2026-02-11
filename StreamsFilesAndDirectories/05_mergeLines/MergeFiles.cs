namespace MergeFiles
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = "Files/input1.txt";
            var secondInputFilePath = "Files/input2.txt";
            var outputFilePath = "Files/output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var n = File.ReadAllLines(firstInputFilePath).ToArray();
            Queue<string> firstInput = new Queue<string>(n);
            var m = File.ReadAllLines(secondInputFilePath).ToArray();
            Queue<string> secondInput = new Queue<string>(m);

            using var writer = new StreamWriter(outputFilePath);

            while (true)
            {
                if (firstInput.Any()) writer.WriteLine(firstInput.Dequeue());
                if (secondInput.Any()) writer.WriteLine(secondInput.Dequeue());

                if (!firstInput.Any() && !secondInput.Any()) break;
            }
        }
    }
}
