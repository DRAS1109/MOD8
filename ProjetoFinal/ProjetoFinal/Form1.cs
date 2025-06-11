namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        private static bool SplashExibido = false;
        public Form1()
        {
            InitializeComponent();

            if (SplashExibido == false)
            {
                f_Splash F = new f_Splash();
                F.ShowDialog();
                SplashExibido = true;
            }
        }

        private void prestacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Esconde o Form2
            this.Hide();

            // Cria e mostra o novo Form
            Form2 nForm = new Form2();
            nForm.ShowDialog();

            // Fecha o Form2
            this.Close();
        }

        private void emprestimoMaximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Esconde o Form3
            this.Hide();

            // Cria e mostra o novo Form
            Form3 nForm = new Form3();
            nForm.ShowDialog();

            // Fecha o Form3
            this.Close();
        }

        private void fimEmprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Esconde o Form4
            this.Hide();

            // Cria e mostra o novo Form
            Form4 nForm = new Form4();
            nForm.ShowDialog();

            // Fecha o Form4
            this.Close();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://clientebancario.bportugal.pt/pt-pt",
                UseShellExecute = true
            });
        }
    }
}