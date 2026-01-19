var value = int.Parse(Console.ReadLine());
var window = int.Parse(Console.ReadLine());
int passed = 0;

var queue = new Queue<string>();

// 10
// 5


// Mercedes
// Hummer
// green
// Hummer
// Mercedes
// green
// END

string input;
while ((input = Console.ReadLine()) != "END")
{
    if (input == "green")
    {
        int green = value;
        if (!queue.Any())
        {
            continue;
        }



        while (queue.Count > 0 && green > 0)
        {
            var car = queue.Dequeue();
            if (car.Length == green)
            {
                passed++;
                green = 0;
            }
            else if (car.Length < green)
            {
                passed++;
                green -= car.Length;
            }
            else if (car.Length > green)
            {
                if (car.Length == green + window)
                {
                    passed++;
                    green = 0;
                }
                else if (car.Length < green + window)
                {
                    passed++;
                    green = 0;
                }
                else if (car.Length > green + window)
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{car} was hit at {car[green + window]}.");
                    return;
                }
            }
        }
    }
    else
    {
        queue.Enqueue(input);
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passed} total cars passed the crossroads.");