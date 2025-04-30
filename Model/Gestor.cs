using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Model
{
    class Gestor : Utilizador
    {
        public Departamento Departamento { get; set; }

        public bool GereUtilizadores { get; set; }
    }
}
