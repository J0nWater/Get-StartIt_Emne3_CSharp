using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Oppgave_Random_Hobby_Generator
{
    internal class App
    {
        string userName;
        public void Run()
        {
            Console.WriteLine("Who would like a new hobby?");
            userName = Console.ReadLine();
            GetRandomHobby();
        }
        void GetRandomHobby()
        {
            Random rand = new Random();
            var randomHobby = rand.Next(0, 4);
            if (randomHobby == 0)
            {
                Console.WriteLine($"{userName} is now an amateur astronomer. Eyes on the skies!\n");
                Run();
            }
            else if (randomHobby == 1)
            {
                Console.WriteLine($"{userName} is now a classic literature enthusiast. Lost in the pages.\n");
                Run();
            }
            else if (randomHobby == 2)
            {
                Console.WriteLine($"{userName} is now a classical pianist. Creating melodies for the soul.\n");
                Run();
            }
            else if (randomHobby == 3)
            {
                Console.WriteLine($"{userName} is now a marathon runner. Breaking personal records!\n");
                Run();
            }
        }
    }
}
