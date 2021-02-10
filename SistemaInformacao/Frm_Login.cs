﻿using System;
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
            Dispose();
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
                frm_Principal.Show();
                this.Visible = false;
            }

            else

            {
                MessageBox.Show("Usuário/Senha Invalido", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TestSQL_Click(object sender, EventArgs e)
        {

        }
    }
}
