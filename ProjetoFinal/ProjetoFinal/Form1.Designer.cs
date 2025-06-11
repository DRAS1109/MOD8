namespace ProjetoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            prestacaoToolStripMenuItem = new ToolStripMenuItem();
            emprestimoMaximoToolStripMenuItem = new ToolStripMenuItem();
            fimEmprestimoToolStripMenuItem = new ToolStripMenuItem();
            Sobre = new Label();
            toolTip1 = new ToolTip(components);
            linkLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { prestacaoToolStripMenuItem, emprestimoMaximoToolStripMenuItem, fimEmprestimoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(364, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // prestacaoToolStripMenuItem
            // 
            prestacaoToolStripMenuItem.Name = "prestacaoToolStripMenuItem";
            prestacaoToolStripMenuItem.Size = new Size(70, 20);
            prestacaoToolStripMenuItem.Text = "Prestação";
            prestacaoToolStripMenuItem.Click += prestacaoToolStripMenuItem_Click;
            // 
            // emprestimoMaximoToolStripMenuItem
            // 
            emprestimoMaximoToolStripMenuItem.Name = "emprestimoMaximoToolStripMenuItem";
            emprestimoMaximoToolStripMenuItem.Size = new Size(130, 20);
            emprestimoMaximoToolStripMenuItem.Text = "Emprestimo Maximo";
            emprestimoMaximoToolStripMenuItem.Click += emprestimoMaximoToolStripMenuItem_Click;
            // 
            // fimEmprestimoToolStripMenuItem
            // 
            fimEmprestimoToolStripMenuItem.Name = "fimEmprestimoToolStripMenuItem";
            fimEmprestimoToolStripMenuItem.Size = new Size(106, 20);
            fimEmprestimoToolStripMenuItem.Text = "Fim Emprestimo";
            fimEmprestimoToolStripMenuItem.Click += fimEmprestimoToolStripMenuItem_Click;
            // 
            // Sobre
            // 
            Sobre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sobre.Location = new Point(15, 35);
            Sobre.Name = "Sobre";
            Sobre.Size = new Size(350, 240);
            Sobre.TabIndex = 0;
            Sobre.Text = resources.GetString("Sobre.Text");
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Segoe UI", 10F);
            linkLabel.Location = new Point(144, 298);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(157, 19);
            linkLabel.TabIndex = 36;
            linkLabel.TabStop = true;
            linkLabel.Text = "Saiba mais sobre crédito";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Banco_Portugal;
            pictureBox1.Location = new Point(12, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 361);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel);
            Controls.Add(Sobre);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem prestacaoToolStripMenuItem;
        private ToolStripMenuItem emprestimoMaximoToolStripMenuItem;
        private Label Sobre;
        private ToolStripMenuItem fimEmprestimoToolStripMenuItem;
        private ToolTip toolTip1;
        private LinkLabel linkLabel;
        private PictureBox pictureBox1;
    }
}
