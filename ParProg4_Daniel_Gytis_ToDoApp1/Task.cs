using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg4_Daniel_Gytis_ToDoApp1
{
    internal class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Task(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
