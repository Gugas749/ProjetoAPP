using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using iTasks.Controller;
using iTasks.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace iTasks
{
    public partial class frmLogin : Form
    {
        frmKanban parent;
        ControllerFrmLogin controller = new ControllerFrmLogin();
        public frmLogin(frmKanban parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            controller = new ControllerFrmLogin();

            using (var db = new DBContext())
            {
                Gestor user = new Gestor();
                user.Nome = CaesarCipher.Encrypt("Padre", 10);
                user.Username = CaesarCipher.Encrypt("gest1", 10);
                user.Password = CaesarCipher.Encrypt("1", 10);
                user.GereUtilizadores = true;
                user.Departamento = Departamento.Administracao;
                db.Utilizadores.Add(user);
                db.SaveChanges();
            }

            using (var db = new DBContext())
            {
                var gestor = db.Utilizadores.OfType<Gestor>().FirstOrDefault(g => g.Username == "gest1");

                if (gestor != null)
                {
                    Programador prog = new Programador();
                    prog.Nome = CaesarCipher.Encrypt("prog1", 10);
                    prog.Username = CaesarCipher.Encrypt("prog1", 10);
                    prog.Password = CaesarCipher.Encrypt("1", 10);
                    prog.NivelExperiencia = NivelExperiencia.Junior;
                    prog.IdGestor = gestor.Id;
                    prog.Gestor = gestor;

                    db.Utilizadores.Add(prog);
                    db.SaveChanges();
                }
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if(txtBoxUsername.Text.Trim().Length > 0)
            {
                if (txtBoxPassword.Text.Trim().Length > 0)
                {
                    Utilizador user = null;
                    switch (controller.GetUser(txtBoxUsername.Text.Trim(), txtBoxPassword.Text.Trim(), ref user))
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

        
    }
}
