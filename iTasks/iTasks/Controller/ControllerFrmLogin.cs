using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTasks.Model;

namespace iTasks.Controller
{
    internal class ControllerFrmLogin
    {
        public int GetUser(string insertedUsername, string insertedPassword, ref Utilizador user)
        {
            int response = 0;
            using (var db = new DBContext())
            {
                try
                {
                    List<Utilizador> users = db.Utilizadores.ToList(); // SELECT * FROM Utilizadores
                    foreach (Utilizador selectedUser in users)
                    {
                        if (selectedUser.Username == insertedUsername)
                        {
                            response = 1;
                            if (selectedUser.Password == insertedPassword) //CaesarCipher.Encrypt(insertedPassword, 10))
                            {
                                response = 2;
                                user = selectedUser;
                            }
                        }
                    }
                }
                catch
                {
                    response = 0;
                }
            }
            return response;
        }
    }
}
