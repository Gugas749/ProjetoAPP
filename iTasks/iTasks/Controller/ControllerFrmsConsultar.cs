using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTasks.Model;

namespace iTasks.Controller
{
    internal class ControllerFrmsConsultar
    {
        public List<Tarefa> GetTarefas()
        {
            List<Tarefa> tarefas = new List<Tarefa> ();
            using (var db = new DBContext())
            {
                try
                {
                    tarefas = db.Tarefas.ToList();
                }
                catch
                {

                }
            }
            return tarefas;
        }
    }
}
