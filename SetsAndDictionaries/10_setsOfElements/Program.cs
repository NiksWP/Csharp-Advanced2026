var lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = lengths[0], m = lengths[1];

var nSet = new HashSet<int>();
var mSet = new HashSet<int>();
var list = new List<int>();

for (int i = 0; i < n; i++)
{
    var num = int.Parse(Console.ReadLine());
    nSet.Add(num);
}

for (int i = 0; i < m; i++)
{
    var num = int.Parse(Console.ReadLine());
    mSet.Add(num);
}

foreach (var num in nSet)
{
    if (mSet.Contains(num))
    {
        list.Add(num);
    }
}

Console.WriteLine(string.Join(" ", list));