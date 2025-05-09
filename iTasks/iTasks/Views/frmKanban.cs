﻿using System;
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
        int userRole = 0;
        List<Tarefa> listToDo = new List<Tarefa>();
        List<Tarefa> listDoing = new List<Tarefa>();
        List<Tarefa> listDone = new List<Tarefa>();

        public frmKanban()
        {
            InitializeComponent();
        }

        private void frmKanban_Load(object sender, EventArgs e)
        {
            frmLogin = new frmLogin(this);
            this.Hide();
            frmLogin.ShowDialog();

            if(user != null && user.Id != 0)
            {
                lbBemVindo.Text = "Bem vindo: "+user.Username.ToString();
            }

            if (user is Programador programador)
            {
                userRole = 1;
            }
            else if (user is Gestor gestor)
            {
                userRole = 2;
            }

            enableDisable(userRole);
            loadLists();
        }

        #region BUTOES
        private void butNovaTarefa_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            frmDetalhesTarefa frm = new frmDetalhesTarefa(user, this, userRole, tarefa);
            frm.ShowDialog();
        }
        private void butExeTarefa_Click(object sender, EventArgs e)
        {

        }
        private void butReiniciarTarefa_Click(object sender, EventArgs e)
        {

        }
        private void butTerminarTarefa_Click(object sender, EventArgs e)
        {

        }
        private void butVerPrevConclusao_Click(object sender, EventArgs e)
        {

        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void exportarParaCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void gerirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGereUtilizadores frm = new frmGereUtilizadores(this);
            frm.ShowDialog();
        }
        private void gerirTiposDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGereTiposTarefas frm = new frmGereTiposTarefas(this);
            frm.ShowDialog();
        }
        private void tarefasTerminadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarTarefasConcluidas frm = new frmConsultarTarefasConcluidas();
            frm.ShowDialog();
        }
        private void tarefasEmCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTarefasEmCurso frm = new frmConsultaTarefasEmCurso();
            frm.ShowDialog();
        }
        #endregion

        #region FUNCOES
        public void loginComplete(Utilizador user)
        {
            this.user = user;
            frmLogin.Close();
        }
        private void enableDisable(int role)
        {
            butExeTarefa.Enabled = false;
            butNovaTarefa.Enabled = false;
            butReiniciarTarefa.Enabled = false;
            butTerminarTarefa.Enabled = false;
            butVerPrevConclusao.Enabled = false;
            //----------------------
            lstDoing.Enabled = false;
            lstDone.Enabled = false;
            lstTodo.Enabled = false;
            //----------------------
            ficheiroToolStripMenuItem.Enabled = false;
            sairToolStripMenuItem.Enabled = false;
            exportarParaCSVToolStripMenuItem.Enabled = false;
            //----------------------
            utilizadoresToolStripMenuItem.Enabled = false;
            gerirTiposDeTarefasToolStripMenuItem.Enabled = false;
            gerirUtilizadoresToolStripMenuItem.Enabled = false;
            //----------------------
            listagensToolStripMenuItem.Enabled = false;
            tarefasTerminadasToolStripMenuItem.Enabled = false;
            tarefasEmCursoToolStripMenuItem.Enabled = false;
            //----------------------

            switch (role)
            {
                case 1:
                    butExeTarefa.Enabled = true;
                    butReiniciarTarefa.Enabled = true;
                    butTerminarTarefa.Enabled = true;
                    //----------------------
                    lstDoing.Enabled = true;
                    lstDone.Enabled = true;
                    lstTodo.Enabled = true;
                    //----------------------
                    listagensToolStripMenuItem.Enabled = true;
                    tarefasTerminadasToolStripMenuItem.Enabled = true;
                    tarefasEmCursoToolStripMenuItem.Enabled = true;
                    //----------------------
                    break;
                case 2:
                    butVerPrevConclusao.Enabled = true;
                    butNovaTarefa.Enabled = true;
                    //----------------------
                    lstDoing.Enabled = true;
                    lstDone.Enabled = true;
                    lstTodo.Enabled = true;
                    //----------------------
                    ficheiroToolStripMenuItem.Enabled = true;
                    sairToolStripMenuItem.Enabled = true;
                    exportarParaCSVToolStripMenuItem.Enabled = true;
                    //----------------------
                    utilizadoresToolStripMenuItem.Enabled = true;
                    gerirTiposDeTarefasToolStripMenuItem.Enabled = true;
                    gerirUtilizadoresToolStripMenuItem.Enabled = true;
                    //----------------------
                    listagensToolStripMenuItem.Enabled = true;
                    tarefasTerminadasToolStripMenuItem.Enabled = true;
                    tarefasEmCursoToolStripMenuItem.Enabled = true;
                    //----------------------
                    break;
            }
        }
        private void loadLists()
        {
            using (var db = new DBContext())
            {
                try
                {
                    List<Tarefa> tarefas = db.Tarefas.ToList();
                    foreach (Tarefa selected in tarefas)
                    {
                        switch (selected.EstadoAtual)
                        {
                            case EstadoAtual.ToDo:
                                listToDo.Add(selected);
                                lstTodo.Items.Add(selected.ToString());
                                break;
                            case EstadoAtual.Doing:
                                listDoing.Add(selected);
                                lstDoing.Items.Add(selected.ToString());
                                break;
                            case EstadoAtual.Done:
                                listDone.Add(selected);
                                lstDone.Items.Add(selected.ToString());
                                break;
                        }
                    }
                }
                catch
                {

                }
            }
        }
        #endregion
    }
}
