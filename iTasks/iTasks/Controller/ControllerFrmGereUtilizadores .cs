using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
                    // da get ao ID
                    var userToDelete = db.Utilizadores.FirstOrDefault(u => u.Id == utilizador.Id);

                    if (userToDelete != null)
                    {
                        db.Utilizadores.Remove(userToDelete);
                        db.SaveChanges();
                        aux = 1;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro no delete: " + e.Message);
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
                    List<Gestor> aux = db.Utilizadores.OfType<Gestor>().ToList();
                    foreach (var a in aux)
                    {
                        Gestor programador = a as Gestor;
                        programador.Username = CaesarCipher.Decrypt(a.Username, 10);
                        programador.Nome = CaesarCipher.Decrypt(a.Nome, 10);
                        gestores.Add(programador);
                    }
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
                    List<Programador> aux = db.Utilizadores.OfType<Programador>().ToList();
                    foreach(var a in aux)
                    {
                        Programador programador = a as Programador;
                        programador.Username = CaesarCipher.Decrypt(a.Username, 10);
                        programador.Nome = CaesarCipher.Decrypt(a.Nome, 10);
                        progs.Add(programador);
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show("eero" + er);
                }
            }

            return progs;
        }

        public int createdata(Utilizador info)
        {
            int aux = 0;
            using (var db = new DBContext())
            {
                try
                {
                    db.Utilizadores.Add(info); // ou db.Set<Utilizador>().Add(info);
                    db.SaveChanges();
                    aux = 1;
                }
                catch (Exception e)
                {
                    // Podes registar o erro se quiseres:
                    // Console.WriteLine(e.Message);
                }
            }

            return aux;
        }
    }
}
