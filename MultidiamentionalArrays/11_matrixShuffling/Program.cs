var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
string[,] matrix = new string[size[0], size[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    var line = Console.ReadLine().Split(new[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = line[col];
    }
}

string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split();
    bool areNumbers = tokens.Skip(1).All(x => int.TryParse(x, out _));
    if (tokens[0] != "swap" || tokens.Length != 5 || areNumbers == false)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    var coordinates = tokens.Skip(1).Select(int.Parse).ToArray();

    var firstElementRow = coordinates[0];
    var firstElementCol = coordinates[1];
    var secondelementRow = coordinates[2];
    var secondElementCol = coordinates[3];

    if (firstElementRow < 0 || firstElementRow >= matrix.GetLength(0) ||
        firstElementCol < 0 || firstElementCol >= matrix.GetLength(1) ||
        secondelementRow < 0|| secondelementRow >= matrix.GetLength(0) ||
        secondElementCol < 0 || secondElementCol >= matrix.GetLength(1))
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    var temp = matrix[firstElementRow, firstElementCol];
    matrix[firstElementRow, firstElementCol] = matrix[secondelementRow, secondElementCol];
    matrix[secondelementRow, secondElementCol] = temp;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}
