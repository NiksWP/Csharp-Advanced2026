using System;
using System.Collections.Generic;
using System.Linq;

int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = size[0], cols = size[1];

char[,] lair = new char[rows, cols];
int pr = -1, pc = -1;

for (int r = 0; r < rows; r++)
{
    string line = Console.ReadLine();
    for (int c = 0; c < cols; c++)
    {
        lair[r, c] = line[c];
        if (lair[r, c] == 'P') { pr = r; pc = c; }
    }
}

Queue<char> dirs = new Queue<char>(Console.ReadLine());

int[,] moves =
{
    {-1, 0},
    { 1, 0},
    { 0,-1},
    { 0, 1}
};

while (dirs.Any())
{
    char d = dirs.Dequeue();

    int dr = 0, dc = 0;
    switch (d)
    {
        case 'U': dr = -1; break;
        case 'D': dr = 1; break;
        case 'L': dc = -1; break;
        case 'R': dc = 1; break;
    }

    int nr = pr + dr;
    int nc = pc + dc;

    // махаме P от текущата клетка (той "тръгва")
    lair[pr, pc] = '.';

    bool won = nr < 0 || nr >= rows || nc < 0 || nc >= cols;
    bool deadByMove = false;

    if (!won)
    {
        if (lair[nr, nc] == 'B') deadByMove = true;
        else lair[nr, nc] = 'P';

        pr = nr; pc = nc;
    }

    Reproduce(lair, moves, out bool deadByBunnies, out int deadR, out int deadC);

    if (won)
    {
        Print(lair);
        Console.WriteLine($"won: {pr} {pc}");
        return;
    }

    if (deadByMove)
    {
        Print(lair);
        Console.WriteLine($"dead: {pr} {pc}");
        return;
    }

    if (deadByBunnies)
    {
        Print(lair);
        Console.WriteLine($"dead: {deadR} {deadC}");
        return;
    }
}

static void Reproduce(char[,] lair, int[,] moves, out bool dead, out int deadRow, out int deadCol)
{
    dead = false;
    deadRow = -1;
    deadCol = -1;

    int rows = lair.GetLength(0);
    int cols = lair.GetLength(1);

    var toFill = new List<(int r, int c)>();

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
        {
            if (lair[r, c] != 'B') continue;

            for (int i = 0; i < moves.GetLength(0); i++)
            {
                int nr = r + moves[i, 0];
                int nc = c + moves[i, 1];

                if (nr < 0 || nr >= rows || nc < 0 || nc >= cols) continue;

                if (lair[nr, nc] == 'P')
                {
                    dead = true;
                    deadRow = nr;
                    deadCol = nc;
                }

                toFill.Add((nr, nc));
            }
        }
    }

    foreach (var (r, c) in toFill)
        lair[r, c] = 'B';
}

static void Print(char[,] lair)
{
    for (int r = 0; r < lair.GetLength(0); r++)
    {
        for (int c = 0; c < lair.GetLength(1); c++)
            Console.Write(lair[r, c]);
        Console.WriteLine();
    }
}