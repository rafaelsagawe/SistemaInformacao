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
    public partial class Frm_Login : Form
    {
        

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoInformacaoDataSet);
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.gestaoInformacaoDataSet.usuarios);
        }


        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            int valor = usuariosTableAdapter.Fill_Login(gestaoInformacaoDataSet.usuarios, txtBx_User.Text, txtBx_Senha.Text);

            if (valor == 1)
            {
                
                Frm_Principal frm_Principal = new Frm_Principal();
                frm_Principal.NomeUsuario = lbl_NomeUsuario.Text;
                frm_Principal.NomeCompleto = lbl_NomeCompleto.Text;
                frm_Principal.IdUnidade = lbl_IdUnidade.Text;
                frm_Principal.Show();
                this.Visible = false;
                MessageBox.Show(lbl_NomeCompleto.Text, "Bem-vindo usuário", MessageBoxButtons.OK);


            }

            else

            {
                MessageBox.Show("Usuário/Senha Invalido", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TestSQL_Click(object sender, EventArgs e)
        {
            //this.usuariosTableAdapter.Fill_UserNameFull(this.gestaoInformacaoDataSet.usuarios, txtBx_User.Text);
        }

        private void txtBx_User_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBx_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Btn_Entrar_Click(sender, e);
            }
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            txtBx_User_TextChanged(sender, e);
        }

        private void Frm_Login_Load_1(object sender, EventArgs e)
        {

        }

        private void lbl_IdUnidade_Click(object sender, EventArgs e)
        {

        }
    }
}
