namespace Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Carregar Imagem
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Ficheiro = new OpenFileDialog();
            Ficheiro.Filter = "Imagens|*.png;*.jpg|Todos|*.*";

            //Abre a janela para escolher um ficheiro e espera até fechar
            Ficheiro.ShowDialog();

            //Verificar se escolheu um ficheiro
            if (Ficheiro.FileName == "")
                return;

            //Carregar a Imagem do ficheiro escolhido
            pictureBox1.Image = Image.FromFile(Ficheiro.FileName);

        }

        //Limpar Imagem
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
