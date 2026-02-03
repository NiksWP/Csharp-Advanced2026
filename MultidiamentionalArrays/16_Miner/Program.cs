using System.Numerics;

var size = int.Parse(Console.ReadLine());
var commands = new Queue<string>(Console.ReadLine().Split().ToArray());
char[,] mine = new char[size, size];

int minerRow = -2, minerCol = -2;
int endRow = -1, endCol = -1;

var collectedCoals = 0;

for (int row = 0; row < size; row++)
{
    var input = Console.ReadLine().Split().ToArray();
    for (int col = 0; col < size; col++)
    {
        mine[row, col] = input[col][0];
        if (mine[row, col] == 's')
        {
            minerRow = row; minerCol = col;
        }
        else if (mine[row, col] == 'e')
        {
            endRow = row; endCol = col;
        }
    }
}
var coalQuantity = mine.Cast<char>().Count(x => x == 'c');

bool end = false;
while (commands.Any())
{
    var direction = commands.Dequeue();

    if (direction == "up")
    {
        if (minerRow - 1 < 0) continue;
        if (mine[minerRow - 1, minerCol] == '*')
        {
            mine[minerRow - 1, minerCol] = 's';
            mine[minerRow, minerCol] = '*';
            minerRow--;
        }
        else if (mine[minerRow - 1, minerCol] == 'c')
        {
            collectedCoals++;
            mine[minerRow - 1, minerCol] = 's';
            mine[minerRow, minerCol] = '*';
            minerRow--;

            if (collectedCoals == coalQuantity)
            {
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                end = true;
            }
        }
        else if (mine[minerRow - 1, minerCol] == 'e')
        {
            minerRow--;
            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
            end = true;
        }
    }
    else if (direction == "down")
    {
        if (minerRow + 1 >= mine.GetLength(0)) continue;
        if (mine[minerRow + 1, minerCol] == '*')
        {
            mine[minerRow + 1, minerCol] = 's';
            mine[minerRow, minerCol] = '*';
            minerRow++;
        }
        else if (mine[minerRow + 1, minerCol] == 'c')
        {
            collectedCoals++;
            mine[minerRow + 1, minerCol] = 's';
            mine[minerRow, minerCol] = '*';
            minerRow++;

            if (collectedCoals == coalQuantity)
            {
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                end = true;
            }
        }
        else if (mine[minerRow + 1, minerCol] == 'e')
        {
            minerRow++;
            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
            end = true;
        }

    }
    else if (direction == "left")
    {
        if (minerCol - 1 < 0) continue;
        if (mine[minerRow, minerCol - 1] == '*')
        {
            mine[minerRow, minerCol - 1] = 's';
            mine[minerRow, minerCol] = '*';
            minerCol--;
        }
        else if (mine[minerRow, minerCol - 1] == 'c')
        {
            collectedCoals++;
            mine[minerRow, minerCol - 1] = 's';
            mine[minerRow, minerCol] = '*';
            minerCol--;

            if (collectedCoals == coalQuantity)
            {
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                end = true;
            }
        }
        else if (mine[minerRow, minerCol - 1] == 'e')
        {
            minerCol--;
            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
            end = true;
        }

    }
    else if (direction == "right")
    {
        if (minerCol + 1 >= mine.GetLength(1)) continue;
        if (mine[minerRow, minerCol + 1] == '*')
        {
            mine[minerRow, minerCol + 1] = 's';
            mine[minerRow, minerCol] = '*';
            minerCol++;
        }
        else if (mine[minerRow, minerCol + 1] == 'c')
        {
            collectedCoals++;
            mine[minerRow, minerCol + 1] = 's';
            mine[minerRow, minerCol] = '*';
            minerCol++;

            if (collectedCoals == coalQuantity)
            {
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                end = true;
            }
        }
        else if (mine[minerRow, minerCol + 1] == 'e')
        {
            minerCol++;
            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
            end = true;
        }
    }
}

if (end == false)
{
    Console.WriteLine($"{coalQuantity - collectedCoals} coals left. ({minerRow}, {minerCol})");
}



// static void Move(char[,] mine,int coalQuantity, int collectedCoals, int endRow, int endCol, int minerRow, int minerCol, string direction)
// {
//     if (direction == "up")
//     {
//         if(minerRow - 1 < 0)return;
//         if (mine[minerRow - 1, minerCol] == '*')
//         {
//             mine[minerRow - 1, minerCol] = 's';
//             mine[minerRow, minerCol] = '*';
//             minerRow--;
//         }
//         else if (mine[minerRow - 1, minerCol] == 'c')
//         {
//             collectedCoals++;
//             mine[minerRow - 1, minerCol] = 's';
//             mine[minerRow, minerCol] = '*';
//             minerRow--;

//             if (collectedCoals == coalQuantity)
//             {
//                 Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
//             }
//         }
//         else if (mine[minerRow - 1, minerCol] == 'e')
//         {
//             minerRow--;
//             Console.WriteLine($"Game Over! ({minerRow}, {minerCol})");
//         }
//     }
//     else if (direction == "down")
//     {
//         if(minerRow + 1 >= mine.GetLength(0))return;
//         if (mine[minerRow + 1, minerCol] == '*')
//         {
//             mine[minerRow + 1, minerCol] = 's';
//             mine[minerRow, minerCol] = '*';
//             minerRow++;
//         }
//         else if (mine[minerRow + 1, minerCol] == 'c')
//         {
//             collectedCoals++;
//             mine[minerRow + 1, minerCol] = 's';
//             mine[minerRow, minerCol] = '*';
//             minerRow++;

//             if (collectedCoals == coalQuantity)
//             {
//                 Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
//             }
//         }
//         else if (mine[minerRow + 1, minerCol] == 'e')
//         {
//             minerRow++;
//             Console.WriteLine($"Game Over! ({minerRow}, {minerCol})");
//         }

//     }
//     else if (direction == "left")
//     {
//         if(minerCol - 1 < 0)return;
//         if (mine[minerRow, minerCol - 1] == '*')
//         {
//             mine[minerRow, minerCol - 1] = 's';
//             mine[minerRow, minerCol] = '*';
//             minerCol--;
//         }
//         else if (mine[minerRow, minerCol - 1] == 'c')
//         {
//             collectedCoals++;
//             mine[minerRow, minerCol - 1] = 's';
//             mine[minerRow, minerCol] = '*';
//             minerCol--;

//              if (collectedCoals == coalQuantity)
//             {
//                 Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
//             }
//         }
//         else if (mine[minerRow, minerCol - 1] == 'e')
//         {
//             minerCol--;
//             Console.WriteLine($"Game Over! ({minerRow}, {minerCol})");
//         }

//     }
//     else if (direction == "right")
//     {
//         if (minerCol + 1 >= mine.GetLength(1))return;
//         if (mine[minerRow, minerCol + 1] == '*')
//         {
//             mine[minerRow, minerCol + 1] = 's';
//             mine[minerRow, minerCol] = '*';
//             minerCol++;
//         }
//         else if (mine[minerRow, minerCol + 1] == 'c')
//         {
//             collectedCoals++;
//             mine[minerRow, minerCol + 1] = 's';
//             mine[minerRow, minerCol] = '*';
//             minerCol++;

//             if (collectedCoals == coalQuantity)
//             {
//                 Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
//             }
//         }
//         else if (mine[minerRow, minerCol + 1] == 'e')
//         {
//             minerCol++;
//             Console.WriteLine($"Game Over! ({minerRow}, {minerCol})");
//         }
//     }
// }