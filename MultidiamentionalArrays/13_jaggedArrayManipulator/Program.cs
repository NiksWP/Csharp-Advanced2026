using System.Security.Cryptography.X509Certificates;

var rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    matrix[row] = new int[input.Length];
    for (int col = 0; col < input.Length; col++)
    {
        matrix[row][col] = input[col];
    }
}

for (int row = 0; row < rows - 1; row++)
{
    if (matrix[row].Length == matrix[row + 1].Length)
    {
        matrix[row] = matrix[row].Select(x => x * 2).ToArray();
        matrix[row + 1] = matrix[row + 1].Select(x => x * 2).ToArray();
    }
    else
    {
        matrix[row] = matrix[row].Select(x => x / 2).ToArray();
        matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
    }
}

string inputt;
while ((inputt = Console.ReadLine()) != "End")
{
    var tokens = inputt.Split();

    var areNumbers = tokens.Skip(1).All(x => int.TryParse(x, out _));
    if (tokens.Length != 4 || areNumbers == false || (tokens[0] != "Add" && tokens[0] != "Subtract"))
    {
        continue;
    }

    var command = tokens[0];
    var elementRow = int.Parse(tokens[1]);
    var elementCol = int.Parse(tokens[2]);
    var value = int.Parse(tokens[3]);

    if (elementRow < 0 || elementRow >= matrix.Length
     || elementCol < 0 || elementCol >= matrix[elementRow].Length)
    {
        continue;
    }


    if (command == "Add")
    {
        matrix[elementRow][elementCol] += value;
    }
    if (command == "Subtract")
    {
        matrix[elementRow][elementCol] -= value;
    }
}



foreach (var row in matrix)
{
    Console.WriteLine(string.Join(" ", row));
}