namespace Nota_Calcular
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
            tbProjeto = new TextBox();
            lbProjeto = new Label();
            btCalcular = new Button();
            lbProjetoPerc = new Label();
            lbDesafioPerc = new Label();
            lbDesafio = new Label();
            tbDesafio = new TextBox();
            lbTestePerc = new Label();
            lbTeste = new Label();
            tbTeste = new TextBox();
            label5 = new Label();
            lbNome = new Label();
            tbNome = new TextBox();
            lbApresentar = new Label();
            SuspendLayout();
            // 
            // tbProjeto
            // 
            tbProjeto.Location = new Point(73, 124);
            tbProjeto.Name = "tbProjeto";
            tbProjeto.Size = new Size(167, 23);
            tbProjeto.TabIndex = 3;
            // 
            // lbProjeto
            // 
            lbProjeto.AutoSize = true;
            lbProjeto.Location = new Point(12, 127);
            lbProjeto.Name = "lbProjeto";
            lbProjeto.Size = new Size(45, 15);
            lbProjeto.TabIndex = 9;
            lbProjeto.Text = "Projeto";
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(15, 175);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(260, 23);
            btCalcular.TabIndex = 4;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // lbProjetoPerc
            // 
            lbProjetoPerc.AutoSize = true;
            lbProjetoPerc.Location = new Point(243, 127);
            lbProjetoPerc.Name = "lbProjetoPerc";
            lbProjetoPerc.Size = new Size(29, 15);
            lbProjetoPerc.TabIndex = 12;
            lbProjetoPerc.Text = "40%";
            // 
            // lbDesafioPerc
            // 
            lbDesafioPerc.AutoSize = true;
            lbDesafioPerc.Location = new Point(243, 87);
            lbDesafioPerc.Name = "lbDesafioPerc";
            lbDesafioPerc.Size = new Size(29, 15);
            lbDesafioPerc.TabIndex = 11;
            lbDesafioPerc.Text = "30%";
            // 
            // lbDesafio
            // 
            lbDesafio.AutoSize = true;
            lbDesafio.Location = new Point(12, 87);
            lbDesafio.Name = "lbDesafio";
            lbDesafio.Size = new Size(46, 15);
            lbDesafio.TabIndex = 8;
            lbDesafio.Text = "Desafio";
            // 
            // tbDesafio
            // 
            tbDesafio.Location = new Point(73, 84);
            tbDesafio.Name = "tbDesafio";
            tbDesafio.Size = new Size(167, 23);
            tbDesafio.TabIndex = 2;
            // 
            // lbTestePerc
            // 
            lbTestePerc.AutoSize = true;
            lbTestePerc.Location = new Point(243, 47);
            lbTestePerc.Name = "lbTestePerc";
            lbTestePerc.Size = new Size(29, 15);
            lbTestePerc.TabIndex = 10;
            lbTestePerc.Text = "30%";
            // 
            // lbTeste
            // 
            lbTeste.AutoSize = true;
            lbTeste.Location = new Point(12, 47);
            lbTeste.Name = "lbTeste";
            lbTeste.Size = new Size(33, 15);
            lbTeste.TabIndex = 7;
            lbTeste.Text = "Teste";
            // 
            // tbTeste
            // 
            tbTeste.Location = new Point(73, 44);
            tbTeste.Name = "tbTeste";
            tbTeste.Size = new Size(167, 23);
            tbTeste.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 15);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 12;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(12, 9);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 6;
            lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(73, 7);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(167, 23);
            tbNome.TabIndex = 0;
            // 
            // lbApresentar
            // 
            lbApresentar.AutoSize = true;
            lbApresentar.Location = new Point(15, 214);
            lbApresentar.Name = "lbApresentar";
            lbApresentar.Size = new Size(0, 15);
            lbApresentar.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(lbApresentar);
            Controls.Add(label5);
            Controls.Add(lbNome);
            Controls.Add(tbNome);
            Controls.Add(lbTestePerc);
            Controls.Add(lbTeste);
            Controls.Add(tbTeste);
            Controls.Add(lbDesafioPerc);
            Controls.Add(lbDesafio);
            Controls.Add(tbDesafio);
            Controls.Add(lbProjetoPerc);
            Controls.Add(btCalcular);
            Controls.Add(lbProjeto);
            Controls.Add(tbProjeto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Calcular Nota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProjeto;
        private Label lbProjeto;
        private Button btCalcular;
        private Label lbProjetoPerc;
        private Label lbDesafioPerc;
        private Label lbDesafio;
        private TextBox tbDesafio;
        private Label lbTestePerc;
        private Label lbTeste;
        private TextBox tbTeste;
        private Label label5;
        private Label lbNome;
        private TextBox tbNome;
        private Label lbApresentar;
    }
}
