using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTasks.Model;

namespace iTasks.Controller
{
    internal class ControllerFrmKanban
    {
        public Tarefa updateTarefa(int tarefaId, EstadoAtual estado)
        {
            Tarefa existingTarefa = new Tarefa();
            using (var db = new DBContext())
            {
                List<Tarefa> tarefas = db.Tarefas.ToList();
                foreach(Tarefa ta in tarefas)
                {
                    if(ta.Id == tarefaId)
                    {
                        existingTarefa = ta;
                    }
                }

                if (existingTarefa != null)
                {
                    existingTarefa.EstadoAtual = estado;
                    db.SaveChanges();
                }
            }

            return existingTarefa;
        }
    }
}
