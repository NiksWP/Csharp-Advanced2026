var input = Console.ReadLine()
        .Split(", ")
            .Select(int.Parse)
                .Where(x => x % 2 == 0)
                    .ToArray();

Console.WriteLine(string.Join(", ", input.OrderBy(x => x)));

