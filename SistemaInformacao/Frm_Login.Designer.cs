
namespace SistemaInformacao
{
    partial class Frm_Login
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
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.txtBx_User = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBx_Senha = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoInformacaoDataSet = new SistemaInformacao.gestaoInformacaoDataSet();
            this.usuariosTableAdapter = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager();
            this.lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.lbl_NomeCompleto = new System.Windows.Forms.Label();
            this.lbl_IdUnidade = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Entrar.Location = new System.Drawing.Point(7, 284);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(94, 23);
            this.Btn_Entrar.TabIndex = 2;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.Location = new System.Drawing.Point(117, 284);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(90, 23);
            this.Btn_Sair.TabIndex = 3;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // txtBx_User
            // 
            this.txtBx_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_User.Location = new System.Drawing.Point(6, 19);
            this.txtBx_User.Name = "txtBx_User";
            this.txtBx_User.Size = new System.Drawing.Size(188, 20);
            this.txtBx_User.TabIndex = 0;
            this.txtBx_User.TextChanged += new System.EventHandler(this.txtBx_User_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBx_User);
            this.groupBox1.Location = new System.Drawing.Point(7, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBx_Senha);
            this.groupBox2.Location = new System.Drawing.Point(7, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Senha";
            // 
            // txtBx_Senha
            // 
            this.txtBx_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Senha.Location = new System.Drawing.Point(6, 19);
            this.txtBx_Senha.Name = "txtBx_Senha";
            this.txtBx_Senha.PasswordChar = '*';
            this.txtBx_Senha.Size = new System.Drawing.Size(188, 20);
            this.txtBx_Senha.TabIndex = 0;
            this.txtBx_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_Senha_KeyPress);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_compelto";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_compelto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "user_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "user_pass";
            this.dataGridViewTextBoxColumn4.HeaderText = "user_pass";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_unidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_unidade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.gestaoInformacaoDataSet;
            // 
            // gestaoInformacaoDataSet
            // 
            this.gestaoInformacaoDataSet.DataSetName = "gestaoInformacaoDataSet";
            this.gestaoInformacaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.anoSerieTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.imp_supreTableAdapter = null;
            this.tableAdapterManager.TurmaUnidadeTableAdapter = null;
            this.tableAdapterManager.unidadeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // lbl_NomeUsuario
            // 
            this.lbl_NomeUsuario.AutoSize = true;
            this.lbl_NomeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "user_name", true));
            this.lbl_NomeUsuario.Location = new System.Drawing.Point(130, 23);
            this.lbl_NomeUsuario.Name = "lbl_NomeUsuario";
            this.lbl_NomeUsuario.Size = new System.Drawing.Size(71, 13);
            this.lbl_NomeUsuario.TabIndex = 4;
            this.lbl_NomeUsuario.Text = "NomeUsuario";
            // 
            // lbl_NomeCompleto
            // 
            this.lbl_NomeCompleto.AutoSize = true;
            this.lbl_NomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nome_compelto", true));
            this.lbl_NomeCompleto.Location = new System.Drawing.Point(130, 47);
            this.lbl_NomeCompleto.Name = "lbl_NomeCompleto";
            this.lbl_NomeCompleto.Size = new System.Drawing.Size(79, 13);
            this.lbl_NomeCompleto.TabIndex = 5;
            this.lbl_NomeCompleto.Text = "NomeCompleto";
            // 
            // lbl_IdUnidade
            // 
            this.lbl_IdUnidade.AutoSize = true;
            this.lbl_IdUnidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "id_unidade", true));
            this.lbl_IdUnidade.Location = new System.Drawing.Point(130, 72);
            this.lbl_IdUnidade.Name = "lbl_IdUnidade";
            this.lbl_IdUnidade.Size = new System.Drawing.Size(56, 13);
            this.lbl_IdUnidade.TabIndex = 6;
            this.lbl_IdUnidade.Text = "IdUnidade";
            this.lbl_IdUnidade.Click += new System.EventHandler(this.lbl_IdUnidade_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(218, 318);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_IdUnidade);
            this.Controls.Add(this.lbl_NomeCompleto);
            this.Controls.Add(this.lbl_NomeUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Login_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Login_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Entrar;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.TextBox txtBx_User;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBx_Senha;
        private gestaoInformacaoDataSet gestaoInformacaoDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private gestaoInformacaoDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private gestaoInformacaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lbl_NomeUsuario;
        private System.Windows.Forms.Label lbl_NomeCompleto;
        private System.Windows.Forms.Label lbl_IdUnidade;
    }
}