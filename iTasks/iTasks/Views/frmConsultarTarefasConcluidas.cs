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
    public partial class frmConsultarTarefasConcluidas : Form
    {
        ControllerFrmsConsultar controller = new ControllerFrmsConsultar();
        public frmConsultarTarefasConcluidas()
        {
            InitializeComponent();
        }

        private void frmConsultarTarefasConcluidas_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadList()
        {
            List<Tarefa> tarefas = controller.GetTarefas();
            List<Tarefa> aux = new List<Tarefa>();
            foreach (Tarefa selected in tarefas)
            {
                if (selected.EstadoAtual == EstadoAtual.Done)
                {
                    aux.Add(selected);
                }
            }
            gvTarefasConcluidas.DataSource = aux;
        }
    }
}
