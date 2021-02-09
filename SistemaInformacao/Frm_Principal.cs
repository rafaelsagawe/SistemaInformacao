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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void StrpBtn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StrpBtn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void StrpButton_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StrpStsLbl_DataHora.Text = DateTime.Now.ToString();
        }
    }
}
