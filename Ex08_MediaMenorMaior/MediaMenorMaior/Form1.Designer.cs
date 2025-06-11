namespace MediaMenorMaior
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
            btnCalcular = new Button();
            btnLimpar = new Button();
            lbEscrever = new Label();
            numericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 41);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(160, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 70);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 23);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbEscrever
            // 
            lbEscrever.AutoSize = true;
            lbEscrever.Location = new Point(12, 106);
            lbEscrever.Name = "lbEscrever";
            lbEscrever.Size = new Size(0, 15);
            lbEscrever.TabIndex = 3;
            // 
            // numericUpDown
            // 
            numericUpDown.DecimalPlaces = 2;
            numericUpDown.Location = new Point(12, 12);
            numericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(160, 23);
            numericUpDown.TabIndex = 4;
            numericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 211);
            Controls.Add(numericUpDown);
            Controls.Add(lbEscrever);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lbEscrever;
        private NumericUpDown numericUpDown;
    }
}
