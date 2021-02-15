
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
            this.btn_TestSQL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gestaoInformacaoDataSet = new SistemaInformacao.gestaoInformacaoDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Location = new System.Drawing.Point(7, 284);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Entrar.TabIndex = 2;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(132, 284);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sair.TabIndex = 3;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // txtBx_User
            // 
            this.txtBx_User.Location = new System.Drawing.Point(6, 19);
            this.txtBx_User.Name = "txtBx_User";
            this.txtBx_User.Size = new System.Drawing.Size(188, 20);
            this.txtBx_User.TabIndex = 0;
            this.txtBx_User.TextChanged += new System.EventHandler(this.txtBx_User_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBx_User);
            this.groupBox1.Location = new System.Drawing.Point(7, 170);
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
            this.txtBx_Senha.Location = new System.Drawing.Point(6, 19);
            this.txtBx_Senha.Name = "txtBx_Senha";
            this.txtBx_Senha.PasswordChar = '*';
            this.txtBx_Senha.Size = new System.Drawing.Size(188, 20);
            this.txtBx_Senha.TabIndex = 0;
            this.txtBx_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_Senha_KeyPress);
            // 
            // btn_TestSQL
            // 
            this.btn_TestSQL.Location = new System.Drawing.Point(44, 57);
            this.btn_TestSQL.Name = "btn_TestSQL";
            this.btn_TestSQL.Size = new System.Drawing.Size(100, 23);
            this.btn_TestSQL.TabIndex = 4;
            this.btn_TestSQL.Text = "button1";
            this.btn_TestSQL.UseVisualStyleBackColor = true;
            this.btn_TestSQL.Click += new System.EventHandler(this.btn_TestSQL_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_TestSQL);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(7, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 137);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // gestaoInformacaoDataSet
            // 
            this.gestaoInformacaoDataSet.DataSetName = "gestaoInformacaoDataSet";
            this.gestaoInformacaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.gestaoInformacaoDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.imp_supreTableAdapter = null;
            this.tableAdapterManager.unidadeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(216, 327);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Login_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_TestSQL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}