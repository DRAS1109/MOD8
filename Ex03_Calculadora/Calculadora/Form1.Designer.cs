namespace Calculadora
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonC = new Button();
            buttonIgual = new Button();
            buttonSoma = new Button();
            buttonSubtracao = new Button();
            buttonDivisao = new Button();
            buttonMultiplicacao = new Button();
            tbPainel = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 133);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button0_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 133);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button0_Click;
            // 
            // button3
            // 
            button3.Location = new Point(104, 133);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button0_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 87);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button0_Click;
            // 
            // button5
            // 
            button5.Location = new Point(58, 87);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button0_Click;
            // 
            // button6
            // 
            button6.Location = new Point(104, 87);
            button6.Name = "button6";
            button6.Size = new Size(40, 40);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button0_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 41);
            button7.Name = "button7";
            button7.Size = new Size(40, 40);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button0_Click;
            // 
            // button8
            // 
            button8.Location = new Point(58, 41);
            button8.Name = "button8";
            button8.Size = new Size(40, 40);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button0_Click;
            // 
            // button9
            // 
            button9.Location = new Point(104, 41);
            button9.Name = "button9";
            button9.Size = new Size(40, 40);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button0_Click;
            // 
            // button0
            // 
            button0.Location = new Point(58, 179);
            button0.Name = "button0";
            button0.Size = new Size(40, 40);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(12, 179);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(40, 40);
            buttonC.TabIndex = 10;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Location = new Point(104, 179);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(40, 40);
            buttonIgual.TabIndex = 11;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonSoma
            // 
            buttonSoma.Location = new Point(150, 41);
            buttonSoma.Name = "buttonSoma";
            buttonSoma.Size = new Size(40, 40);
            buttonSoma.TabIndex = 12;
            buttonSoma.Text = "+";
            buttonSoma.UseVisualStyleBackColor = true;
            buttonSoma.Click += buttonSoma_Click;
            // 
            // buttonSubtracao
            // 
            buttonSubtracao.Location = new Point(150, 87);
            buttonSubtracao.Name = "buttonSubtracao";
            buttonSubtracao.Size = new Size(40, 40);
            buttonSubtracao.TabIndex = 13;
            buttonSubtracao.Text = "-";
            buttonSubtracao.UseVisualStyleBackColor = true;
            buttonSubtracao.Click += buttonSoma_Click;
            // 
            // buttonDivisao
            // 
            buttonDivisao.Location = new Point(150, 133);
            buttonDivisao.Name = "buttonDivisao";
            buttonDivisao.Size = new Size(40, 40);
            buttonDivisao.TabIndex = 14;
            buttonDivisao.Text = "/";
            buttonDivisao.UseVisualStyleBackColor = true;
            buttonDivisao.Click += buttonSoma_Click;
            // 
            // buttonMultiplicacao
            // 
            buttonMultiplicacao.Location = new Point(150, 179);
            buttonMultiplicacao.Name = "buttonMultiplicacao";
            buttonMultiplicacao.Size = new Size(40, 40);
            buttonMultiplicacao.TabIndex = 15;
            buttonMultiplicacao.Text = "*";
            buttonMultiplicacao.UseVisualStyleBackColor = true;
            buttonMultiplicacao.Click += buttonSoma_Click;
            // 
            // tbPainel
            // 
            tbPainel.Location = new Point(12, 12);
            tbPainel.Name = "tbPainel";
            tbPainel.ReadOnly = true;
            tbPainel.Size = new Size(178, 23);
            tbPainel.TabIndex = 16;
            tbPainel.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 231);
            Controls.Add(tbPainel);
            Controls.Add(buttonMultiplicacao);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonSubtracao);
            Controls.Add(buttonSoma);
            Controls.Add(buttonIgual);
            Controls.Add(buttonC);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonC;
        private Button buttonIgual;
        private Button buttonSoma;
        private Button buttonSubtracao;
        private Button buttonDivisao;
        private Button buttonMultiplicacao;
        private TextBox tbPainel;
    }
}
