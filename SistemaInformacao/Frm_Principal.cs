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

        // get e set da Propriedade NomeUsuario para pegar o nome do usuário logado e colocar na barra de status (StrpStsLbl_UserNameFull)
        public string NomeUsuario {get; set; }

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

        private void StrpBtn_Users_Click(object sender, EventArgs e)
        {
            Frm_Users frm_Users = new Frm_Users();
            frm_Users.NomeUsuario_frm_users = StrpStsLbl_UserNameFull.Text;
            frm_Users.ShowDialog();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            //Propriodade para carregar o nome do usuário
            if (!this.NomeUsuario.Equals(""))
            {
                StrpStsLbl_UserNameFull.Text = this.NomeUsuario;
            }
        }
    }
}
