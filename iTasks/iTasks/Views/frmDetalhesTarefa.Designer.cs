﻿namespace iTasks
{
    partial class frmDetalhesTarefa
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProgramador = new System.Windows.Forms.ComboBox();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipoTarefa = new System.Windows.Forms.ComboBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataRealini = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdataRealFim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataCriacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butGravar = new System.Windows.Forms.Button();
            this.butFechar = new System.Windows.Forms.Button();
            this.txtStoryPoints = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(176, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(81, 22);
            this.txtId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Programador:";
            // 
            // comboBoxProgramador
            // 
            this.comboBoxProgramador.FormattingEnabled = true;
            this.comboBoxProgramador.Location = new System.Drawing.Point(176, 241);
            this.comboBoxProgramador.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProgramador.Name = "comboBoxProgramador";
            this.comboBoxProgramador.Size = new System.Drawing.Size(413, 24);
            this.comboBoxProgramador.TabIndex = 3;
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(176, 274);
            this.txtOrdem.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(81, 22);
            this.txtOrdem.TabIndex = 4;
            this.txtOrdem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrdem_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ordem:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(176, 176);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(565, 22);
            this.txtDesc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo de Tarefa:";
            // 
            // comboBoxTipoTarefa
            // 
            this.comboBoxTipoTarefa.FormattingEnabled = true;
            this.comboBoxTipoTarefa.Location = new System.Drawing.Point(176, 208);
            this.comboBoxTipoTarefa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoTarefa.Name = "comboBoxTipoTarefa";
            this.comboBoxTipoTarefa.Size = new System.Drawing.Size(413, 24);
            this.comboBoxTipoTarefa.TabIndex = 2;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(176, 343);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(265, 22);
            this.dtInicio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data Prevista de Início:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Prevista de Fim:";
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(176, 375);
            this.dtFim.Margin = new System.Windows.Forms.Padding(4);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(265, 22);
            this.dtFim.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(568, 15);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(173, 22);
            this.txtEstado.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado Atual:";
            // 
            // txtDataRealini
            // 
            this.txtDataRealini.Location = new System.Drawing.Point(176, 52);
            this.txtDataRealini.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataRealini.Name = "txtDataRealini";
            this.txtDataRealini.ReadOnly = true;
            this.txtDataRealini.Size = new System.Drawing.Size(179, 22);
            this.txtDataRealini.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Data Real de Início:";
            // 
            // txtdataRealFim
            // 
            this.txtdataRealFim.Location = new System.Drawing.Point(176, 84);
            this.txtdataRealFim.Margin = new System.Windows.Forms.Padding(4);
            this.txtdataRealFim.Name = "txtdataRealFim";
            this.txtdataRealFim.ReadOnly = true;
            this.txtdataRealFim.Size = new System.Drawing.Size(179, 22);
            this.txtdataRealFim.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Data Real de Fim:";
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.Location = new System.Drawing.Point(568, 52);
            this.txtDataCriacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.ReadOnly = true;
            this.txtDataCriacao.Size = new System.Drawing.Size(173, 22);
            this.txtDataCriacao.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Data Criação:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(11, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 2);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(11, 411);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 2);
            this.panel2.TabIndex = 27;
            // 
            // butGravar
            // 
            this.butGravar.Location = new System.Drawing.Point(421, 428);
            this.butGravar.Margin = new System.Windows.Forms.Padding(4);
            this.butGravar.Name = "butGravar";
            this.butGravar.Size = new System.Drawing.Size(188, 28);
            this.butGravar.TabIndex = 8;
            this.butGravar.Text = "Gravar Dados";
            this.butGravar.UseVisualStyleBackColor = true;
            this.butGravar.Click += new System.EventHandler(this.butGravar_Click);
            // 
            // butFechar
            // 
            this.butFechar.Location = new System.Drawing.Point(617, 428);
            this.butFechar.Margin = new System.Windows.Forms.Padding(4);
            this.butFechar.Name = "butFechar";
            this.butFechar.Size = new System.Drawing.Size(139, 28);
            this.butFechar.TabIndex = 9;
            this.butFechar.Text = "Fechar";
            this.butFechar.UseVisualStyleBackColor = true;
            this.butFechar.Click += new System.EventHandler(this.butFechar_Click);
            // 
            // txtStoryPoints
            // 
            this.txtStoryPoints.Location = new System.Drawing.Point(176, 306);
            this.txtStoryPoints.Margin = new System.Windows.Forms.Padding(4);
            this.txtStoryPoints.Name = "txtStoryPoints";
            this.txtStoryPoints.Size = new System.Drawing.Size(81, 22);
            this.txtStoryPoints.TabIndex = 5;
            this.txtStoryPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoryPoints_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 310);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "StoryPoints:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(176, 146);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(210, 22);
            this.txtTitulo.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Título da Tarefa:";
            // 
            // frmDetalhesTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 498);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtStoryPoints);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.butFechar);
            this.Controls.Add(this.butGravar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDataCriacao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdataRealFim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDataRealini);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTipoTarefa);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrdem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProgramador);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetalhesTarefa";
            this.Text = "frmDetalhesTarefa";
            this.Load += new System.EventHandler(this.frmDetalhesTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProgramador;
        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTipoTarefa;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDataRealini;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdataRealFim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDataCriacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butGravar;
        private System.Windows.Forms.Button butFechar;
        private System.Windows.Forms.TextBox txtStoryPoints;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label13;
    }
}