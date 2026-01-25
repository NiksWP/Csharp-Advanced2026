var size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];
var sum = 0;

for (int row = 0; row < size; row++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row,col] = input[col];
    }
}

for (int i = 0; i < size; i++)
{
    sum += matrix[i, i];
}

Console.WriteLine(sum);