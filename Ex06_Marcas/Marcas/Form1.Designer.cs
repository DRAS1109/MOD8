namespace Marcas
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
            lbMarcas = new Label();
            cbMarcas = new ComboBox();
            lbEscolhidas = new Label();
            lstEscolhidas = new ListBox();
            btRemover = new Button();
            btLimpar = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // lbMarcas
            // 
            lbMarcas.AutoSize = true;
            lbMarcas.Location = new Point(29, 24);
            lbMarcas.Name = "lbMarcas";
            lbMarcas.Size = new Size(45, 15);
            lbMarcas.TabIndex = 0;
            lbMarcas.Text = "Marcas";
            // 
            // cbMarcas
            // 
            cbMarcas.FormattingEnabled = true;
            cbMarcas.Location = new Point(29, 49);
            cbMarcas.Name = "cbMarcas";
            cbMarcas.Size = new Size(121, 23);
            cbMarcas.TabIndex = 1;
            toolTip1.SetToolTip(cbMarcas, "Escolha uma marca");
            cbMarcas.SelectedIndexChanged += cbMarcas_SelectedIndexChanged;
            // 
            // lbEscolhidas
            // 
            lbEscolhidas.AutoSize = true;
            lbEscolhidas.Location = new Point(209, 24);
            lbEscolhidas.Name = "lbEscolhidas";
            lbEscolhidas.Size = new Size(62, 15);
            lbEscolhidas.TabIndex = 2;
            lbEscolhidas.Text = "Escolhidas";
            // 
            // lstEscolhidas
            // 
            lstEscolhidas.FormattingEnabled = true;
            lstEscolhidas.ItemHeight = 15;
            lstEscolhidas.Location = new Point(209, 49);
            lstEscolhidas.Name = "lstEscolhidas";
            lstEscolhidas.Size = new Size(124, 109);
            lstEscolhidas.TabIndex = 3;
            toolTip1.SetToolTip(lstEscolhidas, "Marcas escolhidas");
            // 
            // btRemover
            // 
            btRemover.Location = new Point(209, 176);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(124, 23);
            btRemover.TabIndex = 4;
            btRemover.Text = "Remover";
            toolTip1.SetToolTip(btRemover, "Remove a marca selecionada");
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(209, 205);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(124, 23);
            btLimpar.TabIndex = 5;
            btLimpar.Text = "Limpar";
            toolTip1.SetToolTip(btLimpar, "Limpa todas as marcas");
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(btLimpar);
            Controls.Add(btRemover);
            Controls.Add(lstEscolhidas);
            Controls.Add(lbEscolhidas);
            Controls.Add(cbMarcas);
            Controls.Add(lbMarcas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Escolha as suas marcas favoritas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMarcas;
        private ComboBox cbMarcas;
        private Label lbEscolhidas;
        private ListBox lstEscolhidas;
        private Button btRemover;
        private Button btLimpar;
        private ToolTip toolTip1;
    }
}
