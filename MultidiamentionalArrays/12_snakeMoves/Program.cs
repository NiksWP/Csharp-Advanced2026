using System.ComponentModel.Design.Serialization;
using Microsoft.VisualBasic;

var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
char[,] matrix = new char[size[0], size[1]];
var queue = new Queue<char>(Console.ReadLine());

for (int row = 0; row < matrix.GetLength(0); row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            queue.Enqueue(queue.Peek());
            matrix[row, col] = queue.Dequeue();
        }
    }
    else
    {
        for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
        {
            queue.Enqueue(queue.Peek());
            matrix[row,col] = queue.Dequeue();
        }
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row,col]);
    }
    Console.WriteLine();
}
