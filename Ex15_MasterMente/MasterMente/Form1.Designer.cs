namespace MasterMente
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
            lbTentativas = new ListBox();
            btConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            tbUtilizador = new TextBox();
            lbCorreta = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lbTentativas
            // 
            lbTentativas.FormattingEnabled = true;
            lbTentativas.ItemHeight = 15;
            lbTentativas.Location = new Point(160, 145);
            lbTentativas.Name = "lbTentativas";
            lbTentativas.Size = new Size(100, 94);
            lbTentativas.TabIndex = 0;
            // 
            // btConfirmar
            // 
            btConfirmar.Location = new Point(280, 100);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(75, 23);
            btConfirmar.TabIndex = 1;
            btConfirmar.Text = "Testar";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 2;
            label1.Text = "Tente adivinhar a combinação de números";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 3;
            label2.Text = "Combinação secreta: ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbUtilizador
            // 
            tbUtilizador.Location = new Point(160, 100);
            tbUtilizador.Name = "tbUtilizador";
            tbUtilizador.Size = new Size(100, 23);
            tbUtilizador.TabIndex = 4;
            // 
            // lbCorreta
            // 
            lbCorreta.AutoSize = true;
            lbCorreta.Location = new Point(160, 80);
            lbCorreta.Name = "lbCorreta";
            lbCorreta.Size = new Size(27, 15);
            lbCorreta.TabIndex = 5;
            lbCorreta.Text = "****";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 255);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "X - Errado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 280);
            label4.Name = "label4";
            label4.Size = new Size(199, 15);
            label4.TabIndex = 7;
            label4.Text = "E - Existe mas está na posição errada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 305);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "C - Correto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbCorreta);
            Controls.Add(tbUtilizador);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btConfirmar);
            Controls.Add(lbTentativas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbTentativas;
        private Button btConfirmar;
        private Label label1;
        private Label label2;
        private TextBox tbUtilizador;
        private Label lbCorreta;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
