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
            if (!this.IdUnidade_frm_AlunoAnos.Equals(""))
            {
                lbl_IdUnidade.Text = this.IdUnidade_frm_AlunoAnos;
            }
            this.Text = lbl_IdUnidade.Text;
        }
    }
}
