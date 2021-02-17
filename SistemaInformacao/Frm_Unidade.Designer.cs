
namespace SistemaInformacao
{
    partial class Frm_Unidade
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
            System.Windows.Forms.Label id_unidadeLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nome_comumLabel;
            System.Windows.Forms.Label num_protoLabel;
            System.Windows.Forms.Label inepLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Unidade));
            this.unidadeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoInformacaoDataSet = new SistemaInformacao.gestaoInformacaoDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.unidadeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nome_comumTextBox = new System.Windows.Forms.TextBox();
            this.num_protoTextBox = new System.Windows.Forms.TextBox();
            this.inepTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.unidadeTableAdapter = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.unidadeTableAdapter();
            this.tableAdapterManager = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager();
            this.txtBx_IdUnidade = new System.Windows.Forms.TextBox();
            id_unidadeLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nome_comumLabel = new System.Windows.Forms.Label();
            num_protoLabel = new System.Windows.Forms.Label();
            inepLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingNavigator)).BeginInit();
            this.unidadeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_unidadeLabel
            // 
            id_unidadeLabel.AutoSize = true;
            id_unidadeLabel.Location = new System.Drawing.Point(64, 49);
            id_unidadeLabel.Name = "id_unidadeLabel";
            id_unidadeLabel.Size = new System.Drawing.Size(59, 13);
            id_unidadeLabel.TabIndex = 1;
            id_unidadeLabel.Text = "id unidade:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(64, 75);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // nome_comumLabel
            // 
            nome_comumLabel.AutoSize = true;
            nome_comumLabel.Location = new System.Drawing.Point(64, 101);
            nome_comumLabel.Name = "nome_comumLabel";
            nome_comumLabel.Size = new System.Drawing.Size(73, 13);
            nome_comumLabel.TabIndex = 5;
            nome_comumLabel.Text = "nome comum:";
            // 
            // num_protoLabel
            // 
            num_protoLabel.AutoSize = true;
            num_protoLabel.Location = new System.Drawing.Point(64, 127);
            num_protoLabel.Name = "num_protoLabel";
            num_protoLabel.Size = new System.Drawing.Size(57, 13);
            num_protoLabel.TabIndex = 7;
            num_protoLabel.Text = "num proto:";
            // 
            // inepLabel
            // 
            inepLabel.AutoSize = true;
            inepLabel.Location = new System.Drawing.Point(64, 153);
            inepLabel.Name = "inepLabel";
            inepLabel.Size = new System.Drawing.Size(30, 13);
            inepLabel.TabIndex = 9;
            inepLabel.Text = "inep:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(64, 179);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 11;
            cnpjLabel.Text = "cnpj:";
            // 
            // unidadeBindingNavigator
            // 
            this.unidadeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.unidadeBindingNavigator.BindingSource = this.unidadeBindingSource;
            this.unidadeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.unidadeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.unidadeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.unidadeBindingNavigatorSaveItem});
            this.unidadeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.unidadeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.unidadeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.unidadeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.unidadeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.unidadeBindingNavigator.Name = "unidadeBindingNavigator";
            this.unidadeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.unidadeBindingNavigator.Size = new System.Drawing.Size(441, 25);
            this.unidadeBindingNavigator.TabIndex = 0;
            this.unidadeBindingNavigator.Text = "bindingNavigator1";
            this.unidadeBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataMember = "unidade";
            this.unidadeBindingSource.DataSource = this.gestaoInformacaoDataSet;
            // 
            // gestaoInformacaoDataSet
            // 
            this.gestaoInformacaoDataSet.DataSetName = "gestaoInformacaoDataSet";
            this.gestaoInformacaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // unidadeBindingNavigatorSaveItem
            // 
            this.unidadeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unidadeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadeBindingNavigatorSaveItem.Image")));
            this.unidadeBindingNavigatorSaveItem.Name = "unidadeBindingNavigatorSaveItem";
            this.unidadeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.unidadeBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.unidadeBindingNavigatorSaveItem.Click += new System.EventHandler(this.unidadeBindingNavigatorSaveItem_Click_1);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(143, 72);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(235, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // nome_comumTextBox
            // 
            this.nome_comumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "nome_comum", true));
            this.nome_comumTextBox.Location = new System.Drawing.Point(143, 98);
            this.nome_comumTextBox.Name = "nome_comumTextBox";
            this.nome_comumTextBox.Size = new System.Drawing.Size(235, 20);
            this.nome_comumTextBox.TabIndex = 6;
            // 
            // num_protoTextBox
            // 
            this.num_protoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "num_proto", true));
            this.num_protoTextBox.Location = new System.Drawing.Point(143, 124);
            this.num_protoTextBox.Name = "num_protoTextBox";
            this.num_protoTextBox.Size = new System.Drawing.Size(235, 20);
            this.num_protoTextBox.TabIndex = 8;
            // 
            // inepTextBox
            // 
            this.inepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "inep", true));
            this.inepTextBox.Location = new System.Drawing.Point(143, 150);
            this.inepTextBox.Name = "inepTextBox";
            this.inepTextBox.Size = new System.Drawing.Size(235, 20);
            this.inepTextBox.TabIndex = 10;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(143, 176);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(235, 20);
            this.cnpjTextBox.TabIndex = 12;
            // 
            // unidadeTableAdapter
            // 
            this.unidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alunosAnosManhaTableAdapter = null;
            this.tableAdapterManager.alunosAnosTardeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.imp_supreTableAdapter = null;
            this.tableAdapterManager.unidadeTableAdapter = this.unidadeTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // txtBx_IdUnidade
            // 
            this.txtBx_IdUnidade.Location = new System.Drawing.Point(143, 42);
            this.txtBx_IdUnidade.Name = "txtBx_IdUnidade";
            this.txtBx_IdUnidade.ReadOnly = true;
            this.txtBx_IdUnidade.Size = new System.Drawing.Size(235, 20);
            this.txtBx_IdUnidade.TabIndex = 13;
            this.txtBx_IdUnidade.TextChanged += new System.EventHandler(this.txtBx_IdUnidade_TextChanged);
            // 
            // Frm_Unidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(441, 247);
            this.Controls.Add(this.txtBx_IdUnidade);
            this.Controls.Add(id_unidadeLabel);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(nome_comumLabel);
            this.Controls.Add(this.nome_comumTextBox);
            this.Controls.Add(num_protoLabel);
            this.Controls.Add(this.num_protoTextBox);
            this.Controls.Add(inepLabel);
            this.Controls.Add(this.inepTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(this.unidadeBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Unidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Unidade";
            this.Load += new System.EventHandler(this.Frm_Unidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingNavigator)).EndInit();
            this.unidadeBindingNavigator.ResumeLayout(false);
            this.unidadeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestaoInformacaoDataSet gestaoInformacaoDataSet;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private gestaoInformacaoDataSetTableAdapters.unidadeTableAdapter unidadeTableAdapter;
        private gestaoInformacaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator unidadeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton unidadeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox nome_comumTextBox;
        private System.Windows.Forms.TextBox num_protoTextBox;
        private System.Windows.Forms.TextBox inepTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox txtBx_IdUnidade;
    }
}