using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTasks.Model;

namespace iTasks.Controller
{
    internal class ControllerFormTarefaGestor
    {
        public List<TarefaGestor> GetTarefas(Gestor user)
        {
            List<TarefaGestor> Tarefas = new List<TarefaGestor>();
            using (var db = new DBContext())
            {
                try
                {
                    List<TarefaGestor> aux = new List<TarefaGestor>();
                    aux = db.TarefasGestors.ToList();
                    foreach (TarefaGestor a in aux)
                    {
                        if(a.IdGestor == user.Id)
                        {
                            Tarefas.Add(a);
                        }
                    }
                }
                catch
                {

                }
            }
            return Tarefas;
        }
        public int saveData(TarefaGestor Tarefa)
        {
            int response = 0;

            using (var db = new DBContext())
            {
                try
                {
                    db.TarefasGestors.Add(Tarefa);
                    db.SaveChanges();
                    response = 1;
                }
                catch (Exception ex)
                {

                }
            }

            return response;
        }
        public int TerminarTarefa(TarefaGestor Tarefa)
        {
            int response = 0;

            using (var db = new DBContext())
            {
                try
                {
                    db.Entry(Tarefa).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    response = 1;
                }
                catch (Exception ex)
                {

                }
            }

            return response;
        }
    }
}
