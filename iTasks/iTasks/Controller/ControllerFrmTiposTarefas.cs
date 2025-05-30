using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTasks.Model;

namespace iTasks.Controller
{
    internal class ControllerFrmTiposTarefas
    {
        public int saveData(TipoTarefa tipoTarefa)
        {
            int response = 0;

            using (var db = new DBContext())
            {
                try
                {
                    db.TipoTarefas.Add(tipoTarefa);
                    db.SaveChanges();
                    response = 1;
                }catch (Exception ex)
                {

                }
            }

            return response;
        }
        public int deleteData(TipoTarefa selected)
        {
            int response = 0;

            using (var db = new DBContext())
            {
                try
                {
                    db.Entry(selected).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    response = 1;
                }
                catch (Exception ex)
                {

                }
            }

            return response;
        }
        public List<TipoTarefa> GetTipoTarefas()
        {
            List<TipoTarefa> tiposTarefas = new List<TipoTarefa>();
            using (var db = new DBContext())
            {
                try
                {
                    tiposTarefas = db.TipoTarefas.ToList();
                }
                catch
                {

                }
            }
            return tiposTarefas;
        }
    }
}
