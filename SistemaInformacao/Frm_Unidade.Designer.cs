
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Unidade));
            System.Windows.Forms.Label id_unidadeLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nome_comumLabel;
            System.Windows.Forms.Label num_protoLabel;
            System.Windows.Forms.Label inepLabel;
            System.Windows.Forms.Label cnpjLabel;
            this.gestaoInformacaoDataSet = new SistemaInformacao.gestaoInformacaoDataSet();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadeTableAdapter = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.unidadeTableAdapter();
            this.tableAdapterManager = new SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager();
            this.unidadeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.unidadeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_unidadeTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nome_comumTextBox = new System.Windows.Forms.TextBox();
            this.num_protoTextBox = new System.Windows.Forms.TextBox();
            this.inepTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            id_unidadeLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nome_comumLabel = new System.Windows.Forms.Label();
            num_protoLabel = new System.Windows.Forms.Label();
            inepLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingNavigator)).BeginInit();
            this.unidadeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gestaoInformacaoDataSet
            // 
            this.gestaoInformacaoDataSet.DataSetName = "gestaoInformacaoDataSet";
            this.gestaoInformacaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.imp_supreTableAdapter = null;
            this.tableAdapterManager.unidadeTableAdapter = this.unidadeTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaInformacao.gestaoInformacaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // unidadeBindingNavigatorSaveItem
            // 
            this.unidadeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unidadeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadeBindingNavigatorSaveItem.Image")));
            this.unidadeBindingNavigatorSaveItem.Name = "unidadeBindingNavigatorSaveItem";
            this.unidadeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.unidadeBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.unidadeBindingNavigatorSaveItem.Click += new System.EventHandler(this.unidadeBindingNavigatorSaveItem_Click_1);
            // 
            // id_unidadeLabel
            // 
            id_unidadeLabel.AutoSize = true;
            id_unidadeLabel.Location = new System.Drawing.Point(53, 44);
            id_unidadeLabel.Name = "id_unidadeLabel";
            id_unidadeLabel.Size = new System.Drawing.Size(59, 13);
            id_unidadeLabel.TabIndex = 1;
            id_unidadeLabel.Text = "id unidade:";
            // 
            // id_unidadeTextBox
            // 
            this.id_unidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "id_unidade", true));
            this.id_unidadeTextBox.Location = new System.Drawing.Point(132, 41);
            this.id_unidadeTextBox.Name = "id_unidadeTextBox";
            this.id_unidadeTextBox.Size = new System.Drawing.Size(235, 20);
            this.id_unidadeTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(53, 70);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(132, 67);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(235, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // nome_comumLabel
            // 
            nome_comumLabel.AutoSize = true;
            nome_comumLabel.Location = new System.Drawing.Point(53, 96);
            nome_comumLabel.Name = "nome_comumLabel";
            nome_comumLabel.Size = new System.Drawing.Size(73, 13);
            nome_comumLabel.TabIndex = 5;
            nome_comumLabel.Text = "nome comum:";
            // 
            // nome_comumTextBox
            // 
            this.nome_comumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "nome_comum", true));
            this.nome_comumTextBox.Location = new System.Drawing.Point(132, 93);
            this.nome_comumTextBox.Name = "nome_comumTextBox";
            this.nome_comumTextBox.Size = new System.Drawing.Size(235, 20);
            this.nome_comumTextBox.TabIndex = 6;
            // 
            // num_protoLabel
            // 
            num_protoLabel.AutoSize = true;
            num_protoLabel.Location = new System.Drawing.Point(53, 122);
            num_protoLabel.Name = "num_protoLabel";
            num_protoLabel.Size = new System.Drawing.Size(57, 13);
            num_protoLabel.TabIndex = 7;
            num_protoLabel.Text = "num proto:";
            // 
            // num_protoTextBox
            // 
            this.num_protoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "num_proto", true));
            this.num_protoTextBox.Location = new System.Drawing.Point(132, 119);
            this.num_protoTextBox.Name = "num_protoTextBox";
            this.num_protoTextBox.Size = new System.Drawing.Size(235, 20);
            this.num_protoTextBox.TabIndex = 8;
            // 
            // inepLabel
            // 
            inepLabel.AutoSize = true;
            inepLabel.Location = new System.Drawing.Point(53, 148);
            inepLabel.Name = "inepLabel";
            inepLabel.Size = new System.Drawing.Size(30, 13);
            inepLabel.TabIndex = 9;
            inepLabel.Text = "inep:";
            // 
            // inepTextBox
            // 
            this.inepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "inep", true));
            this.inepTextBox.Location = new System.Drawing.Point(132, 145);
            this.inepTextBox.Name = "inepTextBox";
            this.inepTextBox.Size = new System.Drawing.Size(235, 20);
            this.inepTextBox.TabIndex = 10;
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(53, 174);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 11;
            cnpjLabel.Text = "cnpj:";
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unidadeBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(132, 171);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(235, 20);
            this.cnpjTextBox.TabIndex = 12;
            // 
            // Frm_Unidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(441, 208);
            this.Controls.Add(id_unidadeLabel);
            this.Controls.Add(this.id_unidadeTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.gestaoInformacaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingNavigator)).EndInit();
            this.unidadeBindingNavigator.ResumeLayout(false);
            this.unidadeBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox id_unidadeTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox nome_comumTextBox;
        private System.Windows.Forms.TextBox num_protoTextBox;
        private System.Windows.Forms.TextBox inepTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
    }
}