string input;
var site = new Dictionary<string, (HashSet<string> followers, HashSet<string> following)>();
var count = 0;

while ((input = Console.ReadLine()) != "Statistics")
{
    var tokens = input.Split().ToArray();
    var command = tokens[1];

    if (command == "joined")
    {
        var vlogger = tokens[0];
        if (!site.ContainsKey(vlogger))
        {
            site[vlogger] = (new HashSet<string>(), new HashSet<string>());
            count++;
        }
    }
    else if (command == "followed")
    {
        var vlogger1 = tokens[0];
        var vlogger2 = tokens[2];

        if (!site.ContainsKey(vlogger1) || !site.ContainsKey(vlogger2) || vlogger1 == vlogger2)
        {
            continue;
        }

        site[vlogger2].followers.Add(vlogger1);
        site[vlogger1].following.Add(vlogger2);
    }
    //         var c = 1;
    // foreach (var vlogger in site.OrderByDescending(x => x.Value.followers.Count).ThenBy(x => x.Value.following.Count))
    // {
    //     Console.WriteLine($"{c}. {vlogger.Key} : {vlogger.Value.followers.Count} followers, {vlogger.Value.following.Count} following");
    //     foreach (var follower in vlogger.Value.followers.OrderBy(x => x))
    //     {
    //         Console.WriteLine($"* {follower}");
    //     }
    //     c++;
    //     //break;
    // }
    // Console.WriteLine();
}

Console.WriteLine($"The V-Logger has a total of {count} vloggers in its logs.");
    var c = 1;
foreach (var vlogger in site.OrderByDescending(x => x.Value.followers.Count).ThenBy(x => x.Value.following.Count))
{
    Console.WriteLine($"{c}. {vlogger.Key} : {vlogger.Value.followers.Count} followers, {vlogger.Value.following.Count} following");
    foreach (var follower in vlogger.Value.followers.OrderBy(x => x))
    {
        Console.WriteLine($"*  {follower}");
    }
    c++;
    break;
}

var counter = 2;
foreach (var vlogger in site.OrderByDescending(x => x.Value.followers.Count).ThenBy(x => x.Value.following.Count).Skip(1))
{
   Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.followers.Count} followers, {vlogger.Value.following.Count} following"); 
   counter++;
}