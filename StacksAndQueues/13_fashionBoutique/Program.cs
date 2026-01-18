var clothing = Console.ReadLine().Split().Select(int.Parse).ToArray();
var stack = new Stack<int>(clothing);

var capacity = int.Parse(Console.ReadLine());
var sum = 0;
var numberOfRacks = 1;

while (stack.Any())
{
    int currentCloth = stack.Pop();

    if (sum + currentCloth <= capacity)
    {
        sum += currentCloth;
    }
    else
    {
        numberOfRacks++;
        sum = currentCloth;
    }
}

Console.WriteLine(numberOfRacks);