var numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
Console.WriteLine(numbers.Count());
Console.WriteLine(numbers.Sum());