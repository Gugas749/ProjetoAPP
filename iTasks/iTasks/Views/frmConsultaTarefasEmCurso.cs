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
    public partial class frmConsultaTarefasEmCurso : Form
    {
        public frmConsultaTarefasEmCurso()
        {
            InitializeComponent();
        }

        private void frmConsultaTarefasEmCurso_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadList()
        {
            using (var db = new DBContext())
            {
                try
                {
                    List<Tarefa> tarefas = db.Tarefas.ToList();
                    List<Tarefa> aux = new List<Tarefa>();
                    foreach (Tarefa selected in tarefas)
                    {
                        if (selected.EstadoAtual == EstadoAtual.Doing)
                        {
                            aux.Add(selected);
                        }
                    }
                    gvTarefasEmCurso.DataSource = aux;
                }
                catch
                {

                }
            }
        }
    }
}
