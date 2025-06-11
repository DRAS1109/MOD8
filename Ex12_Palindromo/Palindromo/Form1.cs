namespace Palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            f_splash f = new f_splash();
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerificarPalindromo();
        }

        void VerificarPalindromo()
        {
            string Palavra = textBox.Text.ToLower().Trim();
            string Palavra_Invertida = "";

            //Inverter a palavra
            for (int i = 0; i < Palavra.Length; i++)
            {
                Palavra_Invertida = Palavra[i] + Palavra_Invertida;
            }

            //Comparar as duas palavras
            if (Palavra == Palavra_Invertida)
                lbResultado.Text = "É um palindromo";
            else
                lbResultado.Text = "Não é um palindromo";
        }
    }
}
