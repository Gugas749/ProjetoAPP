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
        Gestor gestor = new Gestor();
        List<Gestor> listGestor = new List<Gestor>();

        Programador prog = new Programador();
        List<Programador> listProg = new List<Programador>();


        public frmGereUtilizadores(frmKanban parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmGereUtilizadores_Load(object sender, EventArgs e)
        {
            cbDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
            cbNivelProg.DataSource = Enum.GetValues(typeof(NivelExperiencia));

            loadListGest();
            loadListProg();
        }

        #region GereGestor

        private void loadListGest()
        {
            getListUsers();
            lstListaGestores.DataSource = null;
            lstListaGestores.DataSource = listGestor;
            lstListaGestores.SelectedItem = -1;

            lstListaGestores.DisplayMember = "Nome";
            lstListaGestores.ValueMember = "Id";
        }

        private void getListUsers()
        {
            using (var db = new DBContext())
            {
                try
                {
                    var gestores = db.Utilizadores
                        .OfType<Gestor>()
                        .ToList();

                    listGestor = gestores;

                    //
                    // ComboBox Programador (Gestor associado)
                    //

                    // Esta versão fica associado a listbox do gestor
                    //cbGestorProg.DataSource = gestores;


                    cbGestorProg.DataSource = null;
                    // Cria uma outra list pra nao ter os id´s associados e nao dar conflito com a listbox do gestor
                    cbGestorProg.DataSource = gestores.Select(g => new {
                        Id = g.Id,
                        Nome = g.Nome
                    }).ToList();

                    cbGestorProg.DisplayMember = "Nome";
                    cbGestorProg.ValueMember = "Id";
                    cbGestorProg.SelectedIndex = -1;
                }
                catch (Exception er)
                {
                    MessageBox.Show("eero" + er);
                }
            }
        }


        private void lstListaGestores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListaGestores.SelectedIndex > -1)
            {
                gestor = (Gestor)lstListaGestores.SelectedItem;

                txtIdGestor.Text = gestor.Id.ToString();
                txtNomeGestor.Text = gestor.Nome;
                txtUsernameGestor.Text = gestor.Username;
                txtPasswordGestor.Text = gestor.Password;

                if (gestor is Gestor userGestor)
                {
                    cbDepartamento.SelectedItem = userGestor.Departamento;

                    if (userGestor.GereUtilizadores)
                        chkGereUtilizadores.Checked = true;
                    else
                        chkGereUtilizadores.Checked = false;
                }



            }
        }

        private bool allFieldsFilledGest()
        {
            bool aux = true;

            if (txtNomeGestor.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtNomeGestor, "Este campo é necessario.");
            }

            if (txtUsernameGestor.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtUsernameGestor, "Este campo é necessario.");
            }

            if (txtPasswordGestor.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtPasswordGestor, "Este campo é necessario.");
            }

            if (cbDepartamento.SelectedIndex == -1)
            {
                aux = false;
                errorProvider1.SetError(cbDepartamento, "Este campo é necessario.");
            }

            return aux;
        }

        private void btGravarGestor_Click(object sender, EventArgs e)
        {
            if (lstListaGestores.SelectedIndex > -1)
            {
                if (allFieldsFilledGest())
                {
                    savedataGest();
                }
            }
        }

        private void savedataGest()
        {
            using (var db = new DBContext())
            {
                try
                {
                    gestor.Nome = txtNomeGestor.Text;
                    gestor.Username = txtUsernameGestor.Text;
                    gestor.Password = txtPasswordGestor.Text;
                    gestor.Departamento = (Departamento)cbDepartamento.SelectedItem;
                    gestor.GereUtilizadores = chkGereUtilizadores.Checked;
                    db.Entry(gestor).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                    loadListGest();
                    MessageBox.Show("Alterações Guardadas");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao gravar utilizador: " + e.Message);
                }
            }
        }

        private void btDeleteGestor_Click(object sender, EventArgs e)
        {
            if (lstListaGestores.SelectedIndex > -1)
            {
                using (var db = new DBContext())
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Deseja mesmo eleminar? \nUser selecionado: " + gestor.Nome, "Confirmação", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            db.Entry(gestor).State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            loadListGest();
                            MessageBox.Show("Utilizador eliminado com sucesso.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao eliminar utilizador: ");
                    }
                }
            }

        }

        #endregion

        #region GereProg

        private void loadListProg()
        {
            getListProg();
            lstListaProgramadores.DataSource = null;
            lstListaProgramadores.DataSource = listProg;
            lstListaProgramadores.SelectedItem = -1;

            lstListaProgramadores.DisplayMember = "Nome";
            lstListaProgramadores.ValueMember = "Id";
        }

        private void getListProg()
        {
            using (var db = new DBContext())
            {
                try
                {
                    listProg = db.Programadores.ToList();
                }
                catch
                {

                }
            }
        }

        private void lstListaProgramadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListaProgramadores.SelectedIndex > -1)
            {
                prog = (Programador)lstListaProgramadores.SelectedItem;

                txtIdProg.Text = prog.Id.ToString();
                txtNomeProg.Text = prog.Nome;
                txtUsernameProg.Text = prog.Username;
                txtPasswordProg.Text = prog.Password;

                if (prog is Programador userprog)
                {
                    cbNivelProg.SelectedItem = userprog.NivelExperiencia;
                    cbGestorProg.SelectedValue = userprog.IdGestor;
                }


            }
        }
        private bool allFieldsFilledProg()
        {
            bool aux = true;

            if (txtNomeProg.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtNomeProg, "Este campo é necessario.");
            }

            if (txtUsernameProg.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtUsernameProg, "Este campo é necessario.");
            }

            if (txtPasswordProg.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtPasswordProg, "Este campo é necessario.");
            }

            if (cbNivelProg.SelectedIndex == -1)
            {
                aux = false;
                errorProvider1.SetError(cbNivelProg, "Este campo é necessario.");
            }

            if (cbGestorProg.SelectedIndex == -1)
            {
                aux = false;
                errorProvider1.SetError(cbGestorProg, "Este campo é necessario.");
            }

            return aux;
        }

        private void btGravarProg_Click(object sender, EventArgs e)
        {
            if (lstListaProgramadores.SelectedIndex > -1)
            {
                if (allFieldsFilledProg())
                {
                    savedataProg();
                }
            }
        }

        private void savedataProg()
        {
            using (var db = new DBContext())
            {
                try
                {
                    if (prog is Programador userProg)
                    {
                        userProg.Nome = txtNomeProg.Text;
                        userProg.Username = txtUsernameProg.Text;
                        userProg.Password = txtPasswordProg.Text;
                        userProg.NivelExperiencia = (NivelExperiencia)cbNivelProg.SelectedItem;
                        userProg.IdGestor = (int)cbGestorProg.SelectedValue;
                        db.Entry(userProg).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    loadListProg();
                    MessageBox.Show("Alterações Guardadas");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao gravar utilizador: " + e.Message);
                }
            }
        }











        #endregion
    }
}
