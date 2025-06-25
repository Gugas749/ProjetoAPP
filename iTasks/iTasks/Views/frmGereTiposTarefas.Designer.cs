namespace iTasks
{
    partial class frmGereTiposTarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.butDeleteTipoTarefa = new Guna.UI2.WinForms.Guna2Button();
            this.btGravar = new Guna.UI2.WinForms.Guna2Button();
            this.txtDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLista);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Tipos de Tarefas";
            // 
            // lstLista
            // 
            this.lstLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(4, 19);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(357, 451);
            this.lstLista.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtId.BorderRadius = 7;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.Enabled = false;
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(407, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "Id";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(134, 30);
            this.txtId.TabIndex = 51;
            // 
            // butDeleteTipoTarefa
            // 
            this.butDeleteTipoTarefa.BorderRadius = 7;
            this.butDeleteTipoTarefa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDeleteTipoTarefa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDeleteTipoTarefa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDeleteTipoTarefa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDeleteTipoTarefa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.butDeleteTipoTarefa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butDeleteTipoTarefa.ForeColor = System.Drawing.Color.White;
            this.butDeleteTipoTarefa.IndicateFocus = true;
            this.butDeleteTipoTarefa.Location = new System.Drawing.Point(407, 201);
            this.butDeleteTipoTarefa.Name = "butDeleteTipoTarefa";
            this.butDeleteTipoTarefa.Size = new System.Drawing.Size(177, 28);
            this.butDeleteTipoTarefa.TabIndex = 52;
            this.butDeleteTipoTarefa.Text = "Apagar";
            // 
            // btGravar
            // 
            this.btGravar.BorderRadius = 7;
            this.btGravar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btGravar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btGravar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btGravar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btGravar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.btGravar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btGravar.ForeColor = System.Drawing.Color.White;
            this.btGravar.IndicateFocus = true;
            this.btGravar.Location = new System.Drawing.Point(590, 201);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(177, 28);
            this.btGravar.TabIndex = 53;
            this.btGravar.Text = "Gravar Dados";
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtDesc.BorderRadius = 7;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.DefaultText = "";
            this.txtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesc.Location = new System.Drawing.Point(407, 108);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PlaceholderText = "Descrição";
            this.txtDesc.SelectedText = "";
            this.txtDesc.Size = new System.Drawing.Size(363, 86);
            this.txtDesc.TabIndex = 54;
            // 
            // frmGereTiposTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 497);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.butDeleteTipoTarefa);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGereTiposTarefas";
            this.Text = "frmGereTiposTarefas";
            this.Load += new System.EventHandler(this.frmGereTiposTarefas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2Button butDeleteTipoTarefa;
        private Guna.UI2.WinForms.Guna2TextBox txtDesc;
        private Guna.UI2.WinForms.Guna2Button btGravar;
    }
}