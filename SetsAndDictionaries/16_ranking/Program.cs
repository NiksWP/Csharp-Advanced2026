var contest = new Dictionary<string, string>();
var students = new Dictionary<string, Dictionary<string, int>>();

string input;
while ((input = Console.ReadLine()) != "end of contests")
{
    var tokens = input.Split(':').ToArray();
    var subject = tokens[0];
    var pass = tokens[1];

    if (!contest.ContainsKey(subject))
    {
        contest[subject] = "";
    }
    contest[subject] = pass;
}

string inputt;
while ((inputt = Console.ReadLine()) != "end of submissions")
{
    var tokens = inputt.Split("=>").ToArray();
    var subject = tokens[0];
    if (!contest.ContainsKey(tokens[0]) || contest[tokens[0]] != tokens[1])
    {
        continue;
    }

    var student = tokens[2];
    var points = int.Parse(tokens[3]);
    if (!students.ContainsKey(student))
    {
        students[student] = new Dictionary<string, int>();
    }

    if (!students[student].ContainsKey(subject))
    {
        students[student][subject] = 0;
    }

    if (students[student][subject] < points) students[student][subject] = points;
}

var maxPoints = students.MaxBy(x => x.Value.Values.Sum());

Console.WriteLine($"Best candidate is {maxPoints.Key} with total {maxPoints.Value.Values.Sum()} points.");
Console.WriteLine("Ranking:");
foreach (var student in students.OrderBy(x => x.Key))
{
    Console.WriteLine(student.Key);
    var subjjects = student.Value;
    foreach (var sub in subjjects.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {sub.Key} -> {sub.Value}");
    }
}