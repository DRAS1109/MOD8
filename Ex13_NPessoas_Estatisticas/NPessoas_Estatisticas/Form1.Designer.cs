namespace NPessoas_Estatisticas
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
            numericUpDown = new NumericUpDown();
            lbNPessoas = new Label();
            btEntrar = new Button();
            btSair = new Button();
            btEstatisticas = new Button();
            lbRelogio = new Label();
            lbAtual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(90, 23);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(120, 23);
            numericUpDown.TabIndex = 0;
            // 
            // lbNPessoas
            // 
            lbNPessoas.AutoSize = true;
            lbNPessoas.Location = new Point(20, 23);
            lbNPessoas.Name = "lbNPessoas";
            lbNPessoas.Size = new Size(65, 15);
            lbNPessoas.TabIndex = 1;
            lbNPessoas.Text = "Nº Pessoas";
            // 
            // btEntrar
            // 
            btEntrar.Location = new Point(20, 87);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(93, 23);
            btEntrar.TabIndex = 2;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = true;
            btEntrar.Click += btEntrar_Click;
            // 
            // btSair
            // 
            btSair.Location = new Point(117, 87);
            btSair.Name = "btSair";
            btSair.Size = new Size(93, 23);
            btSair.TabIndex = 3;
            btSair.Text = "Sair";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // btEstatisticas
            // 
            btEstatisticas.Location = new Point(20, 130);
            btEstatisticas.Name = "btEstatisticas";
            btEstatisticas.Size = new Size(190, 23);
            btEstatisticas.TabIndex = 4;
            btEstatisticas.Text = "Estatisticas";
            btEstatisticas.UseVisualStyleBackColor = true;
            btEstatisticas.Click += btEstatisticas_Click;
            // 
            // lbRelogio
            // 
            lbRelogio.AutoSize = true;
            lbRelogio.Location = new Point(21, 167);
            lbRelogio.Name = "lbRelogio";
            lbRelogio.Size = new Size(0, 15);
            lbRelogio.TabIndex = 5;
            // 
            // lbAtual
            // 
            lbAtual.AutoSize = true;
            lbAtual.Location = new Point(21, 54);
            lbAtual.Name = "lbAtual";
            lbAtual.Size = new Size(0, 15);
            lbAtual.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(lbAtual);
            Controls.Add(lbRelogio);
            Controls.Add(btEstatisticas);
            Controls.Add(btSair);
            Controls.Add(btEntrar);
            Controls.Add(lbNPessoas);
            Controls.Add(numericUpDown);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown;
        private Label lbNPessoas;
        private Button btEntrar;
        private Button btSair;
        private Button btEstatisticas;
        private Label lbRelogio;
        private Label lbAtual;
        private System.Windows.Forms.Timer timer1;
    }
}
