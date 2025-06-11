namespace ProjetoFinal
{
    partial class f_Splash
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            pbTempo = new ProgressBar();
            lbCarregar = new Label();
            lbMensagem1 = new Label();
            lbMensagem2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // pbTempo
            // 
            pbTempo.Location = new Point(40, 80);
            pbTempo.Name = "pbTempo";
            pbTempo.Size = new Size(199, 23);
            pbTempo.TabIndex = 1;
            // 
            // lbCarregar
            // 
            lbCarregar.AutoSize = true;
            lbCarregar.Font = new Font("Segoe UI", 15F);
            lbCarregar.Location = new Point(80, 45);
            lbCarregar.Name = "lbCarregar";
            lbCarregar.Size = new Size(114, 28);
            lbCarregar.TabIndex = 0;
            lbCarregar.Text = "A carregar...";
            // 
            // lbMensagem1
            // 
            lbMensagem1.AutoSize = true;
            lbMensagem1.Font = new Font("Segoe UI", 10F);
            lbMensagem1.Location = new Point(15, 130);
            lbMensagem1.Name = "lbMensagem1";
            lbMensagem1.Size = new Size(98, 19);
            lbMensagem1.TabIndex = 17;
            lbMensagem1.Text = "by Dinis Sousa";
            // 
            // lbMensagem2
            // 
            lbMensagem2.AutoSize = true;
            lbMensagem2.Font = new Font("Segoe UI", 10F);
            lbMensagem2.Location = new Point(174, 130);
            lbMensagem2.Name = "lbMensagem2";
            lbMensagem2.Size = new Size(98, 19);
            lbMensagem2.TabIndex = 18;
            lbMensagem2.Text = "by Dinis Sousa";
            lbMensagem2.Visible = false;
            // 
            // f_Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            ControlBox = false;
            Controls.Add(lbMensagem2);
            Controls.Add(lbMensagem1);
            Controls.Add(lbCarregar);
            Controls.Add(pbTempo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "f_Splash";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ProgressBar pbTempo;
        private Label lbCarregar;
        private Label lbMensagem1;
        private Label lbMensagem2;
    }
}