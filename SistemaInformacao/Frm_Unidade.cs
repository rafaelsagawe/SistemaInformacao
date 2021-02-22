using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInformacao
{
    public partial class Frm_Unidade : Form
    {
        public Frm_Unidade()
        {
            InitializeComponent();
        }

        public string IdUnidade_frm_Unidade { get; set; }

        private void unidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoInformacaoDataSet);

        }

        private void Frm_Unidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.unidade'. Você pode movê-la ou removê-la conforme necessário.
            this.unidadeTableAdapter.Fill(this.gestaoInformacaoDataSet.unidade);
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.unidade'. Você pode movê-la ou removê-la conforme necessário.
            this.unidadeTableAdapter.Fill(this.gestaoInformacaoDataSet.unidade);


            // Carregar/recebe id da unidade da tela principal para a tela unidade
            if (!this.IdUnidade_frm_Unidade.Equals(""))
            {
                txtBx_IdUnidade.Text = this.IdUnidade_frm_Unidade;
            }
            this.Text = nomeTextBox.Text;
        }

        private void unidadeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.unidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoInformacaoDataSet);

        }

        private void txtBx_IdUnidade_TextChanged(object sender, EventArgs e)
        {
            
           //Para realizar a busca foi preciso converter de string para int
           int intIdUnidade;
           intIdUnidade = Convert.ToInt32(txtBx_IdUnidade.Text);
           this.unidadeTableAdapter.FillBy_IdBuscaUnidade(this.gestaoInformacaoDataSet.unidade, intIdUnidade);
           
        }
    }
}
