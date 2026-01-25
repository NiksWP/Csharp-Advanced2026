var size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[size[0], size[1]];
var max = int.MinValue;
var startRow = 0;
var startCol = 0;

for (int row = 0; row < size[0]; row++)
{
    var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < size[1]; col++)
    {
        matrix[row,col] = input[col];
    }
}

for (int row = 0; row < size[0] - 1; row++)
{
    for (int col = 0; col < size[1] - 1; col++)
    {
        int sum = 0;
        for (int roww = row; roww < row + 2; roww++)
        {
            for (int coll = col; coll < col + 2; coll++)
            {
                sum+= matrix[roww, coll];
            }
            if (sum > max)
            {
                max = sum;
                startRow = row;
                startCol = col;
            }
        }
    }
}

for (int row = startRow; row < startRow + 2; row++)
{
    for (int col = startCol; col < startCol + 2; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(max);