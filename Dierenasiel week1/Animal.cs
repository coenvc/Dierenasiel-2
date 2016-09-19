using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel_week1
{
    public abstract class Animal
    {
        public string Name { get; private set; } 
        public int Birthyear { get; private set; } 
        public string Race { get; private set; } 
        public bool isReserved { get; private set; }

        public Animal(string name, int birthyear, string race, bool isreserved)
        {
            this.Name = name;
            this.Birthyear = birthyear;
            this.Race = race;
            this.isReserved = isReserved;
        }

        public void Reserve()
        {
            isReserved = true;
        }

    }
}
