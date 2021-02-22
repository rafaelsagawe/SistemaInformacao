using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Chamando a janela do login via thread
// Passo 0
using System.Threading;

namespace SistemaInformacao
{
    public partial class Frm_Splash : Form
    {

        // Chamando a janela do login via thread
        // Passo 1
        Thread ThreadJanelaLogin;
        public Frm_Splash()
        {
            InitializeComponent();
            //Transparencias em relação ao fundo
            //Transparencia no label do nome do Sistema
            lbl_NomeSistema.Parent = pictureBox2;
            lbl_NomeSistema.BackColor = Color.Transparent;

            // Imagem do logo
            pctrBxLogo.Parent = pictureBox2;
            pctrBxLogo.BackColor = Color.Transparent;
            // ---
        }

        private void Frm_Splash_Load(object sender, EventArgs e)
        {
        }

        // Chamando a janela do login via thread
        // Passo 2 - Construtor da janela
        private void AbrirJanelaLogin(object obj)
        {
            Application.Run(new Frm_Login());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             //Chamada da janela de login
             Frm_Login frm_Login = new Frm_Login();
             frm_Login.Show();
             this.Visible = false;
            */

            // Chamando a janela do login via thread
            // Passo 3
            this.Close();
            ThreadJanelaLogin = new Thread(AbrirJanelaLogin);
            ThreadJanelaLogin.SetApartmentState(ApartmentState.STA); // Como será aberta apenas uma janela usei o STA
            ThreadJanelaLogin.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.Show();
                this.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            /*
            Para a barra de progresso ficar laranja foi necessário:
            * Comentar a linha //Application.EnableVisualStyles(); no arquivo de inicialização da aplicação o "Program.cs"
            * Alterar a cor do item "ForeColor"
            */
        }
    }
}
