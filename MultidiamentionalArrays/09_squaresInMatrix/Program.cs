var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
char[,] matrix = new char[size[0], size[1]];
var count = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string input = Console.ReadLine().Replace(" ", "");
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

for (int row = 1; row < matrix.GetLength(0); row++)
{
    for (int col = 1; col < matrix.GetLength(1); col++)
    {
        var value = matrix[row, col];
        if (value == matrix[row, col -1] && value == matrix[row - 1, col -1]
            && value == matrix[row - 1, col])
        {
            count++;
        }
    }
}

Console.WriteLine(count);