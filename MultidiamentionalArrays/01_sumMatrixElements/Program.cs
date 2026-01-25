var dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[dimensions[0], dimensions[1]];
var sum = 0;

for (int rows = 0; rows < dimensions[0]; rows++)
{
    var col = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int cols = 0; cols < dimensions[1]; cols++)
    {
        matrix[rows, cols] = col[cols];
        sum += matrix[rows,cols];
    }
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);

// for (int row = 0; row < matrix.GetLength(0); row++)
// {
//     for (int col = 0; col < matrix.GetLength(1); col++)
//     {
//         Console.Write(matrix[row,col] + " ");
//     }
//     Console.WriteLine();
// }

