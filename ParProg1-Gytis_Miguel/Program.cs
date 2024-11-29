namespace ParProg1_Gytis_Miguel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            user gytis = new user();
            gytis.Name = "Gytis";
            gytis.Age = 10;
            gytis.Hobby = "sleep";

            user miguel = new user();
            miguel.Name = "Miguel";
            miguel.Age = 10;
            miguel.Hobby = "eat";

            Console.WriteLine($"My name is {gytis.Name}, I am {gytis.Age} years old, I like to {gytis.Hobby}.");
            Console.WriteLine($"My name is {miguel.Name}, I am {miguel.Age} years old, I like to {miguel.Hobby}.");

        }
    }
}