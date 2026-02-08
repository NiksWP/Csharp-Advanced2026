using System.Drawing;
using System.Threading.Channels;

var students = new Dictionary<string, int>();
var technology = new Dictionary<string, int>();

string input;
while ((input = Console.ReadLine()) != "exam finished")
{
    var tokens = input.Split("-").ToArray();

    var name = tokens[0];
    var language = tokens[1];

    if(language == "banned" && students.ContainsKey(name))
    {
        students.Remove(name);
        continue;
    }
    if (language == "banned" && !students.ContainsKey(name))
    {
        continue;
    }

    var points = int.Parse(tokens[2]);

if (!students.ContainsKey(name) || students[name] < points)
    students[name] = points;

    if (!technology.ContainsKey(language))
    {
        technology[language] = 0;
    }
    technology[language]++;
}

Console.WriteLine("Results:");
foreach (var student in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{student.Key} | {student.Value}");
}

Console.WriteLine("Submissions:");
foreach (var tech in technology.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{tech.Key} - {tech.Value}");
}