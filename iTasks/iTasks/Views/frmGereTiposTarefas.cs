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
    public partial class frmGereTiposTarefas : Form
    {
        frmKanban parent;
        List<TipoTarefa> tiposTarefas = new List<TipoTarefa>();

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
                using (var db = new DBContext())
                {
                    TipoTarefa tipoTarefa = new TipoTarefa();
                    tipoTarefa.Nome = txtDesc.Text.Trim();
                    db.TipoTarefas.Add(tipoTarefa);
                    db.SaveChanges();

                    tiposTarefas.Add(tipoTarefa);
                    loadList();
                }
            }
            else
            {
                errorProvider1.SetError(txtDesc, "Este campo é necessario.");
            }
        }
    }
}
