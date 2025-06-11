namespace ProjetoFinal
{
    partial class Form3
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
            prestacaoToolStripMenuItem = new ToolStripMenuItem();
            emprestimoMaximoToolStripMenuItem = new ToolStripMenuItem();
            fimEmprestimoToolStripMenuItem = new ToolStripMenuItem();
            nudPrazo = new NumericUpDown();
            gbMesAno = new GroupBox();
            rbAnos = new RadioButton();
            rbMeses = new RadioButton();
            tbEmprestimo = new TextBox();
            nudJuros = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btCalcular = new Button();
            lbResposta = new Label();
            toolTip1 = new ToolTip(components);
            lbAjuda = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrazo).BeginInit();
            gbMesAno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJuros).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { prestacaoToolStripMenuItem, emprestimoMaximoToolStripMenuItem, fimEmprestimoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(364, 24);
            menuStrip1.TabIndex = 0;
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
            // 
            // fimEmprestimoToolStripMenuItem
            // 
            fimEmprestimoToolStripMenuItem.Name = "fimEmprestimoToolStripMenuItem";
            fimEmprestimoToolStripMenuItem.Size = new Size(106, 20);
            fimEmprestimoToolStripMenuItem.Text = "Fim Emprestimo";
            fimEmprestimoToolStripMenuItem.Click += fimEmprestimoToolStripMenuItem_Click;
            // 
            // nudPrazo
            // 
            nudPrazo.Location = new Point(220, 130);
            nudPrazo.Name = "nudPrazo";
            nudPrazo.Size = new Size(120, 23);
            nudPrazo.TabIndex = 2;
            // 
            // gbMesAno
            // 
            gbMesAno.Controls.Add(rbAnos);
            gbMesAno.Controls.Add(rbMeses);
            gbMesAno.Location = new Point(25, 110);
            gbMesAno.Name = "gbMesAno";
            gbMesAno.Size = new Size(149, 70);
            gbMesAno.TabIndex = 30;
            gbMesAno.TabStop = false;
            gbMesAno.Text = "Prazo";
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
            nudJuros.Location = new Point(220, 75);
            nudJuros.Name = "nudJuros";
            nudJuros.Size = new Size(120, 23);
            nudJuros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 27;
            label2.Text = "Média Taxa de Juros (%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 26;
            label1.Text = "Montante Mensal:";
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(25, 200);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(315, 23);
            btCalcular.TabIndex = 3;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // lbResposta
            // 
            lbResposta.AutoSize = true;
            lbResposta.Location = new Point(25, 240);
            lbResposta.Name = "lbResposta";
            lbResposta.Size = new Size(0, 15);
            lbResposta.TabIndex = 24;
            // 
            // lbAjuda
            // 
            lbAjuda.AutoSize = true;
            lbAjuda.Font = new Font("Segoe UI", 10F);
            lbAjuda.Location = new Point(15, 285);
            lbAjuda.Name = "lbAjuda";
            lbAjuda.Size = new Size(44, 19);
            lbAjuda.TabIndex = 31;
            lbAjuda.Text = "Ajuda";
            lbAjuda.Click += lbAjuda_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 311);
            Controls.Add(lbAjuda);
            Controls.Add(nudPrazo);
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
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emprestimo Maximo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrazo).EndInit();
            gbMesAno.ResumeLayout(false);
            gbMesAno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJuros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem prestacaoToolStripMenuItem;
        private ToolStripMenuItem emprestimoMaximoToolStripMenuItem;
        private ToolStripMenuItem fimEmprestimoToolStripMenuItem;
        private NumericUpDown nudPrazo;
        private GroupBox gbMesAno;
        private RadioButton rbAnos;
        private RadioButton rbMeses;
        private TextBox tbEmprestimo;
        private NumericUpDown nudJuros;
        private Label label2;
        private Label label1;
        private Button btCalcular;
        private Label lbResposta;
        private ToolTip toolTip1;
        private Label lbAjuda;
    }
}