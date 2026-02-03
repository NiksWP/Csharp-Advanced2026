var size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];
var sum = 0;
var count = 0;

for (int row = 0; row < size; row++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = input[col];
    }
}
var bombCoordinates = new Queue<string>(Console.ReadLine().Split().ToArray());

int[,] moves =
{
    {-1, -1},
    {-1, 0},
    {-1, 1},
    {0, 1},
    {1, 1},
    {1, 0},
    {1, -1},
    {0, -1}
};

while (bombCoordinates.Any())
{
    var coordinates = bombCoordinates.Dequeue().Split(",").Select(int.Parse).ToArray();
    int bombRow = coordinates[0], bombCol = coordinates[1];

    if (matrix[bombRow, bombCol] > 0)
    {
         Explode(matrix, moves, bombRow, bombCol);   
    }
}

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] > 0)
        {
            count++;
            sum += matrix[row, col];
        }
    }
}

Console.WriteLine($"Alive cells: {count}");
Console.WriteLine($"Sum: {sum}");
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}


static void Explode(int[,] matrix, int[,] moves, int row, int col)
{
    var value = matrix[row, col];
    matrix[row, col] = 0;
    for (int i = 0; i < moves.GetLength(0); i++)
    {
        int nextRow = row + moves[i, 0], nextCol = col + moves[i, 1];

        if (nextRow < 0 || nextRow >= matrix.GetLength(0)
        || nextCol < 0 || nextCol >= matrix.GetLength(1)
        || matrix[nextRow, nextCol] <= 0)
        {
            continue;
        }
        matrix[nextRow, nextCol] -= value;
    }
}