using System.Runtime.CompilerServices;

Stack<char> text = new Stack<char>();
var n = int.Parse(Console.ReadLine());
var versions = new Stack<Stack<char>>();

var oldStack = new Stack<char>();

while (n > 0)
{
    var input = Console.ReadLine().Split().ToArray();
    var command = input[0];

    if (command == "1")
    {
        versions.Push(new Stack<char>(text));
        //oldStack = new Stack<char>(text);
        var textToAdd = input[1];

        foreach (var ch in textToAdd)
        {
            text.Push(ch);
        }
    }
    else if (command == "2")
    {
        versions.Push(new Stack<char>(text));
        //oldStack = new Stack<char>(text);
        var toRemove = int.Parse(input[1]);

        for (int i = 0; i < toRemove; i++)
        {
            text.Pop();
        }
    }
    else if (command == "3")
    {
        var index = int.Parse(input[1]);
        var stackArray = text.Reverse().ToArray();
        Console.WriteLine(stackArray.ElementAt(index - 1));
    }
    else if (command == "4")
    {
        text = new Stack<char>(versions.Pop());
        //text = new Stack<char>(versions.Pop().Reverse());
    }

    n--;
}

//Console.WriteLine(String.Join(" ",oldStack));