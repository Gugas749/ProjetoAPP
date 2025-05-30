using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Model;

namespace iTasks.Controller
{
    internal class ControllerFrmGereUtilizadores
    {
        public int savedata(Utilizador info)
        {
            int aux = 0;
            using (var db = new DBContext())
            {
                try
                {
                    db.Entry(info).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    aux = 1;
                }
                catch (Exception e)
                {

                }
            }

            return aux;
        }
        public int deletedata(Utilizador utilizador)
        {
            int aux = 0;
            using (var db = new DBContext())
            {
                try
                {
                    db.Entry(utilizador).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    aux = 1;
                }
                catch (Exception e)
                {

                }
            }
            return aux;
        }
        public List<Gestor> GetGestors()
        {
            List<Gestor> gestores = new List<Gestor>();
            using (var db = new DBContext())
            {
                try
                {
                    gestores = db.Utilizadores.OfType<Gestor>().ToList();
                }
                catch (Exception er)
                {
                    MessageBox.Show("eero" + er);
                }
            }

            return gestores;
        }
        public List<Programador> GetProgramadores()
        {
            List<Programador> progs = new List<Programador>();
            using (var db = new DBContext())
            {
                try
                {
                    progs = db.Utilizadores.OfType<Programador>().ToList();
                }
                catch (Exception er)
                {
                    MessageBox.Show("eero" + er);
                }
            }

            return progs;
        }
    }
}
