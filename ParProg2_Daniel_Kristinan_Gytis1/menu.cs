using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg2_Daniel_Kristinan_Gytis1
{
    internal class menu
    {
        public menu()
        {
            Animal animal1 = new Animal();
            animal1.Name = "Kevin";
            animal1.Age = 0;
            animal1.Race = "";
            animal1.Petting = 10;
            animal1.ToiletTime = 10;

            Animal animal2 = new Animal();
            animal2.Name = "Frenk";
            animal2.Age = 0;
            animal2.Race = "";
            animal2.Petting = 10;
            animal2.ToiletTime = 10;

            animal1.ChooseAnimal();
            animal2.ChooseAnimal();
        }


    }
}
