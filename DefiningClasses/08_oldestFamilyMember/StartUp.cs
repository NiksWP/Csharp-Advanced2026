namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                
                family.AddMembers(new Person(name, age));
            }

            Console.WriteLine(family.GetOldestPerson());
        }
    }
}