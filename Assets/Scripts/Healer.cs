using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rol

{
    class Healer:Class
    {
        public Healer(string name) : base(name)
        {
        }

        public override string Clase()
        {
            string clase = "Healer";

            return clase;
        }
    }
}
