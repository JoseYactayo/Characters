using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace Rol
{
    class Wizard : Class
    {

        public Wizard(string name) : base(name)
        {
        }

        public override string Clase()
        {
            string clase = "Wizard";
            
            return clase;
        }
    }
}
