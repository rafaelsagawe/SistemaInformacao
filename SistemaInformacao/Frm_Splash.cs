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
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
        }

        private void Frm_Splash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chamada da janela de login
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
            this.Visible = false;
                
        }
    }
}
