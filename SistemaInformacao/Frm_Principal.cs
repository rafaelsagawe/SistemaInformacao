using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemaInformacao
{
    public partial class Frm_Principal : Form
    {
        private Form AtivarForm;
        public Frm_Principal()
        {
            InitializeComponent();
            visualizacaoMenu();
            // Tornas as bordas mais finas
            this.Text = string.Empty;
            this.ControlBox = false;
            // Não cobrir a barra de tarefas
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Arrastar a janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        // get e set da Propriedade NomeUsuario para pegar o nome do usuário logado e colocar na barra de status (StrpStsLbl_UserNameFull)
        public string NomeUsuario { get; set; }
        public string NomeCompleto { get; set; }
        public string IdUnidade { get; set; }

        private void AbrirJanelaLogin(object obj)
        {
            Application.Run(new Frm_Login());
        }
        //Abrir os formularios child no pnlDesktop  
        private void AbrirFormChild(Form childForm, object btnSender)
        {
            if (AtivarForm != null)
            {
                AtivarForm.Close();
            }
            //ActivatedButton(btnSender);
            AtivarForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloJanela.Text = childForm.Text;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void StrpBtn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void StrpButton_Max_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

        }


        // ------------ Relogio
        #region Funcionamento do Relogio
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_horario.Text = DateTime.Now.ToString();
        }
        // ------------ 
        #endregion
        private void StrpBtn_Users_Click(object sender, EventArgs e)
        {
            /*
            // Formulario de gestão de usuário será chamdo dentro da janela principal
            Frm_Users frm_Users = new Frm_Users();
            // No lugar de enviar o texto da interface foi enviado o valor armazenado na variavel
            frm_Users.NomeUsuario_frm_users = NomeUsuario; 
            frm_Users.MdiParent = this;
            frm_Users.Show();
            */
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_NomeUsuario.Text = NomeCompleto;
        }
        //          Inicio das configurações dos menus
        private void visualizacaoMenu()
        {
            panelUnidade.Visible = false;
            panelRH.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelUnidade.Visible == true)
                panelUnidade.Visible = false;
            if (panelRH.Visible == true)
                panelRH.Visible = false;
        }

        private void mostraMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                ocultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;

        }
        // -------------- Botões de controle das janelas
        // -------------- Inicio
        private void pctrBx_Sair_Click(object sender, EventArgs e)
        {
            // Volta para a janela de login
            Frm_Login frm_Login_retorno = new Frm_Login();
            frm_Login_retorno.Show();
            this.Dispose();
        }

        private void pctrBx_redimencionar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        // -------------- Final

        // -------------- Botões do menu Unidade
        // -------------- Inicio
        private void btn_Unidade_Click(object sender, EventArgs e)
        {
            mostraMenu(panelUnidade);
        }

        private void btn_Dados_Click(object sender, EventArgs e)
        {
            AbrirFormChild(new Frm_Unidade(IdUnidade), sender);
            ocultarSubMenu();

        }

        private void btn_QTDAlunos_Click(object sender, EventArgs e)
        {
            AbrirFormChild(new Matricula.Frm_coletaMapa(IdUnidade), sender);
            ocultarSubMenu();
        }


        // -------------- Final


        private void btn_RH_Click(object sender, EventArgs e)
        {
            mostraMenu(panelRH);
        }


        private void btn_user_Click(object sender, EventArgs e)
        {
            AbrirFormChild(new Frm_Users(NomeUsuario), sender);
            ocultarSubMenu();
        }


        //          Final das configurações do menus

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrpBtn_Users_Click(sender, e);
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void alunosPorAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrpBtn_AunoAno_Click(sender, e);
        }



        private void coletaMapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Matricula.Frm_coletaMapa frm_ColetaMapa = new Matricula.Frm_coletaMapa();
            frm_ColetaMapa.MdiParent = this;
            frm_ColetaMapa.coletaMapa_IdUnidade = IdUnidade;
            frm_ColetaMapa.Show();
        */
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_FecharMDIform_Click(object sender, EventArgs e)
        {
            if (AtivarForm != null)
                ActiveForm.Close();
            Reset();
        }

        private void Reset()
        {
            lblTituloJanela.Text = "Inicio";
        }

        private void StrpStsLbl_DataHora_Click(object sender, EventArgs e)
        {

        }
    }
}
