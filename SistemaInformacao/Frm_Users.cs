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
    public partial class Frm_Users : Form
    {
        public Frm_Users()
        {
            InitializeComponent();
        }
        public string NomeUsuario_frm_users { get; set; }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoInformacaoDataSet);

        }

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoInformacaoDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.gestaoInformacaoDataSet.usuarios);

            //Propriodade para carregar o nome do usuário
            if (!this.NomeUsuario_frm_users.Equals(""))
            {
                txtBx_Busca.Text = this.NomeUsuario_frm_users;
            }

        }
        private void txtBx_Busca_TextChanged(object sender, EventArgs e)
        {
           // this.usuariosTableAdapter.Fill_UserNameFull(this.gestaoInformacaoDataSet.usuarios, txtBx_Busca.Text);
        }
    }
}
