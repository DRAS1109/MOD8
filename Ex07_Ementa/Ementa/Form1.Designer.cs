namespace Ementa
{
    partial class Ementa
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
            checkBoxVegetariano = new CheckBox();
            radioButtonSobremesa = new RadioButton();
            groupBoxPratos = new GroupBox();
            radioButtonBebida = new RadioButton();
            radioButtonPrato = new RadioButton();
            Confirmar = new Button();
            listBoxTodas = new ListBox();
            listBoxSelecionadas = new ListBox();
            groupBoxPratos.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxVegetariano
            // 
            checkBoxVegetariano.AutoSize = true;
            checkBoxVegetariano.Location = new Point(29, 23);
            checkBoxVegetariano.Name = "checkBoxVegetariano";
            checkBoxVegetariano.Size = new Size(88, 19);
            checkBoxVegetariano.TabIndex = 0;
            checkBoxVegetariano.Text = "Vegetariano";
            checkBoxVegetariano.UseVisualStyleBackColor = true;
            // 
            // radioButtonSobremesa
            // 
            radioButtonSobremesa.AutoSize = true;
            radioButtonSobremesa.Location = new Point(6, 20);
            radioButtonSobremesa.Name = "radioButtonSobremesa";
            radioButtonSobremesa.Size = new Size(83, 19);
            radioButtonSobremesa.TabIndex = 1;
            radioButtonSobremesa.TabStop = true;
            radioButtonSobremesa.Text = "Sobremesa";
            radioButtonSobremesa.UseVisualStyleBackColor = true;
            radioButtonSobremesa.CheckedChanged += radioButtonSobremesa_CheckedChanged;
            // 
            // groupBoxPratos
            // 
            groupBoxPratos.Controls.Add(radioButtonBebida);
            groupBoxPratos.Controls.Add(radioButtonPrato);
            groupBoxPratos.Controls.Add(radioButtonSobremesa);
            groupBoxPratos.Location = new Point(23, 48);
            groupBoxPratos.Name = "groupBoxPratos";
            groupBoxPratos.Size = new Size(100, 100);
            groupBoxPratos.TabIndex = 2;
            groupBoxPratos.TabStop = false;
            groupBoxPratos.Text = "Tipo de Prato";
            // 
            // radioButtonBebida
            // 
            radioButtonBebida.AutoSize = true;
            radioButtonBebida.Location = new Point(6, 70);
            radioButtonBebida.Name = "radioButtonBebida";
            radioButtonBebida.Size = new Size(61, 19);
            radioButtonBebida.TabIndex = 4;
            radioButtonBebida.TabStop = true;
            radioButtonBebida.Text = "Bebida";
            radioButtonBebida.UseVisualStyleBackColor = true;
            radioButtonBebida.CheckedChanged += radioButtonBebida_CheckedChanged;
            // 
            // radioButtonPrato
            // 
            radioButtonPrato.AutoSize = true;
            radioButtonPrato.Location = new Point(6, 45);
            radioButtonPrato.Name = "radioButtonPrato";
            radioButtonPrato.Size = new Size(53, 19);
            radioButtonPrato.TabIndex = 3;
            radioButtonPrato.TabStop = true;
            radioButtonPrato.Text = "Prato";
            radioButtonPrato.UseVisualStyleBackColor = true;
            radioButtonPrato.CheckedChanged += radioButtonPrato_CheckedChanged;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(140, 215);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(33, 23);
            Confirmar.TabIndex = 3;
            Confirmar.Text = ">>";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += button1_Click;
            // 
            // listBoxTodas
            // 
            listBoxTodas.FormattingEnabled = true;
            listBoxTodas.ItemHeight = 15;
            listBoxTodas.Location = new Point(23, 177);
            listBoxTodas.Name = "listBoxTodas";
            listBoxTodas.Size = new Size(100, 94);
            listBoxTodas.TabIndex = 4;
            listBoxTodas.SelectedIndexChanged += listBoxTodas_SelectedIndexChanged;
            // 
            // listBoxSelecionadas
            // 
            listBoxSelecionadas.FormattingEnabled = true;
            listBoxSelecionadas.ItemHeight = 15;
            listBoxSelecionadas.Location = new Point(179, 177);
            listBoxSelecionadas.Name = "listBoxSelecionadas";
            listBoxSelecionadas.Size = new Size(100, 94);
            listBoxSelecionadas.TabIndex = 5;
            // 
            // Ementa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 291);
            Controls.Add(listBoxSelecionadas);
            Controls.Add(listBoxTodas);
            Controls.Add(Confirmar);
            Controls.Add(groupBoxPratos);
            Controls.Add(checkBoxVegetariano);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Ementa";
            Text = "Form1";
            groupBoxPratos.ResumeLayout(false);
            groupBoxPratos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxVegetariano;
        private RadioButton radioButtonSobremesa;
        private GroupBox groupBoxPratos;
        private RadioButton radioButtonPrato;
        private RadioButton radioButtonBebida;
        private Button Confirmar;
        private ListBox listBoxTodas;
        private ListBox listBoxSelecionadas;
    }
}
