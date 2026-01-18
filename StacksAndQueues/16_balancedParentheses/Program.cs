var input = Console.ReadLine();
var stack = new Stack<char>(input.Substring(input.Length / 2));
var queue = new Queue<char>(input.Substring(0, input.Length - stack.Count));

var invalid = false;

for (int i = 0; i < queue.Count; i++)
{
    var currentQueueElement = queue.Dequeue();
    var currentStackElement = stack.Pop();

    if (currentQueueElement == '(' && currentStackElement == ')'
    || currentQueueElement == '{' && currentStackElement == '}'
    || currentQueueElement == '[' && currentStackElement == ']')
    {
        continue;
    }
    else
    {
        Console.WriteLine("NO");
        invalid = true;
        break;
    }
}

if (!invalid)
{
        Console.WriteLine("YES");
}