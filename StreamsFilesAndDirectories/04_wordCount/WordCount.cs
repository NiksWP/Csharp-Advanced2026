namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"Files/words.txt";
            string textPath = @"Files/text.txt";
            string outputPath = @"Files/output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var words = File.ReadAllText(wordsFilePath).Split().ToArray();
            using var output = new StreamWriter(outputFilePath);

            var inputText = File.ReadAllText(textFilePath);
            var inputWords = Regex.Matches(inputText, @"\p{L}+").Select(x => x.Value).Select(x => x.ToLower()).ToArray();

            var word = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];

                if (!inputWords.Contains(currentWord)) continue;
                word[currentWord] = 0;
                for (int j = 0; j < inputWords.Length; j++)
                {
                    if (inputWords[j] == currentWord)
                    {
                        word[currentWord]++;
                    }
                }
            }

            foreach (var item in word.OrderByDescending(x => x.Value))
            {
                output.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
