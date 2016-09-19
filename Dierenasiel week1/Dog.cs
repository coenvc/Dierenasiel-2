using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel_week1
{
    public class Dog:Animal
    {
        public DateTime LastWalked;

        public Dog( string name, int birthyear,string race,bool isReserved):base(name,birthyear,race,isReserved)
        {
            
        }

        public void Walk()
        {
            LastWalked = DateTime.Now;

        }

        public override string ToString()
        {
            if (isReserved == false)
            {

                return $"Naam {Name} laatst uitgelaten op{LastWalked}";
            }

            else 
            {
                return $"Naam {Name} laatst uitgelaten op{LastWalked} is gereserveerd";
            }

        }
    }
}
