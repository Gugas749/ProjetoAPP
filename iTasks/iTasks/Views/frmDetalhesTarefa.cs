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
    public partial class frmDetalhesTarefa : Form
    {
        Utilizador user = new Utilizador();
        int userRole = 0;
        bool changedSomething = false;
        List<Programador> listProgramadors = new List<Programador>();
        List<TipoTarefa> listTiposTarefas = new List<TipoTarefa>();
        Tarefa tarefaRecebida = new Tarefa();
        frmKanban parent;

        public frmDetalhesTarefa(Utilizador user, frmKanban parent, int userRole, Tarefa tarefa)
        {
            InitializeComponent();
            this.user = user;
            this.parent = parent;
            this.userRole = userRole;
            this.tarefaRecebida = tarefa;
        }

        private void frmDetalhesTarefa_Load(object sender, EventArgs e)
        {
            enableDisable(userRole);
            loadInfos();
        }

        private void butFechar_Click(object sender, EventArgs e)
        {
            if(changedSomething)
            {
                if(MessageBox.Show("Salvar antes de sair?", "Deseja salvar os dados antes de sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    butGravar.PerformClick();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void butGravar_Click(object sender, EventArgs e)
        {
            if(allFieldsFilled())
            {
                saveData();
            }
        }

        private void txtStoryPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOrdem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region FUNCOES
        private void enableDisable(int role)
        {
            butGravar.Enabled = false;
            //----------------------
            txtDesc.Enabled = false;
            txtStoryPoints.Enabled = false;
            txtOrdem.Enabled = false;
            txtId.Enabled = false;
            txtEstado.Enabled = false;
            txtDataCriacao.Enabled = false;
            txtDataRealini.Enabled = false;
            txtdataRealFim.Enabled = false;
            //----------------------
            comboBoxTipoTarefa.Enabled = false;
            comboBoxProgramador.Enabled = false;
            //----------------------
            dtInicio.Enabled = false;
            dtFim.Enabled = false;
            //----------------------

            switch (role)
            {

                case 2:
                    butFechar.Enabled = true;
                    butGravar.Enabled = true;
                    //----------------------
                    txtDesc.Enabled = true;
                    txtStoryPoints.Enabled = true;
                    txtOrdem.Enabled = true;
                    //----------------------
                    comboBoxTipoTarefa.Enabled = true;
                    comboBoxProgramador.Enabled = true;
                    //----------------------
                    dtInicio.Enabled = true;
                    dtFim.Enabled = true;
                    //----------------------
                    break;
            }
        }
        private void saveData()
        {
            Tarefa tarefa = new Tarefa();
            tarefa.IdGestor = user.Id;
            tarefa.IdProgramador = listProgramadors[comboBoxProgramador.SelectedIndex].Id;
            tarefa.OrdemExecucao = Convert.ToInt32(txtOrdem.Text.Trim());
            tarefa.Descricao = txtDesc.Text.Trim();
            tarefa.DataPrevistaInicio = dtInicio.Value;
            tarefa.DataPrevistaFim = dtFim.Value;
            tarefa.IdTipoTarefa = listTiposTarefas[comboBoxTipoTarefa.SelectedIndex].Id;
            tarefa.StoryPoints = Convert.ToInt32(txtStoryPoints.Text.Trim());
            tarefa.DataRealInicio = DateTime.Now;
            tarefa.DataRealFim = DateTime.Now;
            tarefa.DataCriacao = DateTime.Now;
            tarefa.EstadoAtual = EstadoAtual.ToDo;

            using (var db = new DBContext())
            {
                db.Tarefas.Add(tarefa);
                db.SaveChanges();
                MessageBox.Show("Tarefa adicionada", "A tarefa foi adicionada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
        }
        private bool allFieldsFilled()
        {
            bool aux = true;

            if (txtDesc.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtDesc, "Este campo é necessario.");
            }

            if (comboBoxTipoTarefa.SelectedIndex < 0)
            {
                aux = false;
                errorProvider1.SetError(comboBoxTipoTarefa, "Este campo é necessario.");
            }

            if (comboBoxProgramador.SelectedIndex < 0)
            {
                aux = false;
                errorProvider1.SetError(comboBoxProgramador, "Este campo é necessario.");
            }

            if (txtOrdem.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtOrdem, "Este campo é necessario.");
            }

            if (txtStoryPoints.Text.Trim().Length <= 0)
            {
                aux = false;
                errorProvider1.SetError(txtStoryPoints, "Este campo é necessario.");
            }

            return aux;
        }
        private void loadInfos()
        {
            if (userRole == 2)
            {
                txtDataCriacao.Text = DateTime.Now.ToString();
                txtEstado.Text = EstadoAtual.ToDo.ToString();
                txtDataRealini.Text = "Indisponivel";
                txtdataRealFim.Text = "Indisponivel";

                using (var db = new DBContext())
                {
                    try
                    {
                        List<Utilizador> users = db.Utilizadores.ToList();
                        foreach (Utilizador selectedUser in users)
                        {
                            if (selectedUser is Programador programador)
                            {
                                if (programador.IdGestor == user.Id)
                                {
                                    listProgramadors.Add(programador);
                                    comboBoxProgramador.Items.Add(programador.Username + " - " + programador.Nome);
                                }
                            }
                        }

                        List<TipoTarefa> tiposTarefas = db.TipoTarefas.ToList();
                        foreach (TipoTarefa tipoTarefa in tiposTarefas)
                        {
                            listTiposTarefas.Add(tipoTarefa);
                            comboBoxTipoTarefa.Items.Add(tipoTarefa.Nome);
                        }

                        List<Tarefa> tarefas = db.Tarefas.ToList();
                        int aux = 0;
                        foreach (Tarefa tarefa in tarefas)
                        {
                            if (tarefa.Id > aux)
                            {
                                aux = tarefa.Id;
                            }
                        }

                        aux++;

                        txtId.Text = aux.ToString();
                    }
                    catch
                    {

                    }
                }
            }
            else
            {
                txtId.Text = tarefaRecebida.Id.ToString();
                txtEstado.Text = tarefaRecebida.EstadoAtual.ToString();
                txtDataCriacao.Text = tarefaRecebida.DataCriacao.ToString();
                txtDataRealini.Text = tarefaRecebida.DataRealInicio.ToString();
                txtdataRealFim.Text = tarefaRecebida.DataRealFim.ToString();
                txtDesc.Text = tarefaRecebida.Descricao.ToString();
                txtOrdem.Text = tarefaRecebida.OrdemExecucao.ToString();
                txtStoryPoints.Text = tarefaRecebida.StoryPoints.ToString();
                dtInicio.Value = tarefaRecebida.DataPrevistaInicio;
                dtFim.Value = tarefaRecebida.DataPrevistaFim;

                using (var db = new DBContext())
                {
                    try
                    {
                        List<Utilizador> users = db.Utilizadores.ToList();
                        foreach (Utilizador selectedUser in users)
                        {
                            if (selectedUser is Programador programador)
                            {
                                if (programador.Id == tarefaRecebida.IdProgramador)
                                {
                                    comboBoxProgramador.Text = programador.Username + " - " + programador.Nome;
                                }
                            }
                        }

                        List<TipoTarefa> tiposTarefas = db.TipoTarefas.ToList();
                        foreach (TipoTarefa tipoTarefa in tiposTarefas)
                        {
                            if(tipoTarefa.Id == tarefaRecebida.IdTipoTarefa)
                            {
                                comboBoxTipoTarefa.Text = tipoTarefa.Id + " - " + tipoTarefa.Nome;
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
        private void clearAll()
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            id++;
            txtId.Text = id.ToString();

            txtDesc.Text = "";
            comboBoxProgramador.SelectedItem = null;
            comboBoxTipoTarefa.SelectedItem = null;
            txtOrdem.Text = "";
            txtStoryPoints.Text = "";
            dtInicio.Value = DateTime.Now;
            dtFim.Value = DateTime.Now;
        }
        #endregion
    }
}
