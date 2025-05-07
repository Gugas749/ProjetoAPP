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
            int aux = 0;
            foreach (Utilizador item in listUsers)
            {
                lstListaGestores.Items.Add(item.Id + " - " + item.Nome);
                if (item.Id > aux)
                {
                    aux = item.Id;
                }
            }
            aux++;

            txtIdGestor.Text = aux.ToString();
        }
    }
}
