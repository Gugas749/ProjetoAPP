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

namespace iTasks
{
    public partial class frmKanban : Form
    {
        #region VIEWS
        frmLogin frmLogin;
        #endregion

        Utilizador user = new Utilizador();
        public frmKanban()
        {
            InitializeComponent();
        }

        private void frmKanban_Load(object sender, EventArgs e)
        {
            frmLogin = new frmLogin(this);
            this.Hide();
            frmLogin.ShowDialog();
        }

        public void loginComplete(Utilizador user)
        {
            this.user = user;
            frmLogin.Close();
        }
    }
}
