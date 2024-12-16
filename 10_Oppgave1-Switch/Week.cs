using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Oppgave1_Switch
{
    internal class Week
    {
        int day = 3;

        public void FindDay()
        {
            switch (day)
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

            }

        }
    }
}
