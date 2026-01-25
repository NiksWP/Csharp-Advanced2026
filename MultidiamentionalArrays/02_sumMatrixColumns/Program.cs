var dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[dimensions[0], dimensions[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = input[col];
    }
}

var queue = new Queue<int>();
for (int col = 0; col < matrix.GetLength(1); col++)
{
    var sum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        sum += matrix[row, col];
    }
    queue.Enqueue(sum);
}

foreach (var sum in queue)
{
    Console.WriteLine(sum);
}