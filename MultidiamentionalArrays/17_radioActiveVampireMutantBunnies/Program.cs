var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
char[,] lair = new char[size[0], size[1]];

var playerRow = -1;
var playerCol = -1;

for (int row = 0; row < lair.GetLength(0); row++)
{
    var input = Console.ReadLine();
    for (int col = 0; col < lair.GetLength(1); col++)
    {
        lair[row, col] = input[col];
        if (lair[row, col] == 'P')
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

int[,] moves =
{
    {-1, 0},
    {1, 0},
    {0, -1},
    {0, 1}
};

Queue<char> directions = new Queue<char>(Console.ReadLine());

bool won = false;
bool lose = false;
while (directions.Any())
{
    var direction = directions.Dequeue();
    if (direction == 'U')
    {
        if (playerRow - 1 < 0)
        {
            won = true;
            lair[playerRow, playerCol] = '.';
        }
        else if (lair[playerRow - 1, playerCol] == 'B')
        {
            lose = true;
            playerRow--;
        }
        else if (lair[playerRow - 1, playerCol] == '.')
        {
            lair[playerRow, playerCol] = '.';
            lair[playerRow - 1, playerCol] = 'P';
            playerRow--;
        }
    } // ^ MOVING UP
    else if (direction == 'D')
    {
        if (playerRow + 1 >= lair.GetLength(0))
        {
            won = true;
            lair[playerRow, playerCol] = '.';
        }
        else if (lair[playerRow + 1, playerCol] == 'B')
        {
            lose = true;
            playerRow++;
        }
        else if (lair[playerRow + 1, playerCol] == '.')
        {
            lair[playerRow, playerCol] = '.';
            lair[playerRow + 1, playerCol] = 'P';
            playerRow++;
        }
    } // ^ MOVING DOWN)
    else if (direction == 'L')
    {
        if (playerCol - 1 < 0)
        {
            won = true;
            lair[playerRow, playerCol] = '.';
        }
        else if (lair[playerRow, playerCol - 1] == 'B')
        {
            lose = true;
            playerCol--;
        }
        else if (lair[playerRow, playerCol - 1] == '.')
        {
            lair[playerRow, playerCol] = '.';
            lair[playerRow, playerCol - 1] = 'P';
            playerCol--;
        }
    } // MOVING LEFT <----
    else if (direction == 'R')
    {
        if (playerCol + 1 >= lair.GetLength(1))
        {
            won = true;
            lair[playerRow, playerCol] = '.';
        }
        else if (lair[playerRow, playerCol + 1] == 'B')
        {
            lose = true;
            playerCol++;
        }
        else if (lair[playerRow, playerCol + 1] == '.')
        {
            lair[playerRow, playerCol] = '.';
            lair[playerRow, playerCol + 1] = 'P';
            playerCol++;
        }
    } // MOVING RIGHT -->

    if (won)
    {
        Reproduce(lair, moves, out bool dead, out int deadRow, out int deadCol);
        for (int row= 0; row < lair.GetLength(0); row++)
        {
            for (int col = 0; col < lair.GetLength(1); col++)
            {
                Console.Write(lair[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine($"won: {playerRow} {playerCol}");
        break;
    }
    if (lose)
    {
        Reproduce(lair, moves, out bool dead, out int deadRow, out int deadCol);
        for (int row= 0; row < lair.GetLength(0); row++)
        {
            for (int col = 0; col < lair.GetLength(1); col++)
            {
                Console.Write(lair[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine($"dead: {playerRow} {playerCol}");
        break;
    }
    else
    {
         Reproduce(lair, moves, out bool dead, out int deadRow, out int deadCol);
         if (dead == true)
        {
        for (int row= 0; row < lair.GetLength(0); row++)
        {
            for (int col = 0; col < lair.GetLength(1); col++)
            {
                Console.Write(lair[row, col]);
            }
            Console.WriteLine();
        }
         Console.WriteLine($"dead: {playerRow} {playerCol}");
         break;
        }
    }
}


static void Reproduce(char[,] lair, int[,] moves, out bool dead, out int deadRow, out int deadcol)
{

    dead = false;
    deadRow = -1;
    deadcol = -1;

    var toFill = new List<(int r, int c)>();

    for (int row = 0; row < lair.GetLength(0); row++)
    {
        for (int col = 0; col < lair.GetLength(1); col++)
        {
            if(lair[row, col] != 'B')continue;

            for (int i = 0; i < moves.GetLength(0); i++)
            {
                int nextRow = row + moves[i, 0], nextCol = col + moves[i, 1];
                if (nextRow < 0 || nextRow >= lair.GetLength(0) ||
                nextCol < 0 || nextCol >= lair.GetLength(1))
                {
                    continue;
                }
                if (lair[nextRow, nextCol] == 'P')
                {
                    dead = true;
                    deadRow = nextRow;
                    deadcol = nextCol;
                }
                toFill.Add((nextRow, nextCol));
            }
        }
    }

    foreach (var bunny in toFill)
    {
        lair[bunny.r, bunny.c] = 'B';
    }
}