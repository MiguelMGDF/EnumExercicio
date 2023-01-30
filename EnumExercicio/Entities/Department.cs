using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercicio.Entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department()
        {
            Name = "";
        }

        public Department(string name)
        {
            Name = name;
        }

    }
}
