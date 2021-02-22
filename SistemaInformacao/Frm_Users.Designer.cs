
namespace SistemaInformacao
{
    partial class Frm_Users
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
            System.Windows.Forms.Label nome_compeltoLabel;
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label user_passLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label id_unidadeLabel;
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoInformacaoDataSet = new SistemaInformacao.gestaoInformacaoDataSet();
            this.usuariosTableAdapter = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager();
            this.nome_compeltoTextBox = new System.Windows.Forms.TextBox();
            this.user_passTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.txtBx_Busca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadeTableAdapter = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.unidadeTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.unidadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            nome_compeltoLabel = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            user_passLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            id_unidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_compeltoLabel
            // 
            nome_compeltoLabel.AutoSize = true;
            nome_compeltoLabel.Location = new System.Drawing.Point(15, 48);
            nome_compeltoLabel.Name = "nome_compeltoLabel";
            nome_compeltoLabel.Size = new System.Drawing.Size(81, 13);
            nome_compeltoLabel.TabIndex = 3;
            nome_compeltoLabel.Text = "Nome completo";
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Location = new System.Drawing.Point(15, 21);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(87, 13);
            user_nameLabel.TabIndex = 5;
            user_nameLabel.Text = "Nome de usuário";
            // 
            // user_passLabel
            // 
            user_passLabel.AutoSize = true;
            user_passLabel.Location = new System.Drawing.Point(15, 74);
            user_passLabel.Name = "user_passLabel";
            user_passLabel.Size = new System.Drawing.Size(38, 13);
            user_passLabel.TabIndex = 7;
            user_passLabel.Text = "Senha";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(15, 100);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email";
            // 
            // id_unidadeLabel
            // 
            id_unidadeLabel.AutoSize = true;
            id_unidadeLabel.Location = new System.Drawing.Point(15, 126);
            id_unidadeLabel.Name = "id_unidadeLabel";
            id_unidadeLabel.Size = new System.Drawing.Size(47, 13);
            id_unidadeLabel.TabIndex = 11;
            id_unidadeLabel.Text = "Unidade";
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
            this.tableAdapterManager.alunosAnosManhaTableAdapter = null;
            this.tableAdapterManager.alunosAnosTardeTableAdapter = null;
            this.tableAdapterManager.anoSerieTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoServidorTableAdapter = null;
            this.tableAdapterManager.contatosTableAdapter = null;
            this.tableAdapterManager.frequenciaFuncionariosTableAdapter = null;
            this.tableAdapterManager.funcaoTableAdapter = null;
            this.tableAdapterManager.imp_supreTableAdapter = null;
            this.tableAdapterManager.RegimeServidorTableAdapter = null;
            this.tableAdapterManager.TurmaUnidadeTableAdapter = null;
            this.tableAdapterManager.unidadeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // nome_compeltoTextBox
            // 
            this.nome_compeltoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nome_compelto", true));
            this.nome_compeltoTextBox.Location = new System.Drawing.Point(103, 45);
            this.nome_compeltoTextBox.Name = "nome_compeltoTextBox";
            this.nome_compeltoTextBox.Size = new System.Drawing.Size(259, 20);
            this.nome_compeltoTextBox.TabIndex = 4;
            // 
            // user_passTextBox
            // 
            this.user_passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "user_pass", true));
            this.user_passTextBox.Location = new System.Drawing.Point(103, 71);
            this.user_passTextBox.Name = "user_passTextBox";
            this.user_passTextBox.Size = new System.Drawing.Size(102, 20);
            this.user_passTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(103, 97);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(262, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // txtBx_Busca
            // 
            this.txtBx_Busca.Location = new System.Drawing.Point(103, 18);
            this.txtBx_Busca.Name = "txtBx_Busca";
            this.txtBx_Busca.ReadOnly = true;
            this.txtBx_Busca.Size = new System.Drawing.Size(259, 20);
            this.txtBx_Busca.TabIndex = 13;
            this.txtBx_Busca.TextChanged += new System.EventHandler(this.txtBx_Busca_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salvar alterações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataMember = "unidade";
            this.unidadeBindingSource.DataSource = this.gestaoInformacaoDataSet;
            // 
            // unidadeTableAdapter
            // 
            this.unidadeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "id_unidade", true));
            this.comboBox1.DataSource = this.unidadeBindingSource1;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "id_unidade";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // unidadeBindingSource1
            // 
            this.unidadeBindingSource1.DataMember = "unidade";
            this.unidadeBindingSource1.DataSource = this.gestaoInformacaoDataSet;
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 198);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBx_Busca);
            this.Controls.Add(id_unidadeLabel);
            this.Controls.Add(nome_compeltoLabel);
            this.Controls.Add(this.nome_compeltoTextBox);
            this.Controls.Add(user_nameLabel);
            this.Controls.Add(user_passLabel);
            this.Controls.Add(this.user_passTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Usuário";
            this.Load += new System.EventHandler(this.Frm_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestaoInformacaoDataSet gestaoInformacaoDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private gestaoInformacaoDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private gestaoInformacaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nome_compeltoTextBox;
        private System.Windows.Forms.TextBox user_passTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox txtBx_Busca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private gestaoInformacaoDataSetTableAdapters.unidadeTableAdapter unidadeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource unidadeBindingSource1;
    }
}