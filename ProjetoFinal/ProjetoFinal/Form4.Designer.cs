namespace ProjetoFinal
{
    partial class Form4
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
            menuStrip1 = new MenuStrip();
            prestaçãoToolStripMenuItem = new ToolStripMenuItem();
            emprestimoMáximoToolStripMenuItem = new ToolStripMenuItem();
            fimEmprestimoToolStripMenuItem = new ToolStripMenuItem();
            nudTempo = new NumericUpDown();
            gbMesAno = new GroupBox();
            rbAnos = new RadioButton();
            rbMeses = new RadioButton();
            tbEmprestimo = new TextBox();
            nudJuros = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btCalcular = new Button();
            lbResposta = new Label();
            tbMensal = new TextBox();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            lbAjuda = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTempo).BeginInit();
            gbMesAno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJuros).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { prestaçãoToolStripMenuItem, emprestimoMáximoToolStripMenuItem, fimEmprestimoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(364, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // prestaçãoToolStripMenuItem
            // 
            prestaçãoToolStripMenuItem.Name = "prestaçãoToolStripMenuItem";
            prestaçãoToolStripMenuItem.Size = new Size(70, 20);
            prestaçãoToolStripMenuItem.Text = "Prestação";
            prestaçãoToolStripMenuItem.Click += prestaçãoToolStripMenuItem_Click;
            // 
            // emprestimoMáximoToolStripMenuItem
            // 
            emprestimoMáximoToolStripMenuItem.Name = "emprestimoMáximoToolStripMenuItem";
            emprestimoMáximoToolStripMenuItem.Size = new Size(130, 20);
            emprestimoMáximoToolStripMenuItem.Text = "Emprestimo Maximo";
            emprestimoMáximoToolStripMenuItem.Click += emprestimoMáximoToolStripMenuItem_Click;
            // 
            // fimEmprestimoToolStripMenuItem
            // 
            fimEmprestimoToolStripMenuItem.Name = "fimEmprestimoToolStripMenuItem";
            fimEmprestimoToolStripMenuItem.Size = new Size(106, 20);
            fimEmprestimoToolStripMenuItem.Text = "Fim Emprestimo";
            // 
            // nudTempo
            // 
            nudTempo.Location = new Point(220, 175);
            nudTempo.Name = "nudTempo";
            nudTempo.Size = new Size(120, 23);
            nudTempo.TabIndex = 3;
            // 
            // gbMesAno
            // 
            gbMesAno.Controls.Add(rbAnos);
            gbMesAno.Controls.Add(rbMeses);
            gbMesAno.Location = new Point(25, 155);
            gbMesAno.Name = "gbMesAno";
            gbMesAno.Size = new Size(149, 70);
            gbMesAno.TabIndex = 31;
            gbMesAno.TabStop = false;
            gbMesAno.Text = "Tempo decorrido";
            // 
            // rbAnos
            // 
            rbAnos.AutoSize = true;
            rbAnos.Location = new Point(5, 40);
            rbAnos.Name = "rbAnos";
            rbAnos.Size = new Size(52, 19);
            rbAnos.TabIndex = 15;
            rbAnos.TabStop = true;
            rbAnos.Text = "Anos";
            rbAnos.UseVisualStyleBackColor = true;
            // 
            // rbMeses
            // 
            rbMeses.AutoSize = true;
            rbMeses.Location = new Point(5, 20);
            rbMeses.Name = "rbMeses";
            rbMeses.Size = new Size(58, 19);
            rbMeses.TabIndex = 14;
            rbMeses.TabStop = true;
            rbMeses.Text = "Meses";
            rbMeses.UseVisualStyleBackColor = true;
            // 
            // tbEmprestimo
            // 
            tbEmprestimo.Location = new Point(220, 35);
            tbEmprestimo.Name = "tbEmprestimo";
            tbEmprestimo.Size = new Size(121, 23);
            tbEmprestimo.TabIndex = 0;
            // 
            // nudJuros
            // 
            nudJuros.DecimalPlaces = 2;
            nudJuros.Location = new Point(220, 115);
            nudJuros.Name = "nudJuros";
            nudJuros.Size = new Size(120, 23);
            nudJuros.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 120);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 28;
            label2.Text = "Média Taxa de Juros (%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 27;
            label1.Text = "Montante Inicial do Empréstimo: ";
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(25, 231);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(315, 23);
            btCalcular.TabIndex = 4;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // lbResposta
            // 
            lbResposta.AutoSize = true;
            lbResposta.Location = new Point(25, 260);
            lbResposta.Name = "lbResposta";
            lbResposta.Size = new Size(0, 15);
            lbResposta.TabIndex = 25;
            // 
            // tbMensal
            // 
            tbMensal.Location = new Point(220, 75);
            tbMensal.Name = "tbMensal";
            tbMensal.Size = new Size(121, 23);
            tbMensal.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 80);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 33;
            label3.Text = "Montante Mensal";
            // 
            // lbAjuda
            // 
            lbAjuda.AutoSize = true;
            lbAjuda.Location = new Point(15, 285);
            lbAjuda.Name = "lbAjuda";
            lbAjuda.Size = new Size(38, 15);
            lbAjuda.TabIndex = 34;
            lbAjuda.Text = "Ajuda";
            lbAjuda.Click += lbAjuda_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 311);
            Controls.Add(lbAjuda);
            Controls.Add(tbMensal);
            Controls.Add(label3);
            Controls.Add(nudTempo);
            Controls.Add(gbMesAno);
            Controls.Add(tbEmprestimo);
            Controls.Add(nudJuros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCalcular);
            Controls.Add(lbResposta);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fim Emprestimo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTempo).EndInit();
            gbMesAno.ResumeLayout(false);
            gbMesAno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJuros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private NumericUpDown nudTempo;
        private GroupBox gbMesAno;
        private RadioButton rbAnos;
        private RadioButton rbMeses;
        private TextBox tbEmprestimo;
        private NumericUpDown nudJuros;
        private Label label2;
        private Label label1;
        private Button btCalcular;
        private Label lbResposta;
        private ToolStripMenuItem prestaçãoToolStripMenuItem;
        private ToolStripMenuItem emprestimoMáximoToolStripMenuItem;
        private ToolStripMenuItem fimEmprestimoToolStripMenuItem;
        private TextBox tbMensal;
        private Label label3;
        private ToolTip toolTip1;
        private Label lbAjuda;
    }
}