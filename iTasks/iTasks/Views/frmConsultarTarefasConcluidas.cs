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
                    Tarefa KRL = selected;
                    KRL.Descricao = CaesarCipher.Decrypt(selected.Descricao, 10);
                    KRL.Titulo = CaesarCipher.Decrypt(selected.Titulo, 10);
                    aux.Add(KRL);
                }
            }
            gvTarefasConcluidas.DataSource = aux;
        }
    }
}
