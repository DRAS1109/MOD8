namespace Relogio_Russo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Atualizar a label do relogio
        void AtualizarRelogio()
        {
            DateTime Agora = DateTime.Now;

            lbRelogio.Text = Agora.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarRelogio();
        }
    }
}
