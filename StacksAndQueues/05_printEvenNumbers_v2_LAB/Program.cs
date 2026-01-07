Queue<int> queue = [];
Console.WriteLine(string.Join(", ", queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray().Where(x => x % 2 == 0))));