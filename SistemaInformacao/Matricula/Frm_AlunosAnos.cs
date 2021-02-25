using System;
using System.Windows.Forms;

namespace SistemaInformacao.Matricula
{
    public partial class Frm_AlunosAnos : Form
    {
        public Frm_AlunosAnos()
        {
            InitializeComponent();
        }

        public string IdUnidade_frm_AlunoAnos { get; set; }

        private void Frm_AlunosAnos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.unidade'. Você pode movê-la ou removê-la conforme necessário.
            this.unidadeTableAdapter.Fill(this.gestaoInformacaoDataSet.unidade);
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.alunosAnosManha'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.alunosAnosManha'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.unidade'. Você pode movê-la ou removê-la conforme necessário.
            if (!this.IdUnidade_frm_AlunoAnos.Equals(""))
            {
                lbl_IdUnidade.Text = this.IdUnidade_frm_AlunoAnos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alunosAnosManhaBindingNavigatorSaveItem_Click(sender, e);
        }

        private void alunosAnosManhaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosAnosManhaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoInformacaoDataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_IdUnidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_IdUnidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_IdUnidade_TextChanged_1(object sender, EventArgs e)
        {
            int intIdUnidade;
            intIdUnidade = Convert.ToInt32(lbl_IdUnidade.Text);
            this.unidadeTableAdapter.FillBy_IdBuscaUnidade(this.gestaoInformacaoDataSet.unidade, intIdUnidade);
        }

        private void id_unidadeTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_IdUnidade_Click(object sender, EventArgs e)
        {

        }
    }
}
