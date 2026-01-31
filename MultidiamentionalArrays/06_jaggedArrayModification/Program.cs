var rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];

for (int i = 0; i < rows; i++)
{
    var col = Console.ReadLine().Split().Select(int.Parse).ToArray();
    matrix[i] = new int[col.Length];
    for (int j = 0; j < col.Length; j++)
    {
        matrix[i][j] = col[j];
    }

}

string input;
while ((input = Console.ReadLine()) != "END")
{
    var tokens = input.Split();
    var command = tokens[0];
    var row = int.Parse(tokens[1]);
    var col = int.Parse(tokens[2]);
    var value = int.Parse(tokens[3]);

    if (row < 0 || row >= rows || col < 0 || col >= matrix[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }

    if (command == "Add")
    {
     matrix[row][col] += value;   
    }
    else if (command == "Subtract")
    {
        matrix[row][col] -= value;
    }
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine(String.Join(" ", matrix[i]));
}