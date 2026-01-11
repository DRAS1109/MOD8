namespace Windows_Ola_Mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criar variavel para o nome
            string Nome;

            // Guardar o texto da tbNome
            Nome = tbNome.Text;

            // Alterar a mensagem do lbMensagem
            lbMensagem.Text = "Olá, " + Nome;
            tbNome.Text = "";

            // Ativar o botão para limpar
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpar tudo
            lbMensagem.Text = "";
            tbNome.Text = "";

            // Desativar o botão para limpar
            button2.Enabled = false;
        }
    }
}
