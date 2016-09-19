using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel_week1
{
    class Owner
    { 
        public string Name { get; private set; }
        public string Address { get; private set; }

        public Owner(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
