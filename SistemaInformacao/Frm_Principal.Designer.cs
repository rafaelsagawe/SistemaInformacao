﻿
namespace SistemaInformacao
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StrpStsLbl_DataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.StrpStsLbl_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.StrpStsLbl_UserNameFull = new System.Windows.Forms.ToolStripStatusLabel();
            this.StrpStsLbl_IdUnidade = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StrpBtn_Fechar = new System.Windows.Forms.ToolStripButton();
            this.StrpButton_Max = new System.Windows.Forms.ToolStripButton();
            this.StrpBtn_Restaurar = new System.Windows.Forms.ToolStripButton();
            this.StrpBtn_Users = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StrpBtn_Unidade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StrpBtn_AunoAno = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosPorAnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.StrpStsLbl_DataHora,
            this.StrpStsLbl_UserName,
            this.StrpStsLbl_UserNameFull,
            this.StrpStsLbl_IdUnidade});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 19);
            this.toolStripStatusLabel2.Text = "Data e hora:";
            // 
            // StrpStsLbl_DataHora
            // 
            this.StrpStsLbl_DataHora.Name = "StrpStsLbl_DataHora";
            this.StrpStsLbl_DataHora.Size = new System.Drawing.Size(12, 19);
            this.StrpStsLbl_DataHora.Text = "-";
            // 
            // StrpStsLbl_UserName
            // 
            this.StrpStsLbl_UserName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StrpStsLbl_UserName.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.StrpStsLbl_UserName.Name = "StrpStsLbl_UserName";
            this.StrpStsLbl_UserName.Size = new System.Drawing.Size(122, 19);
            this.StrpStsLbl_UserName.Text = "toolStripStatusLabel1";
            // 
            // StrpStsLbl_UserNameFull
            // 
            this.StrpStsLbl_UserNameFull.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StrpStsLbl_UserNameFull.Name = "StrpStsLbl_UserNameFull";
            this.StrpStsLbl_UserNameFull.Size = new System.Drawing.Size(122, 19);
            this.StrpStsLbl_UserNameFull.Text = "toolStripStatusLabel2";
            // 
            // StrpStsLbl_IdUnidade
            // 
            this.StrpStsLbl_IdUnidade.Name = "StrpStsLbl_IdUnidade";
            this.StrpStsLbl_IdUnidade.Size = new System.Drawing.Size(118, 19);
            this.StrpStsLbl_IdUnidade.Text = "toolStripStatusLabel3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StrpBtn_Fechar,
            this.StrpButton_Max,
            this.StrpBtn_Restaurar,
            this.StrpBtn_Users,
            this.toolStripSeparator1,
            this.StrpBtn_Unidade,
            this.toolStripSeparator2,
            this.StrpBtn_AunoAno});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(908, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // StrpBtn_Fechar
            // 
            this.StrpBtn_Fechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StrpBtn_Fechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StrpBtn_Fechar.Image = global::SistemaInformacao.Properties.Resources.close;
            this.StrpBtn_Fechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StrpBtn_Fechar.Name = "StrpBtn_Fechar";
            this.StrpBtn_Fechar.Size = new System.Drawing.Size(23, 22);
            this.StrpBtn_Fechar.Text = "Voltar";
            this.StrpBtn_Fechar.Click += new System.EventHandler(this.StrpBtn_Fechar_Click);
            // 
            // StrpButton_Max
            // 
            this.StrpButton_Max.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StrpButton_Max.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StrpButton_Max.Image = global::SistemaInformacao.Properties.Resources.move;
            this.StrpButton_Max.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StrpButton_Max.Name = "StrpButton_Max";
            this.StrpButton_Max.Size = new System.Drawing.Size(23, 22);
            this.StrpButton_Max.Text = "Maxmizar";
            this.StrpButton_Max.Click += new System.EventHandler(this.StrpButton_Max_Click);
            // 
            // StrpBtn_Restaurar
            // 
            this.StrpBtn_Restaurar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StrpBtn_Restaurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StrpBtn_Restaurar.Image = global::SistemaInformacao.Properties.Resources.minimize;
            this.StrpBtn_Restaurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StrpBtn_Restaurar.Name = "StrpBtn_Restaurar";
            this.StrpBtn_Restaurar.Size = new System.Drawing.Size(23, 22);
            this.StrpBtn_Restaurar.Text = "Restaurar";
            this.StrpBtn_Restaurar.Click += new System.EventHandler(this.StrpBtn_Restaurar_Click);
            // 
            // StrpBtn_Users
            // 
            this.StrpBtn_Users.Image = ((System.Drawing.Image)(resources.GetObject("StrpBtn_Users.Image")));
            this.StrpBtn_Users.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StrpBtn_Users.Name = "StrpBtn_Users";
            this.StrpBtn_Users.Size = new System.Drawing.Size(72, 22);
            this.StrpBtn_Users.Text = "Usuários";
            this.StrpBtn_Users.Click += new System.EventHandler(this.StrpBtn_Users_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // StrpBtn_Unidade
            // 
            this.StrpBtn_Unidade.Image = ((System.Drawing.Image)(resources.GetObject("StrpBtn_Unidade.Image")));
            this.StrpBtn_Unidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StrpBtn_Unidade.Name = "StrpBtn_Unidade";
            this.StrpBtn_Unidade.Size = new System.Drawing.Size(71, 22);
            this.StrpBtn_Unidade.Text = "Unidade";
            this.StrpBtn_Unidade.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // StrpBtn_AunoAno
            // 
            this.StrpBtn_AunoAno.Image = ((System.Drawing.Image)(resources.GetObject("StrpBtn_AunoAno.Image")));
            this.StrpBtn_AunoAno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StrpBtn_AunoAno.Name = "StrpBtn_AunoAno";
            this.StrpBtn_AunoAno.Size = new System.Drawing.Size(110, 22);
            this.StrpBtn_AunoAno.Text = "Alunos por Ano";
            this.StrpBtn_AunoAno.Click += new System.EventHandler(this.StrpBtn_AunoAno_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.unidadeToolStripMenuItem,
            this.servidorToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.sairToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.toolStripSeparator3,
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.sairToolStripMenuItem.Text = "Administração";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(116, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // unidadeToolStripMenuItem
            // 
            this.unidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosPorAnoToolStripMenuItem});
            this.unidadeToolStripMenuItem.Name = "unidadeToolStripMenuItem";
            this.unidadeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.unidadeToolStripMenuItem.Text = "Unidade";
            // 
            // alunosPorAnoToolStripMenuItem
            // 
            this.alunosPorAnoToolStripMenuItem.Name = "alunosPorAnoToolStripMenuItem";
            this.alunosPorAnoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.alunosPorAnoToolStripMenuItem.Text = "QTD Alunos por Ano";
            this.alunosPorAnoToolStripMenuItem.Click += new System.EventHandler(this.alunosPorAnoToolStripMenuItem_Click);
            // 
            // servidorToolStripMenuItem
            // 
            this.servidorToolStripMenuItem.Name = "servidorToolStripMenuItem";
            this.servidorToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.servidorToolStripMenuItem.Text = "Servidor";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // sairToolStripMenuItem2
            // 
            this.sairToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem2.BackgroundImage = global::SistemaInformacao.Properties.Resources.close;
            this.sairToolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sairToolStripMenuItem2.Checked = true;
            this.sairToolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            this.sairToolStripMenuItem2.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem2.Text = "Sair";
            this.sairToolStripMenuItem2.Click += new System.EventHandler(this.sairToolStripMenuItem2_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 517);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StrpButton_Max;
        private System.Windows.Forms.ToolStripButton StrpBtn_Fechar;
        private System.Windows.Forms.ToolStripButton StrpBtn_Restaurar;
        private System.Windows.Forms.ToolStripStatusLabel StrpStsLbl_DataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel StrpStsLbl_UserName;
        private System.Windows.Forms.ToolStripButton StrpBtn_Users;
        private System.Windows.Forms.ToolStripStatusLabel StrpStsLbl_UserNameFull;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton StrpBtn_Unidade;
        private System.Windows.Forms.ToolStripStatusLabel StrpStsLbl_IdUnidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton StrpBtn_AunoAno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alunosPorAnoToolStripMenuItem;
    }
}