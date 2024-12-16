using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Oppgave2_Switch
{
    internal class Week
    {
        public int dayInput;
        public void Run()
        {
            Console.WriteLine("Give a value from 1 to 7 to find out what day of the week it is");
            dayInput = Convert.ToInt32(Console.ReadLine());
            FindDay();
        }
        void FindDay()
        {
            switch (dayInput)
            {
                case 1:
                    Console.WriteLine("it's Monday");
                    break;
                case 2:
                    Console.WriteLine("it's Tuesday");
                    break;
                case 3:
                    Console.WriteLine("it's Wednesday");
                    break;
                case 4:
                    Console.WriteLine("it's Thursday");
                    break;
                case 5:
                    Console.WriteLine("it's Friday");
                    break;
                case 6:
                    Console.WriteLine("it's Saturday");
                    break;
                case 7:
                    Console.WriteLine("it's Sunday");
                    break;
                default:
                    Console.WriteLine("Try again!");
                    Run();
                    break;
            }
        }
    }
}
