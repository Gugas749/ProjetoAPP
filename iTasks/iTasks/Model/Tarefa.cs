using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Model
{
    class Tarefa
    {
        [Key]
        public int Id { get; set; }
        public int IdGestor { get; set; } // FOREIGN KEY -> Gestor -> Utilizador(Id)
        public int IdProgramador { get; set; } // FOREIGN KEY -> Programador -> Utilizador(Id)
        public int OrdemExecucao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPrevistaInicio { get; set; }
        public DateTime DataPrevistaFim { get; set; }
        public int IdTipoTarefa { get; set; } // FOREIGN KEY -> TipoTarefa -> TipoTarefa(Id)
        public int StoryPoints { get; set; }
        public DateTime DataRealInicio { get; set; }
        public DateTime DataRealFim { get; set; }
        public DateTime DataCriacao { get; set; }
        public EstadoAtual EstadoAtual { get; set; }
    }
}
