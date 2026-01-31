using System.Numerics;

var size = int.Parse(Console.ReadLine());
BigInteger[][] matrix = new BigInteger[size][];


if (size == 1)
{
    matrix[0] = new BigInteger[1]{1};
    Console.WriteLine(1);
    return;
}
else if(size == 0)
{
    return;
}

matrix[0] = new BigInteger[1]{1};
matrix[1] = new BigInteger[2]{1, 1};

for (int row = 2; row < size; row++)
{
    matrix[row] = new BigInteger[row + 1];
    
    for (int col = 0; col < row + 1; col++)
    {
        if (col == 0 || col == row)
        {
            matrix[row][col] = 1;
            continue;
        }
        matrix[row][col] = matrix[row - 1][col] + matrix[row - 1][col - 1];
    }
}

for (int row = 0; row < size; row++)
{
    Console.WriteLine(string.Join(" ", matrix[row]));
}