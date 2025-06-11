namespace NPessoas_Estatisticas
{
    public partial class Form1 : Form
    {
        //Variaveis Globais
        int Max = int.MinValue, MaxEspaco, Soma, Contar, Espaco;

        public Form1()
        {
            InitializeComponent();
            lbAtual.Text = "Pessoas na loja: 0";
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Agora = DateTime.Now;
            lbRelogio.Text = Agora.ToString("HH:mm:ss");
        }

        //Botão Entrar
        private void btEntrar_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown.Value + Espaco > 100)
            {
                MessageBox.Show("Não pode ultrapassar 100 pessoas m simultaneo na loja");
                return;
            }

            int NEntrar = (int)numericUpDown.Value;
            Soma += NEntrar;
            Contar ++;

            Espaco += NEntrar;

            if (NEntrar > Max)
                Max = NEntrar;

            if (Espaco > MaxEspaco)
                MaxEspaco = Espaco;

            lbAtual.Text = "Pessoas na loja: " + Espaco;
        }

        //Botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown.Value > Espaco)
            {
                MessageBox.Show("Não podem sair mais pessoas do que as que entraram");
                return;
            }

            Espaco -= (int)numericUpDown.Value;
            numericUpDown.Value = 1;
            lbAtual.Text = "Pessoas na loja: " + Espaco;

        }

        //Botão Estatisticas
        private void btEstatisticas_Click(object sender, EventArgs e)
        {   
            if (Contar == 0)
            {
                MessageBox.Show("Ainda ninguem entrou");
                return;
            }

            //Criar um objeto de tipo objeto
            Form2 f = new Form2();

            float Media = (float)Soma / Contar;

            string Mensagem = $"Maior Nº de Pessoas que entraram: {Max} \n" +
                              $"Média de pessoas que entram: {Media} \n" +
                              $"Maximo de pessoas dentro do espaço: {MaxEspaco}";
            f.lbMensagem.Text = Mensagem;
            f.ShowDialog();

            //Segundo método que passa a mensage, pelo construtor
            Form3 f3 = new Form3(Mensagem);
            f3.ShowDialog();
        }
    }
}
