using System.Data;

var size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size,size];

for (int row = 0; row < size; row++)
{
    var input = Console.ReadLine().ToCharArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = input[col];
    }
}

char wanted = Console.ReadLine()[0];

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] == wanted)
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}

Console.WriteLine($"{wanted} does not occur in the matrix");