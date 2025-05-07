using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTasks.Model;
using System.Windows.Forms;

namespace iTasks.Controller
{
    internal class ControllerDetalhesTarefa
    {
        public void saveData(Tarefa tarefa)
        {
            using (var db = new DBContext())
            {
                db.Tarefas.Add(tarefa);
                db.SaveChanges();
            }
        }
    }
}
