using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel_week1
{
    class Cat:Animal
    {
        public string Behaviour;

        public Cat(string behaviour, string name, int birthyear, string race, bool isReserved):base(name,birthyear,race,isReserved)
        {
            this.Behaviour = behaviour;
        }

        public override string ToString()
        {
            if(isReserved == true) {

                return $"Naam: {Name} Gedrag {Behaviour} is gereserveerd";
            }

            else
            {

                return $"Naam: {Name} Gedrag {Behaviour} is niet gereserveerd";
            }
        }

    }
}
