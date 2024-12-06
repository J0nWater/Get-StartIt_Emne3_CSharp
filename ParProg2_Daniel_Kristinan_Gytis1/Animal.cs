using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg2_Daniel_Kristinan_Gytis1
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public int Petting { get; set; }
        public int ToiletTime { get; set; }

        public void ChooseAnimal()
        {
            Console.WriteLine($"Choose your pet \n 1:{Name}");
        }
    }
}
