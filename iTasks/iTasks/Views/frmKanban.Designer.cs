namespace iTasks
{
    partial class frmKanban
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
            this.lstTodo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDoing = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirUtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirTiposDeTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasEmCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbBemVindo = new System.Windows.Forms.Label();
            this.butNovaTarefa = new Guna.UI2.WinForms.Guna2Button();
            this.butExeTarefa = new Guna.UI2.WinForms.Guna2Button();
            this.butReiniciarTarefa = new Guna.UI2.WinForms.Guna2Button();
            this.butTerminarTarefa = new Guna.UI2.WinForms.Guna2Button();
            this.butVerPrevConclusao = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTodo
            // 
            this.lstTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTodo.FormattingEnabled = true;
            this.lstTodo.ItemHeight = 16;
            this.lstTodo.Location = new System.Drawing.Point(4, 19);
            this.lstTodo.Margin = new System.Windows.Forms.Padding(4);
            this.lstTodo.Name = "lstTodo";
            this.lstTodo.Size = new System.Drawing.Size(395, 516);
            this.lstTodo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTodo);
            this.groupBox1.Location = new System.Drawing.Point(16, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(403, 539);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ToDo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDoing);
            this.groupBox2.Location = new System.Drawing.Point(427, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(403, 543);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doing";
            // 
            // lstDoing
            // 
            this.lstDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDoing.FormattingEnabled = true;
            this.lstDoing.ItemHeight = 16;
            this.lstDoing.Location = new System.Drawing.Point(4, 19);
            this.lstDoing.Margin = new System.Windows.Forms.Padding(4);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(395, 520);
            this.lstDoing.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDone);
            this.groupBox3.Location = new System.Drawing.Point(837, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(403, 543);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Done";
            // 
            // lstDone
            // 
            this.lstDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 16;
            this.lstDone.Location = new System.Drawing.Point(4, 19);
            this.lstDone.Margin = new System.Windows.Forms.Padding(4);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(395, 520);
            this.lstDone.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.utilizadoresToolStripMenuItem,
            this.listagensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.exportarParaCSVToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exportarParaCSVToolStripMenuItem
            // 
            this.exportarParaCSVToolStripMenuItem.Name = "exportarParaCSVToolStripMenuItem";
            this.exportarParaCSVToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.exportarParaCSVToolStripMenuItem.Text = "Exportar Tarefas Concluídas para CSV";
            this.exportarParaCSVToolStripMenuItem.Click += new System.EventHandler(this.exportarParaCSVToolStripMenuItem_Click);
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirUtilizadoresToolStripMenuItem,
            this.gerirTiposDeTarefasToolStripMenuItem});
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.utilizadoresToolStripMenuItem.Text = "Gestão da Aplicação";
            // 
            // gerirUtilizadoresToolStripMenuItem
            // 
            this.gerirUtilizadoresToolStripMenuItem.Name = "gerirUtilizadoresToolStripMenuItem";
            this.gerirUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.gerirUtilizadoresToolStripMenuItem.Text = "Gerir Utilizadores";
            this.gerirUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.gerirUtilizadoresToolStripMenuItem_Click);
            // 
            // gerirTiposDeTarefasToolStripMenuItem
            // 
            this.gerirTiposDeTarefasToolStripMenuItem.Name = "gerirTiposDeTarefasToolStripMenuItem";
            this.gerirTiposDeTarefasToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.gerirTiposDeTarefasToolStripMenuItem.Text = "Gerir Tipos de Tarefas";
            this.gerirTiposDeTarefasToolStripMenuItem.Click += new System.EventHandler(this.gerirTiposDeTarefasToolStripMenuItem_Click);
            // 
            // listagensToolStripMenuItem
            // 
            this.listagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefasTerminadasToolStripMenuItem,
            this.tarefasEmCursoToolStripMenuItem});
            this.listagensToolStripMenuItem.Name = "listagensToolStripMenuItem";
            this.listagensToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.listagensToolStripMenuItem.Text = "Listagens";
            // 
            // tarefasTerminadasToolStripMenuItem
            // 
            this.tarefasTerminadasToolStripMenuItem.Name = "tarefasTerminadasToolStripMenuItem";
            this.tarefasTerminadasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tarefasTerminadasToolStripMenuItem.Text = "Tarefas Concluídas";
            this.tarefasTerminadasToolStripMenuItem.Click += new System.EventHandler(this.tarefasTerminadasToolStripMenuItem_Click);
            // 
            // tarefasEmCursoToolStripMenuItem
            // 
            this.tarefasEmCursoToolStripMenuItem.Name = "tarefasEmCursoToolStripMenuItem";
            this.tarefasEmCursoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tarefasEmCursoToolStripMenuItem.Text = "Tarefas em Curso";
            this.tarefasEmCursoToolStripMenuItem.Click += new System.EventHandler(this.tarefasEmCursoToolStripMenuItem_Click);
            // 
            // lbBemVindo
            // 
            this.lbBemVindo.AutoSize = true;
            this.lbBemVindo.Location = new System.Drawing.Point(1037, 42);
            this.lbBemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBemVindo.Name = "lbBemVindo";
            this.lbBemVindo.Size = new System.Drawing.Size(187, 16);
            this.lbBemVindo.TabIndex = 9;
            this.lbBemVindo.Text = "Bem vindo: <Nome Utilizador>";
            // 
            // butNovaTarefa
            // 
            this.butNovaTarefa.BorderRadius = 7;
            this.butNovaTarefa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butNovaTarefa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butNovaTarefa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butNovaTarefa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butNovaTarefa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.butNovaTarefa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butNovaTarefa.ForeColor = System.Drawing.Color.White;
            this.butNovaTarefa.IndicateFocus = true;
            this.butNovaTarefa.Location = new System.Drawing.Point(20, 618);
            this.butNovaTarefa.Name = "butNovaTarefa";
            this.butNovaTarefa.Size = new System.Drawing.Size(139, 28);
            this.butNovaTarefa.TabIndex = 11;
            this.butNovaTarefa.Text = "Nova Tarefa";
            this.butNovaTarefa.Click += new System.EventHandler(this.butNovaTarefa_Click);
            // 
            // butExeTarefa
            // 
            this.butExeTarefa.BorderRadius = 7;
            this.butExeTarefa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butExeTarefa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butExeTarefa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butExeTarefa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butExeTarefa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.butExeTarefa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butExeTarefa.ForeColor = System.Drawing.Color.White;
            this.butExeTarefa.IndicateFocus = true;
            this.butExeTarefa.Location = new System.Drawing.Point(230, 618);
            this.butExeTarefa.Name = "butExeTarefa";
            this.butExeTarefa.Size = new System.Drawing.Size(195, 28);
            this.butExeTarefa.TabIndex = 12;
            this.butExeTarefa.Text = "Executar Tarefa >>";
            this.butExeTarefa.Click += new System.EventHandler(this.butExeTarefa_Click);
            // 
            // butReiniciarTarefa
            // 
            this.butReiniciarTarefa.BorderRadius = 7;
            this.butReiniciarTarefa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butReiniciarTarefa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butReiniciarTarefa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butReiniciarTarefa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butReiniciarTarefa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.butReiniciarTarefa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butReiniciarTarefa.ForeColor = System.Drawing.Color.White;
            this.butReiniciarTarefa.IndicateFocus = true;
            this.butReiniciarTarefa.Location = new System.Drawing.Point(431, 618);
            this.butReiniciarTarefa.Name = "butReiniciarTarefa";
            this.butReiniciarTarefa.Size = new System.Drawing.Size(192, 28);
            this.butReiniciarTarefa.TabIndex = 13;
            this.butReiniciarTarefa.Text = "<< Reiniciar Tarefa";
            this.butReiniciarTarefa.Click += new System.EventHandler(this.butReiniciarTarefa_Click);
            // 
            // butTerminarTarefa
            // 
            this.butTerminarTarefa.BorderRadius = 7;
            this.butTerminarTarefa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTerminarTarefa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTerminarTarefa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTerminarTarefa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTerminarTarefa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.butTerminarTarefa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butTerminarTarefa.ForeColor = System.Drawing.Color.White;
            this.butTerminarTarefa.IndicateFocus = true;
            this.butTerminarTarefa.Location = new System.Drawing.Point(629, 618);
            this.butTerminarTarefa.Name = "butTerminarTarefa";
            this.butTerminarTarefa.Size = new System.Drawing.Size(192, 28);
            this.butTerminarTarefa.TabIndex = 14;
            this.butTerminarTarefa.Text = "Terminar Tarefa >>";
            this.butTerminarTarefa.Click += new System.EventHandler(this.butTerminarTarefa_Click);
            // 
            // butVerPrevConclusao
            // 
            this.butVerPrevConclusao.BorderRadius = 7;
            this.butVerPrevConclusao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butVerPrevConclusao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butVerPrevConclusao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butVerPrevConclusao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butVerPrevConclusao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.butVerPrevConclusao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butVerPrevConclusao.ForeColor = System.Drawing.Color.White;
            this.butVerPrevConclusao.IndicateFocus = true;
            this.butVerPrevConclusao.Location = new System.Drawing.Point(16, 36);
            this.butVerPrevConclusao.Name = "butVerPrevConclusao";
            this.butVerPrevConclusao.Size = new System.Drawing.Size(223, 28);
            this.butVerPrevConclusao.TabIndex = 15;
            this.butVerPrevConclusao.Text = "Ver Previsão de Conclusão";
            this.butVerPrevConclusao.Click += new System.EventHandler(this.butVerPrevConclusao_Click);
            // 
            // frmKanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 661);
            this.Controls.Add(this.butVerPrevConclusao);
            this.Controls.Add(this.butTerminarTarefa);
            this.Controls.Add(this.butExeTarefa);
            this.Controls.Add(this.butReiniciarTarefa);
            this.Controls.Add(this.butNovaTarefa);
            this.Controls.Add(this.lbBemVindo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKanban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban";
            this.Load += new System.EventHandler(this.frmKanban_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDoing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirUtilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirTiposDeTarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasTerminadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasEmCursoToolStripMenuItem;
        private System.Windows.Forms.Label lbBemVindo;
        private Guna.UI2.WinForms.Guna2Button butExeTarefa;
        private Guna.UI2.WinForms.Guna2Button butTerminarTarefa;
        private Guna.UI2.WinForms.Guna2Button butReiniciarTarefa;
        private Guna.UI2.WinForms.Guna2Button butNovaTarefa;
        private Guna.UI2.WinForms.Guna2Button butVerPrevConclusao;
    }
}