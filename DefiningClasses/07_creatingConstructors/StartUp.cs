namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Person person = new Person();
            person.Name = "niki";
            person.Age = 21;

            Person person1 = new Person();

            Person person2 = new Person(12);

            Person person3 = new Person("Pesho", 12);

            Console.WriteLine();
        }
    }
}