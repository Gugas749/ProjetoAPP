using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Model
{
    class Programador : Utilizador
    {
        public NivelExperiencia NivelExperiencia { get; set; }
        public int IdGestor { get; set; } // FOREIGN KEY -> Gestor -> Utilizador(Id)
        public Gestor Gestor { get; set; } // PERMITE SABER O GESTOR (EX: programador.Gestor.Nome)

        //public Programador(string nome, string username, string password, NivelExperiencia nivelExperiencia, int idGestor, Gestor gestor)
        //    : base(nome, username, password)
        //{
        //    this.NivelExperiencia = nivelExperiencia;
        //    this.IdGestor = idGestor;
        //    this.Gestor = gestor;
        //}
    }
}
