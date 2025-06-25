namespace iTasks
{
    partial class frmGereUtilizadores
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstListaGestores = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAddGest = new Guna.UI2.WinForms.Guna2Button();
            this.chkGereUtilizadores = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbDepartamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIdGestor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPasswordGestor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsernameGestor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeGestor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDeleteGestor = new Guna.UI2.WinForms.Guna2Button();
            this.btGravarGestor = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btAddProg = new Guna.UI2.WinForms.Guna2Button();
            this.cbGestorProg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbNivelProg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIdProg = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPasswordProg = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsernameProg = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeProg = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstListaProgramadores = new System.Windows.Forms.ListBox();
            this.btDeleteProg = new Guna.UI2.WinForms.Guna2Button();
            this.btGravarProg = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListaGestores);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 560);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // lstListaGestores
            // 
            this.lstListaGestores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaGestores.FormattingEnabled = true;
            this.lstListaGestores.ItemHeight = 16;
            this.lstListaGestores.Location = new System.Drawing.Point(4, 19);
            this.lstListaGestores.Margin = new System.Windows.Forms.Padding(4);
            this.lstListaGestores.Name = "lstListaGestores";
            this.lstListaGestores.Size = new System.Drawing.Size(357, 537);
            this.lstListaGestores.TabIndex = 0;
            this.lstListaGestores.SelectedIndexChanged += new System.EventHandler(this.lstListaGestores_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAddGest);
            this.groupBox2.Controls.Add(this.chkGereUtilizadores);
            this.groupBox2.Controls.Add(this.cbDepartamento);
            this.groupBox2.Controls.Add(this.txtIdGestor);
            this.groupBox2.Controls.Add(this.txtPasswordGestor);
            this.groupBox2.Controls.Add(this.txtUsernameGestor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNomeGestor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btDeleteGestor);
            this.groupBox2.Controls.Add(this.btGravarGestor);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(681, 591);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestores";
            // 
            // btAddGest
            // 
            this.btAddGest.BorderRadius = 7;
            this.btAddGest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddGest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddGest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddGest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddGest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.btAddGest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btAddGest.ForeColor = System.Drawing.Color.White;
            this.btAddGest.IndicateFocus = true;
            this.btAddGest.Location = new System.Drawing.Point(389, 409);
            this.btAddGest.Name = "btAddGest";
            this.btAddGest.Size = new System.Drawing.Size(267, 28);
            this.btAddGest.TabIndex = 53;
            this.btAddGest.Text = "Adicionar Dados";
            this.btAddGest.Click += new System.EventHandler(this.btAddGest_Click);
            // 
            // chkGereUtilizadores
            // 
            this.chkGereUtilizadores.AutoSize = true;
            this.chkGereUtilizadores.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkGereUtilizadores.CheckedState.BorderRadius = 0;
            this.chkGereUtilizadores.CheckedState.BorderThickness = 0;
            this.chkGereUtilizadores.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkGereUtilizadores.Location = new System.Drawing.Point(391, 307);
            this.chkGereUtilizadores.Name = "chkGereUtilizadores";
            this.chkGereUtilizadores.Size = new System.Drawing.Size(133, 20);
            this.chkGereUtilizadores.TabIndex = 52;
            this.chkGereUtilizadores.Text = "Gere Utilizadores";
            this.chkGereUtilizadores.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkGereUtilizadores.UncheckedState.BorderRadius = 0;
            this.chkGereUtilizadores.UncheckedState.BorderThickness = 0;
            this.chkGereUtilizadores.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.cbDepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDepartamento.ItemHeight = 30;
            this.cbDepartamento.Location = new System.Drawing.Point(391, 255);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(265, 36);
            this.cbDepartamento.TabIndex = 51;
            // 
            // txtIdGestor
            // 
            this.txtIdGestor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtIdGestor.BorderRadius = 7;
            this.txtIdGestor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdGestor.DefaultText = "";
            this.txtIdGestor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdGestor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdGestor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdGestor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdGestor.Enabled = false;
            this.txtIdGestor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdGestor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdGestor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdGestor.Location = new System.Drawing.Point(391, 45);
            this.txtIdGestor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdGestor.Name = "txtIdGestor";
            this.txtIdGestor.PlaceholderText = "Id";
            this.txtIdGestor.SelectedText = "";
            this.txtIdGestor.Size = new System.Drawing.Size(134, 30);
            this.txtIdGestor.TabIndex = 50;
            // 
            // txtPasswordGestor
            // 
            this.txtPasswordGestor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtPasswordGestor.BorderRadius = 7;
            this.txtPasswordGestor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordGestor.DefaultText = "";
            this.txtPasswordGestor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordGestor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordGestor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordGestor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordGestor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordGestor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordGestor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordGestor.Location = new System.Drawing.Point(391, 202);
            this.txtPasswordGestor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordGestor.Name = "txtPasswordGestor";
            this.txtPasswordGestor.PlaceholderText = "Password";
            this.txtPasswordGestor.SelectedText = "";
            this.txtPasswordGestor.Size = new System.Drawing.Size(266, 30);
            this.txtPasswordGestor.TabIndex = 49;
            // 
            // txtUsernameGestor
            // 
            this.txtUsernameGestor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtUsernameGestor.BorderRadius = 7;
            this.txtUsernameGestor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameGestor.DefaultText = "";
            this.txtUsernameGestor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameGestor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameGestor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameGestor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameGestor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameGestor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsernameGestor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameGestor.Location = new System.Drawing.Point(391, 149);
            this.txtUsernameGestor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsernameGestor.Name = "txtUsernameGestor";
            this.txtUsernameGestor.PlaceholderText = "Username";
            this.txtUsernameGestor.SelectedText = "";
            this.txtUsernameGestor.Size = new System.Drawing.Size(266, 30);
            this.txtUsernameGestor.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Departamento:";
            // 
            // txtNomeGestor
            // 
            this.txtNomeGestor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtNomeGestor.BorderRadius = 7;
            this.txtNomeGestor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeGestor.DefaultText = "";
            this.txtNomeGestor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeGestor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeGestor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeGestor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeGestor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeGestor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomeGestor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeGestor.Location = new System.Drawing.Point(391, 97);
            this.txtNomeGestor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeGestor.Name = "txtNomeGestor";
            this.txtNomeGestor.PlaceholderText = "Nome";
            this.txtNomeGestor.SelectedText = "";
            this.txtNomeGestor.Size = new System.Drawing.Size(266, 30);
            this.txtNomeGestor.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Username:";
            // 
            // btDeleteGestor
            // 
            this.btDeleteGestor.BorderRadius = 7;
            this.btDeleteGestor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDeleteGestor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDeleteGestor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDeleteGestor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDeleteGestor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.btDeleteGestor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btDeleteGestor.ForeColor = System.Drawing.Color.White;
            this.btDeleteGestor.IndicateFocus = true;
            this.btDeleteGestor.Location = new System.Drawing.Point(390, 374);
            this.btDeleteGestor.Name = "btDeleteGestor";
            this.btDeleteGestor.Size = new System.Drawing.Size(267, 28);
            this.btDeleteGestor.TabIndex = 45;
            this.btDeleteGestor.Text = "Eleminar";
            this.btDeleteGestor.Click += new System.EventHandler(this.btDeleteProg_Click);
            // 
            // btGravarGestor
            // 
            this.btGravarGestor.BorderRadius = 7;
            this.btGravarGestor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btGravarGestor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btGravarGestor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btGravarGestor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btGravarGestor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.btGravarGestor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btGravarGestor.ForeColor = System.Drawing.Color.White;
            this.btGravarGestor.IndicateFocus = true;
            this.btGravarGestor.Location = new System.Drawing.Point(390, 339);
            this.btGravarGestor.Name = "btGravarGestor";
            this.btGravarGestor.Size = new System.Drawing.Size(267, 28);
            this.btGravarGestor.TabIndex = 46;
            this.btGravarGestor.Text = "Gravar Dados";
            this.btGravarGestor.Click += new System.EventHandler(this.btGravarGestor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btAddProg);
            this.groupBox3.Controls.Add(this.cbGestorProg);
            this.groupBox3.Controls.Add(this.cbNivelProg);
            this.groupBox3.Controls.Add(this.txtIdProg);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtPasswordProg);
            this.groupBox3.Controls.Add(this.txtUsernameProg);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtNomeProg);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btDeleteProg);
            this.groupBox3.Controls.Add(this.btGravarProg);
            this.groupBox3.Location = new System.Drawing.Point(705, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(681, 591);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Programadores";
            // 
            // btAddProg
            // 
            this.btAddProg.BorderRadius = 7;
            this.btAddProg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddProg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddProg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddProg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddProg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.btAddProg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btAddProg.ForeColor = System.Drawing.Color.White;
            this.btAddProg.IndicateFocus = true;
            this.btAddProg.Location = new System.Drawing.Point(393, 443);
            this.btAddProg.Name = "btAddProg";
            this.btAddProg.Size = new System.Drawing.Size(267, 28);
            this.btAddProg.TabIndex = 62;
            this.btAddProg.Text = "Adicionar Dados";
            this.btAddProg.Click += new System.EventHandler(this.btAddProg_Click);
            // 
            // cbGestorProg
            // 
            this.cbGestorProg.BackColor = System.Drawing.Color.Transparent;
            this.cbGestorProg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGestorProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGestorProg.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGestorProg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGestorProg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGestorProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGestorProg.ItemHeight = 30;
            this.cbGestorProg.Location = new System.Drawing.Point(392, 321);
            this.cbGestorProg.Name = "cbGestorProg";
            this.cbGestorProg.Size = new System.Drawing.Size(267, 36);
            this.cbGestorProg.TabIndex = 61;
            // 
            // cbNivelProg
            // 
            this.cbNivelProg.BackColor = System.Drawing.Color.Transparent;
            this.cbNivelProg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNivelProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelProg.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNivelProg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNivelProg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNivelProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNivelProg.ItemHeight = 30;
            this.cbNivelProg.Location = new System.Drawing.Point(392, 255);
            this.cbNivelProg.Name = "cbNivelProg";
            this.cbNivelProg.Size = new System.Drawing.Size(267, 36);
            this.cbNivelProg.TabIndex = 53;
            // 
            // txtIdProg
            // 
            this.txtIdProg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtIdProg.BorderRadius = 7;
            this.txtIdProg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdProg.DefaultText = "";
            this.txtIdProg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdProg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdProg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdProg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdProg.Enabled = false;
            this.txtIdProg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdProg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProg.Location = new System.Drawing.Point(393, 45);
            this.txtIdProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdProg.Name = "txtIdProg";
            this.txtIdProg.PlaceholderText = "Id";
            this.txtIdProg.SelectedText = "";
            this.txtIdProg.Size = new System.Drawing.Size(134, 30);
            this.txtIdProg.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 302);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Gestor:";
            // 
            // txtPasswordProg
            // 
            this.txtPasswordProg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtPasswordProg.BorderRadius = 7;
            this.txtPasswordProg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordProg.DefaultText = "";
            this.txtPasswordProg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordProg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordProg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordProg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordProg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordProg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordProg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordProg.Location = new System.Drawing.Point(393, 202);
            this.txtPasswordProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordProg.Name = "txtPasswordProg";
            this.txtPasswordProg.PlaceholderText = "Password";
            this.txtPasswordProg.SelectedText = "";
            this.txtPasswordProg.Size = new System.Drawing.Size(266, 30);
            this.txtPasswordProg.TabIndex = 59;
            // 
            // txtUsernameProg
            // 
            this.txtUsernameProg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtUsernameProg.BorderRadius = 7;
            this.txtUsernameProg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameProg.DefaultText = "";
            this.txtUsernameProg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameProg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameProg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameProg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameProg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameProg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsernameProg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameProg.Location = new System.Drawing.Point(393, 149);
            this.txtUsernameProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsernameProg.Name = "txtUsernameProg";
            this.txtUsernameProg.PlaceholderText = "Username";
            this.txtUsernameProg.SelectedText = "";
            this.txtUsernameProg.Size = new System.Drawing.Size(266, 30);
            this.txtUsernameProg.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nível de Experiência:";
            // 
            // txtNomeProg
            // 
            this.txtNomeProg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.txtNomeProg.BorderRadius = 7;
            this.txtNomeProg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeProg.DefaultText = "";
            this.txtNomeProg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeProg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeProg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeProg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeProg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeProg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomeProg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeProg.Location = new System.Drawing.Point(393, 97);
            this.txtNomeProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeProg.Name = "txtNomeProg";
            this.txtNomeProg.PlaceholderText = "Nome";
            this.txtNomeProg.SelectedText = "";
            this.txtNomeProg.Size = new System.Drawing.Size(266, 30);
            this.txtNomeProg.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(390, 183);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Password:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(390, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 55;
            this.label13.Text = "Username:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(390, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Id:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(390, 79);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = "Nome:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstListaProgramadores);
            this.groupBox4.Location = new System.Drawing.Point(8, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(365, 560);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista";
            // 
            // lstListaProgramadores
            // 
            this.lstListaProgramadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaProgramadores.FormattingEnabled = true;
            this.lstListaProgramadores.ItemHeight = 16;
            this.lstListaProgramadores.Location = new System.Drawing.Point(4, 19);
            this.lstListaProgramadores.Margin = new System.Windows.Forms.Padding(4);
            this.lstListaProgramadores.Name = "lstListaProgramadores";
            this.lstListaProgramadores.Size = new System.Drawing.Size(357, 537);
            this.lstListaProgramadores.TabIndex = 0;
            this.lstListaProgramadores.SelectedIndexChanged += new System.EventHandler(this.lstListaProgramadores_SelectedIndexChanged);
            // 
            // btDeleteProg
            // 
            this.btDeleteProg.BorderRadius = 7;
            this.btDeleteProg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDeleteProg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDeleteProg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDeleteProg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDeleteProg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.btDeleteProg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btDeleteProg.ForeColor = System.Drawing.Color.White;
            this.btDeleteProg.IndicateFocus = true;
            this.btDeleteProg.Location = new System.Drawing.Point(393, 409);
            this.btDeleteProg.Name = "btDeleteProg";
            this.btDeleteProg.Size = new System.Drawing.Size(267, 28);
            this.btDeleteProg.TabIndex = 47;
            this.btDeleteProg.Text = "Eleminar";
            this.btDeleteProg.Click += new System.EventHandler(this.btDeleteProg_Click);
            // 
            // btGravarProg
            // 
            this.btGravarProg.BorderRadius = 7;
            this.btGravarProg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btGravarProg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btGravarProg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btGravarProg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btGravarProg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(113)))));
            this.btGravarProg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btGravarProg.ForeColor = System.Drawing.Color.White;
            this.btGravarProg.IndicateFocus = true;
            this.btGravarProg.Location = new System.Drawing.Point(393, 374);
            this.btGravarProg.Name = "btGravarProg";
            this.btGravarProg.Size = new System.Drawing.Size(267, 28);
            this.btGravarProg.TabIndex = 48;
            this.btGravarProg.Text = "Gravar Dados";
            this.btGravarProg.Click += new System.EventHandler(this.btGravarProg_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGereUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGereUtilizadores";
            this.Text = "frmListaUtilizadores";
            this.Load += new System.EventHandler(this.frmGereUtilizadores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstListaGestores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstListaProgramadores;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btDeleteGestor;
        private Guna.UI2.WinForms.Guna2Button btGravarGestor;
        private Guna.UI2.WinForms.Guna2Button btDeleteProg;
        private Guna.UI2.WinForms.Guna2Button btGravarProg;
        private Guna.UI2.WinForms.Guna2TextBox txtIdGestor;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordGestor;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameGestor;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeGestor;
        private Guna.UI2.WinForms.Guna2CheckBox chkGereUtilizadores;
        private Guna.UI2.WinForms.Guna2ComboBox cbDepartamento;
        private Guna.UI2.WinForms.Guna2ComboBox cbNivelProg;
        private Guna.UI2.WinForms.Guna2TextBox txtIdProg;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordProg;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameProg;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeProg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox cbGestorProg;
        private Guna.UI2.WinForms.Guna2Button btAddGest;
        private Guna.UI2.WinForms.Guna2Button btAddProg;
    }
}