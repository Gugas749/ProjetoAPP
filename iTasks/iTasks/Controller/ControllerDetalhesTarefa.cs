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

        public List<Utilizador> GetUtilizadores()
        {
            List<Utilizador> users = new List<Utilizador>();
            using (var db = new DBContext())
            {
                try
                {
                    users = db.Utilizadores.ToList();
                }
                catch (Exception ex)
                {

                }
            }
            return users;
        }
        public List<TipoTarefa> GetTipoTarefas()
        {
            List<TipoTarefa> users = new List<TipoTarefa>();
            using (var db = new DBContext())
            {
                try
                {
                    users = db.TipoTarefas.ToList();
                }
                catch (Exception ex)
                {

                }
            }
            return users;
        }
        public List<Tarefa> GetTarefas()
        {
            List<Tarefa> users = new List<Tarefa>();
            using (var db = new DBContext())
            {
                try
                {
                    users = db.Tarefas.ToList();
                }
                catch (Exception ex)
                {

                }
            }
            return users;
        }
    }
}
