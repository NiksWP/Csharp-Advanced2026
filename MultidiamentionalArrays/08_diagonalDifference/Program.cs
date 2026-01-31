var size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

var firstDiagonal = 0;
var secondDiagonal = 0;


for (int row = 0; row < size; row++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = input[col];
    }
}

for (int i = 0; i < size; i++)
{
    firstDiagonal += matrix[i, i];
}

for (int row = 0; row < size; row++)
{
    var value = matrix[row, size - row - 1];
    secondDiagonal += value;
}

Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
// Console.WriteLine(firstDiagonal + " " + secondDiagonal);


// for (int row = 0; row < size; row++)
// {
//     for (int col = 0; col < size; col++)
//     {
//         Console.Write(matrix[row, col] + " ");
//     }
//     Console.WriteLine();
// }