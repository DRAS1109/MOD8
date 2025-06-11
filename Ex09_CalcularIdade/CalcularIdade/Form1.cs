namespace CalcularIdade
{
    public partial class Form1 : Form
    {
        //Construtor do formulario
        public Form1()
        {
            InitializeComponent();
            //Definir como data maxima a data atual
            dtDataNasc.MaxDate = DateTime.Now;
        }

        //Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Terminar a aplicação
            Application.Exit();
        }

        //Sobre
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir o formulario Sobre
            f_Sobre form = new f_Sobre();
            form.ShowDialog();
        }

        //Calcular idade
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DataAtual = DateTime.Now;
            DateTime DataNascimento = dtDataNasc.Value;

            //Calcular a diferença entre a data atual e a data nascimento
            TimeSpan Tempo = DataAtual.Date - DataNascimento.Date;

            lbResultado.Text = ((int)(Tempo.TotalDays / 365)).ToString();

            //Verificar se o ano é bissexto
            if (DateTime.IsLeapYear(DataNascimento.Year))
            {
                lbResultado.Text += " anos. \nNasceu num ano bissexto.";
            }

            else
            {
                lbResultado.Text += " anos. \nNasceu num ano regular.";
            }
        }
    }
}
