string input = Console.ReadLine();
var stack = new Stack<char>();

foreach (var letter in input)
{
    if (letter == '[' || letter == '{' || letter == '(')
    {
        stack.Push(letter);
    }
    else
    {
        if (!stack.Any())
        {
            Console.WriteLine("NO");
            return;
        }
        var open = stack.Pop();

        bool matched = (open == '[' && letter == ']' ||
                      open == '{' && letter == '}' ||
                      open == '(' && letter == ')');

        if (matched == false)
        {
            Console.WriteLine("NO");
            return;
        }
    }
}

if (!stack.Any())
{
    Console.WriteLine("YES");
}