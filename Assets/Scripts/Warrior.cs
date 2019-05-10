using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rol
{
    class Warrior : Class
    {

        public Warrior(string name) : base(name)
        {
        }

        public override string Clase() {
            string clase = "Warrior";
            return clase;
        }
    }
}
