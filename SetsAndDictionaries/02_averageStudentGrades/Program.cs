var n = int.Parse(Console.ReadLine());
var grades = new Dictionary<string,List<double>>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().ToArray();
    var name = input[0];
    var grade = double.Parse(input[1]);

    if (!grades.ContainsKey(name))
    {
        grades.Add(name, new List<double>());
    }
    grades[name].Add(grade);
}

foreach (var student in grades)
{
    Console.WriteLine($"{student.Key} -> {string.Join(" ", (student.Value.Select(x => x.ToString("F2"))))} (avg: {student.Value.Average():F2})");
}