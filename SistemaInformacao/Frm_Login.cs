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
                frm_Principal.NomeUsuario = label2.Text;
                frm_Principal.Show();
                this.Visible = false;
                MessageBox.Show("" + txtBx_User.Text, "Olá", MessageBoxButtons.OK);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            usuariosTableAdapter.Fill_UserNameFull(gestaoInformacaoDataSet.usuarios, textBox1.Text);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtBx_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Btn_Entrar_Click(sender, e);
                /*
                int valor = usuariosTableAdapter.Fill_Login(gestaoInformacaoDataSet.usuarios, txtBx_User.Text, txtBx_Senha.Text);

                if (valor == 1)
                {
                    Frm_Principal frm_Principal = new Frm_Principal();
                    frm_Principal.NomeUsuario = txtBx_User.Text;
                    frm_Principal.Show();
                    this.Visible = false;
                    MessageBox.Show("" + txtBx_User.Text, "Olá", MessageBoxButtons.OK);
                }

                else

                {
                    MessageBox.Show("Usuário/Senha Invalido", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                */
            }
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar se realmente o usuário deseja finaliar a apliação
            //if (DialogResult.Yes != MessageBox.Show("Tem ceeteza em fichar a aplicação", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) ;

            {
              //  e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_TestSQL_Click_1(object sender, EventArgs e)
        {
            /*string NomeCompleto;
            NomeCompleto = usuariosTableAdapter.Fill_Login(gestaoInformacaoDataSet.usuarios, txtBx_User.Text, txtBx_Senha.Text).ToString();
            label1.Text = NomeCompleto;*/
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            txtBx_User_TextChanged(sender, e);
        }
    }
}
