using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.alunosAnosManhaTableAdapter.Fill(this.gestaoInformacaoDataSet.alunosAnosManha);
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.alunosAnosManha'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosAnosManhaTableAdapter.Fill(this.gestaoInformacaoDataSet.alunosAnosManha);
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
          //  this.unidadeTableAdapter.FillBy_NomeUnidade(this.gestaoInformacaoDataSet.unidade, intIdUnidade);
        }

        private void lbl_IdUnidade_TextChanged(object sender, EventArgs e)
        {
            int intIdUnidade;
            intIdUnidade = Convert.ToInt32(lbl_IdUnidade.Text);
            this.alunosAnosManhaTableAdapter.FillBy_UnidadeAlunosAnosQTD(this.gestaoInformacaoDataSet.alunosAnosManha, intIdUnidade);
            this.unidadeTableAdapter.FillBy_IdBuscaUnidade(this.gestaoInformacaoDataSet.unidade, intIdUnidade);
        }

        private void txtBx_IdUnidade_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void id_unidadeTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_IdUnidade_Click(object sender, EventArgs e)
        {

        }
    }
}
