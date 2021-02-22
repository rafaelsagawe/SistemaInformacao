
namespace SistemaInformacao
{
    partial class Frm_Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctrBxLogo = new System.Windows.Forms.PictureBox();
            this.lbl_NomeSistema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(107)))), ((int)(((byte)(41)))));
            this.progressBar1.Location = new System.Drawing.Point(-1, 262);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(674, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SistemaInformacao.Properties.Resources.nova_iguacu_2__1_;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(674, 264);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pctrBxLogo
            // 
            this.pctrBxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctrBxLogo.Image = global::SistemaInformacao.Properties.Resources.logo_2;
            this.pctrBxLogo.Location = new System.Drawing.Point(-1, -1);
            this.pctrBxLogo.Name = "pctrBxLogo";
            this.pctrBxLogo.Size = new System.Drawing.Size(261, 80);
            this.pctrBxLogo.TabIndex = 2;
            this.pctrBxLogo.TabStop = false;
            // 
            // lbl_NomeSistema
            // 
            this.lbl_NomeSistema.AutoSize = true;
            this.lbl_NomeSistema.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomeSistema.Font = new System.Drawing.Font("Liberation Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeSistema.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_NomeSistema.Location = new System.Drawing.Point(62, 177);
            this.lbl_NomeSistema.Name = "lbl_NomeSistema";
            this.lbl_NomeSistema.Size = new System.Drawing.Size(538, 53);
            this.lbl_NomeSistema.TabIndex = 3;
            this.lbl_NomeSistema.Text = "Sistema de informações";
            this.lbl_NomeSistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(673, 272);
            this.Controls.Add(this.lbl_NomeSistema);
            this.Controls.Add(this.pctrBxLogo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Splash";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Splash";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pctrBxLogo;
        private System.Windows.Forms.Label lbl_NomeSistema;
    }
}