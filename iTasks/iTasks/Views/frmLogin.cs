using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace iTasks
{
    public partial class frmLogin : Form
    {
        frmKanban parent;
        public frmLogin(frmKanban parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if(txtBoxUsername.Text.Trim().Length > 0)
            {

                if (txtBoxPassword.Text.Trim().Length > 0)
                {
                    Utilizador user = null;
                    switch (GetUser(txtBoxUsername.Text.Trim(), txtBoxPassword.Text.Trim(), ref user))
                    {
                        case 0: // nao encontrou o user ou deu erro
                            MessageBox.Show("O utilizador não está registado na base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1: // encontrou mas falhou a pass
                            MessageBox.Show("A password inserida não está correta.", "Password incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2: // deu tudo certo
                            parent.loginComplete(user);
                            break;
                    }
                }
                else
                {
                    errorProvider1.SetError(txtBoxPassword, "Este campo é necessario.");
                }
            }
            else
            {
                errorProvider1.SetError(txtBoxUsername, "Este campo é necessario.");
            }
        }

        private int GetUser(string insertedUsername, string insertedPassword, ref Utilizador user)
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
                            if (selectedUser.Password == CaesarCipher.Encrypt(insertedPassword, 10))
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
