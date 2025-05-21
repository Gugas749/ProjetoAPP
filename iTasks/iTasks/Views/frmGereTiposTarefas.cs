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

namespace iTasks
{
    public partial class frmGereTiposTarefas : Form
    {
        frmKanban parent;
        List<TipoTarefa> tiposTarefas = new List<TipoTarefa>();
        ControllerFrmTiposTarefas controller = new ControllerFrmTiposTarefas();

        public frmGereTiposTarefas(frmKanban parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmGereTiposTarefas_Load(object sender, EventArgs e)
        {
            getListTiposTarefas();
            loadList();
        }

        private void getListTiposTarefas()
        {
            using (var db = new DBContext())
            {
                try
                {
                    tiposTarefas = db.TipoTarefas.ToList();
                }
                catch
                {

                }
            }
        }

        private void loadList()
        {
            lstLista.Items.Clear();
            int aux = 0;
            foreach (TipoTarefa item in tiposTarefas)
            {
                lstLista.Items.Add(item.Id + " - "+ item.Nome);
                if (item.Id > aux)
                {
                    aux = item.Id;
                }
            }
            aux++;

            txtId.Text = aux.ToString();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if(txtDesc.Text.Trim().Length > 0)
            {
                TipoTarefa tipoTarefa = new TipoTarefa();
                tipoTarefa.Nome = txtDesc.Text.Trim();
                int response = controller.saveData(tipoTarefa);
                
                if(response == 1)
                {
                    tiposTarefas.Add(tipoTarefa);
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

        private void butDeleteTipoTarefa_Click(object sender, EventArgs e)
        {
            if (lstLista.SelectedIndex >= 0)
            {
                string input = lstLista.SelectedItem.ToString();
                string numberPart = input.Split('-')[0].Trim();
                int number = int.Parse(numberPart);
                TipoTarefa aux = new TipoTarefa();
                foreach(TipoTarefa selected in tiposTarefas)
                {
                    if (selected.Id == number)
                    {
                        aux = selected;
                        break;
                    }
                }

                int response = controller.deleteData(aux);

                if (response == 1)
                {
                    tiposTarefas.Remove(aux);
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
