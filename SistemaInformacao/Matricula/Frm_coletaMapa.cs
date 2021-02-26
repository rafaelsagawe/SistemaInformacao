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
    public partial class Frm_coletaMapa : Form
    {
        public string coletaMapa_IdUnidade { get; set; }

        public Frm_coletaMapa(string IdUnidade)
        {
            InitializeComponent();
            coletaMapa_IdUnidade = IdUnidade;
        }



        private void Frm_coletaMapa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.anoSerie'. Você pode movê-la ou removê-la conforme necessário.
            this.anoSerieTableAdapter.Fill(this.gestaoInformacaoDataSet.anoSerie);
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.unidade'. Você pode movê-la ou removê-la conforme necessário.
            this.unidadeTableAdapter.Fill(this.gestaoInformacaoDataSet.unidade);
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.coletaMapaQTDAlunos'. Você pode movê-la ou removê-la conforme necessário.
            this.coletaMapaQTDAlunosTableAdapter.Fill(this.gestaoInformacaoDataSet.coletaMapaQTDAlunos);
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.coletaMapa'. Você pode movê-la ou removê-la conforme necessário.

            if (!this.coletaMapa_IdUnidade.Equals(""))
            {
                txtBx_buscaIdUnidade.Text = coletaMapa_IdUnidade;
            }

        }

        private void coletaMapaQTDAlunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coletaMapaQTDAlunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoInformacaoDataSet);
            MessageBox.Show("Alterações Salvas","Status", MessageBoxButtons.OK);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (!this.coletaMapa_IdUnidade.Equals(""))
            {
                id_unidadeTextBox.Text = coletaMapa_IdUnidade;
            }
                pTurnoNumericUpDown.Value = 0;
                sTurnoNumericUpDown.Value = 0;
                internNumericUpDown.Value = 0;
                ejaNumericUpDown.Value = 0;
                vagasNumericUpDown.Value = 0;
                hi_pTurnoNumericUpDown.Value = 0;
                hi_sTurnoNumericUpDown.Value = 0;
                hi_internNumericUpDown.Value = 0;
                integralNumericUpDown.Value = 0;
    }
        



        private void txtBx_buscaIdUnidade_TextChanged(object sender, EventArgs e)
        {
            int intIdUnidade = Convert.ToInt32(coletaMapa_IdUnidade);
            this.coletaMapaQTDAlunosTableAdapter.FillBy_idUnidade(gestaoInformacaoDataSet.coletaMapaQTDAlunos, intIdUnidade);
            this.unidadeTableAdapter.FillBy_IdBuscaUnidade(this.gestaoInformacaoDataSet.unidade, intIdUnidade);
        }

        private void coletaMapaQTDAlunosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Matricula.Relatorio.Frm_RelatorioMapa frm_RelatorioMapa = new Relatorio.Frm_RelatorioMapa();
            frm_RelatorioMapa.Show();
        }
    }
}
