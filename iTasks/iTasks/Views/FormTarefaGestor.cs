using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTasks.Controller;
using iTasks.Model;

namespace iTasks.Views
{
    public partial class FormTarefaGestor : Form
    {
        Gestor user = new Gestor();
        ControllerFormTarefaGestor controller = new ControllerFormTarefaGestor();
        List<TarefaGestor> tarefas = new List<TarefaGestor>();
        int nextId = 0;

        public FormTarefaGestor(Utilizador receivedUser)
        {
            InitializeComponent();
            user = receivedUser as Gestor;
        }

        private void FormTarefaGestor_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void loadList()
        {
            lstListaTarefas.Items.Clear();
            nextId = 0;
            tarefas = controller.GetTarefas(user);
            foreach(TarefaGestor taref in tarefas)
            {
                lstListaTarefas.Items.Add(taref.ToString());
                nextId++;
            }

            txtId.Text = nextId.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Trim().Length > 0)
            {
                TarefaGestor tarefa = new TarefaGestor();
                tarefa.IdGestor = user.Id;
                tarefa.Descricao = CaesarCipher.Encrypt(txtDesc.Text.Trim(), 10);
                tarefa.Terminado = false;
                int response = controller.saveData(tarefa);

                if (response == 1)
                {
                    tarefas.Add(tarefa);
                    loadList();
                }
                else
                {
                    MessageBox.Show("Erro a gravar dados na base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errorProvider1.SetError(txtDesc, "Este campo é necessario.");
            }
        }

        private void butTerminarTarefa_Click(object sender, EventArgs e)
        {
            if (lstListaTarefas.SelectedIndex >= 0)
            {
                TarefaGestor aux = tarefas[lstListaTarefas.SelectedIndex];
                tarefas.Remove(aux);
                aux.Terminado = true;
                int response = controller.TerminarTarefa(aux);

                if (response == 1)
                {
                    tarefas.Add(aux);
                    loadList();
                }
                else
                {
                    MessageBox.Show("Erro a apagar dados na base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Porfavor, selecione o tipo de tarefa que deseja apagar.", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
