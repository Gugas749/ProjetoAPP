using iTasks.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks
{
    public partial class frmGereUtilizadores : Form
    {
        frmKanban parent;
        int userRole = 0;
        Utilizador user = new Utilizador();
        List<Utilizador> listUsers = new List<Utilizador>();


        public frmGereUtilizadores(frmKanban parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmGereUtilizadores_Load(object sender, EventArgs e)
        {

            if (user is Programador programador)
                userRole = 1;
            else if (user is Gestor gestor)
                userRole = 2;
            else
                userRole = 0;

            cbDepartamento.DataSource = Enum.GetValues(typeof(Departamento));

            getListUsers();
            loadList();
        }

        private void getListUsers()
        {
            using (var db = new DBContext())
            {
                try
                {
                    listUsers = db.Utilizadores.ToList();
                }
                catch
                {

                }
            }
        }

        private void loadList()
        {
            lstListaGestores.DataSource = listUsers;

            lstListaGestores.DisplayMember = "Nome"; 
            lstListaGestores.ValueMember = "Id";
        }

        private void lstListaGestores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListaGestores.SelectedIndex > -1)
            {
                user = (Utilizador)lstListaGestores.SelectedItem;

                txtIdGestor.Text = user.Id.ToString();
                txtNomeGestor.Text = user.Nome;
                txtUsernameGestor.Text = user.Username;
                txtPasswordGestor.Text = user.Password;

                if (user is Gestor gestor)
                {
                    cbDepartamento.SelectedItem = gestor.Departamento;

                    if (gestor.GereUtilizadores)
                        chkGereUtilizadores.Checked = true;
                    else
                        chkGereUtilizadores.Checked = false;
                }

            }
        }

        private void btGravarGestor_Click(object sender, EventArgs e)
        {

        }
    }
}
