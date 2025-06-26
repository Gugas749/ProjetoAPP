using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Controller;
using iTasks.Model;
using iTasks.Views;

namespace iTasks
{
    public partial class frmKanban : Form
    {
        #region VIEWS
        frmLogin frmLogin;
        #endregion

        ControllerFrmKanban controller = new ControllerFrmKanban();
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
            loginHandeler();
        }

        #region BUTOES
        private void butNovaTarefa_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            frmDetalhesTarefa frm = new frmDetalhesTarefa(user, this, userRole, tarefa, 0);
            frm.ShowDialog();
            loadLists();
        }
        private void butExeTarefa_Click(object sender, EventArgs e)
        {
            if (lstTodo.SelectedIndex >= 0 && lstTodo.SelectedIndex != null)
            {
                string selected = lstTodo.SelectedItem.ToString();
                string numberPart = selected.Split('-')[0].Trim();
                if (!numberPart.Equals("") && !numberPart.Equals(" "))
                {
                    int idAux = Convert.ToInt32(numberPart);
                    Tarefa aux = controller.updateTarefa(idAux, EstadoAtual.Doing);
                    foreach (Tarefa tarefa in listToDo)
                    {
                        if (tarefa.Id == idAux)
                        {
                            listToDo.Remove(tarefa);
                            break;
                        }
                    }
                    listDoing.Add(aux);
                }
                updateLists();
            }
        }
        private void butReiniciarTarefa_Click(object sender, EventArgs e)
        {
            if(lstDoing.SelectedIndex >= 0 && lstDoing.SelectedIndex != null)
            {
                string selected = lstDoing.SelectedItem.ToString();
                string numberPart = selected.Split('-')[0].Trim();
                if (!numberPart.Equals("") && !numberPart.Equals(" "))
                {
                    int idAux = Convert.ToInt32(numberPart);
                    Tarefa aux = controller.updateTarefa(idAux, EstadoAtual.ToDo);
                    foreach (Tarefa tarefa in listDone)
                    {
                        if (tarefa.Id == idAux)
                        {
                            listToDo.Remove(tarefa);
                            break;
                        }
                    }
                    listToDo.Add(aux);
                }
                updateLists();
            }
        }
        private void butTerminarTarefa_Click(object sender, EventArgs e)
        {
            if (lstDoing.SelectedIndex >= 0 && lstDoing.SelectedIndex != null)
            {
                string selected = lstDoing.SelectedItem.ToString();
                string numberPart = selected.Split('-')[0].Trim();
                if (!numberPart.Equals("") && !numberPart.Equals(" "))
                {
                    int idAux = Convert.ToInt32(numberPart);
                    Tarefa aux = controller.updateTarefa(idAux, EstadoAtual.Done);
                    foreach (Tarefa tarefa in listDoing)
                    {
                        if (tarefa.Id == idAux)
                        {
                            listDoing.Remove(tarefa);
                            break;
                        }
                    }
                    listDone.Add(aux);
                }
                updateLists();
            }
        }
        private void butVerPrevConclusao_Click(object sender, EventArgs e)
        {
            if (lstTodo.SelectedIndex >= 0 && lstTodo.SelectedIndex != null)
            {
                string selected = lstTodo.SelectedItem.ToString();
                string numberPart = selected.Split('-')[0].Trim();
                int StoryPoints = 0;
                foreach(Tarefa tarefa in listToDo)
                {
                    if (tarefa.Id == Convert.ToInt32(numberPart))
                    {
                        StoryPoints = tarefa.StoryPoints;
                        break;
                    }
                }
                Diversao diversao = new Diversao();
                double totalSeconds = diversao.previsao(listDone, StoryPoints);
                int hours = (int)(totalSeconds / 3600);
                int minutes = (int)((totalSeconds % 3600) / 60);
                int seconds = (int)(totalSeconds % 60);
                MessageBox.Show($"Tempo previsto: {hours}h {minutes}m {seconds}s");
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginHandeler();
        }
        private void exportarParaCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "Tarefas",
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminho = saveFileDialog.FileName;

                using (FileStream fs = new FileStream(caminho, FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Id;IdGestor;IdProgramador;OrdemExecucao;Titulo;Descricao;DataPrevistaInicio;DataPrevistaFim;IdTipoTarefa;StoryPoints;DataRealInicio;DataRealFim;DataCriacao;EstadoAtual");

                    foreach (Tarefa tarefa in listDone)
                    {
                        sw.WriteLine(
                            $"{tarefa.Id};{tarefa.IdGestor};{tarefa.IdProgramador};{tarefa.OrdemExecucao};" +
                            $"{tarefa.Titulo};{tarefa.Descricao};" +
                            $"{tarefa.DataPrevistaInicio:yyyy-MM-dd};{tarefa.DataPrevistaFim:yyyy-MM-dd};" +
                            $"{tarefa.IdTipoTarefa};{tarefa.StoryPoints};" +
                            $"{tarefa.DataRealInicio:yyyy-MM-dd};{tarefa.DataRealFim:yyyy-MM-dd};" +
                            $"{tarefa.DataCriacao:yyyy-MM-dd};{tarefa.EstadoAtual}"
                        );
                    }
                }

                MessageBox.Show("Exportação foi concluida com sucesso!", "Exportar para CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void gerirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGereUtilizadores frm = new frmGereUtilizadores(this, ref user);
            frm.ShowDialog();
            loadInfosByUser();
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
        private void lstTodo_DoubleClick(object sender, EventArgs e)
        {
            if (lstTodo.SelectedIndex >= 0 && lstTodo.SelectedIndex != null)
            {
                string selected = lstTodo.SelectedItem.ToString();
                string numberPart = selected.Split('-')[0].Trim();
                if (!numberPart.Equals("") && !numberPart.Equals(" "))
                {
                    int idAux = Convert.ToInt32(numberPart);
                    foreach (Tarefa tarefa in listToDo)
                    {
                        if (tarefa.Id == idAux)
                        {
                            frmDetalhesTarefa frm = new frmDetalhesTarefa(user, this, userRole, tarefa, 1);
                            frm.ShowDialog();
                            updateLists();
                            break;
                        }
                    }
                }
            }
        }
        private void lstDoing_DoubleClick(object sender, EventArgs e)
        {
            if (lstDoing.SelectedIndex >= 0 && lstDoing.SelectedIndex != null)
            {
                string selected = lstDoing.SelectedItem.ToString();
                string numberPart = selected.Split('-')[0].Trim();
                if (!numberPart.Equals("") && !numberPart.Equals(" "))
                {
                    int idAux = Convert.ToInt32(numberPart);
                    foreach (Tarefa tarefa in listDoing)
                    {
                        if (tarefa.Id == idAux)
                        {
                            frmDetalhesTarefa frm = new frmDetalhesTarefa(user, this, userRole, tarefa, 1);
                            frm.ShowDialog();
                            updateLists();
                            break;
                        }
                    }
                }
            }
        }
        private void lstDone_DoubleClick(object sender, EventArgs e)
        {
            if (lstDone.SelectedIndex >= 0 && lstDone.SelectedIndex != null)
            {
                string selected = lstDone.SelectedItem.ToString();
                string numberPart = selected.Split('-')[0].Trim();
                if (!numberPart.Equals("") && !numberPart.Equals(" "))
                {
                    int idAux = Convert.ToInt32(numberPart);
                    foreach (Tarefa tarefa in listDone)
                    {
                        if (tarefa.Id == idAux)
                        {
                            frmDetalhesTarefa frm = new frmDetalhesTarefa(user, this, userRole, tarefa, 1);
                            frm.ShowDialog();
                            updateLists();
                            break;
                        }
                    }
                }
            }
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
            logoutToolStripMenuItem.Enabled = false;
            exportarParaCSVToolStripMenuItem.Enabled = false;
            //----------------------
            utilizadoresToolStripMenuItem.Enabled = false;
            gerirTiposDeTarefasToolStripMenuItem.Enabled = false;
            gerirUtilizadoresToolStripMenuItem.Enabled = false;
            //----------------------
            listagensToolStripMenuItem.Enabled = false;
            tarefasTerminadasToolStripMenuItem.Enabled = false;
            tarefasEmCursoToolStripMenuItem.Enabled = false;
            formTarefaGestorToolStripMenuItem.Enabled = false;
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
                    logoutToolStripMenuItem.Enabled = true;
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
                    logoutToolStripMenuItem.Enabled = true;
                    exportarParaCSVToolStripMenuItem.Enabled = true;
                    //----------------------
                    utilizadoresToolStripMenuItem.Enabled = true;
                    gerirTiposDeTarefasToolStripMenuItem.Enabled = true;
                    //gerirUtilizadoresToolStripMenuItem.Enabled = true;
                    if (user is Gestor gestor)
                    {
                        if (gestor.GereUtilizadores)
                        {
                            gerirUtilizadoresToolStripMenuItem.Enabled = true;
                        }
                    }
                    //----------------------
                    listagensToolStripMenuItem.Enabled = true;
                    tarefasTerminadasToolStripMenuItem.Enabled = true;
                    tarefasEmCursoToolStripMenuItem.Enabled = true;
                    formTarefaGestorToolStripMenuItem.Enabled = true;
                    //----------------------
                    break;
            }
        }
        private void loadLists()
        {
            lstTodo.Items.Clear();
            lstDoing.Items.Clear();
            lstDone.Items.Clear();
            
            List<Tarefa> tarefas = controller.GetTarefas();
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
        private void updateLists()
        {
            lstTodo.Items.Clear();
            lstDoing.Items.Clear();
            lstDone.Items.Clear();
            foreach (Tarefa tarefa in listToDo)
            {
                lstTodo.Items.Add(tarefa.ToString());
            }
            foreach (Tarefa tarefa in listDoing)
            {
                lstDoing.Items.Add(tarefa.ToString());
            }
            foreach (Tarefa tarefa in listDone)
            {
                lstDone.Items.Add(tarefa.ToString());
            }
        }
        private void loginHandeler()
        {
            frmLogin = new frmLogin(this);
            this.Hide();
            frmLogin.ShowDialog();
            this.Show();
            this.Focus();

            loadInfosByUser();
        }
        private void loadInfosByUser()
        {
            listToDo.Clear();
            listDoing.Clear();
            listDone.Clear();

            if (user != null && user.Id != 0)
            {
                lbBemVindo.Text = "Bem vindo: " + CaesarCipher.Decrypt(user.Username.ToString(), 10);
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
        #endregion

        private void formTarefaGestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarefaGestor frm = new FormTarefaGestor(user);
            frm.ShowDialog();
        }
    }
}
