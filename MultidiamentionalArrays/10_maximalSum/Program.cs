var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[,] matrix = new int[size[0], size[1]];
var maxSum = int.MinValue;
var startRow = 0;
var startCol = 0;

if (size[0] < 3 || size[1] < 3)
{
    Console.WriteLine("0");
    return;
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    var input = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        var currentSum = 0;

        for (int roww = row; roww < row + 3; roww++)
        {
            for (int coll = col; coll < col + 3; coll++)
            {
                currentSum += matrix[roww, coll];
            }
        }
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            startRow = row;
            startCol = col;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");
for (int row = startRow; row < startRow + 3; row++)
{
    for (int col = startCol; col < startCol + 3; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}

