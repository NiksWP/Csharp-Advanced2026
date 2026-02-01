var n = int.Parse(Console.ReadLine());
bool[,] matrix = new bool[n, n];

for (int row = 0; row < n; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = (input[col] == 'K');
    }
}

int[,] moves = {
     {1, 2},
     {1, -2},
     {-1, 2},
     {-1, -2},
     {2, 1},
     {2, -1},
     {-2, 1},
     {-2, -1}
};

var count = 0;
var checkForConflicts = true;
while (checkForConflicts)
{
    int maxConflicts = 0, maxRow = -1, maxCol = -1;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (!matrix[row, col]) continue;

            int conflicts = CountConflicts(matrix, row, col);
            if (conflicts > maxConflicts)
            {
                maxConflicts = conflicts;
                maxRow = row;
                maxCol = col;
            }
        }
    }
    if (maxConflicts == 0)
    {
        checkForConflicts = false;
    }
    else
    {
        matrix[maxRow, maxCol] = false;
        count++;
    }
}

Console.WriteLine(count);


int CountConflicts(bool[,] matrix, int row, int col)
{
    int count = 0;
    for (int i = 0; i < moves.GetLength(0); i++)
    {
        int nextRow = row + moves[i, 0], nextCol = col + moves[i, 1];
        if (nextRow < 0 || nextRow >= matrix.GetLength(0) || nextCol < 0 || nextCol >= matrix.GetLength(1))
        {
            continue;
        }

        if (matrix[nextRow, nextCol] == true)
        {
            count++;
        }
    }
    return count;
}