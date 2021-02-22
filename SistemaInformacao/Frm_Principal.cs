using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
        public string NomeCompleto {get; set; }
        public string IdUnidade {get; set; }

        private void AbrirJanelaLogin( object obj)
        {
            Application.Run(new Frm_Login());
        }

        private void StrpBtn_Fechar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Frm_Login frm_Login_retorno = new Frm_Login();
            frm_Login_retorno.Show();
            Dispose();
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
            // Formulario de gestão de usuário será chamdo dentro da janela principal
            Frm_Users frm_Users = new Frm_Users();
            frm_Users.NomeUsuario_frm_users = NomeUsuario; // No lugar de enviar o texto da interface foi enviado o valor armazenado na variavel
            frm_Users.MdiParent = this;
            frm_Users.Show();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            
            //Propriodade para carregar o nome do usuário
            // Nome de usuário
            if (!this.NomeUsuario.Equals(""))
            {
                StrpStsLbl_UserName.Text = "Usuário: " + this.NomeUsuario;
            }
            
            //Nome completo do Usuário
            if (!this.NomeCompleto.Equals(""))
            {
              StrpStsLbl_UserNameFull.Text = "Nome Usuário: " + this.NomeCompleto;
            }

            // Id da Unidade cadastrada que o usuário gerencia
            if (!this.IdUnidade.Equals(""))
            {
                StrpStsLbl_IdUnidade.Text = "Codigo da Unidade: " + this.IdUnidade;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_Unidade frm_Unidade = new Frm_Unidade();
            frm_Unidade.IdUnidade_frm_Unidade = IdUnidade; // No lugar de enviar o texto da interface foi enviado o valor armazenado na variavel
            frm_Unidade.MdiParent = this;
            frm_Unidade.Show();
        }

        private void StrpBtn_AunoAno_Click(object sender, EventArgs e)
        {
            Matricula.Frm_AlunosAnos frm_AlunosAnos = new Matricula.Frm_AlunosAnos();
            frm_AlunosAnos.IdUnidade_frm_AlunoAnos = IdUnidade;
            frm_AlunosAnos.MdiParent = this;
            frm_AlunosAnos.Show();
        }

        private void unidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender,  e);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrpBtn_Users_Click(sender, e);
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StrpBtn_Fechar_Click(sender, e);
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StrpBtn_Fechar_Click(sender, e);
        }

        private void alunosPorAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrpBtn_AunoAno_Click( sender, e);
        }
    }
}
