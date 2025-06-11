namespace MasterMente
{
    public partial class Form1 : Form
    {
        //Variavel da classe
        int[] Codigo;

        public Form1()
        {
            InitializeComponent();
            Codigo = GerarCodigo();
        }

        int[] GerarCodigo()
        {
            int[] Numeros = new int[4];
            Random Sortear = new Random();
            for (int i = 0; i < 4; i++)
            {
                //Sortear um nº entre 0 e 9
                int N = Sortear.Next(0, 10); //O valor maximo é exclusivo
                if (Numeros.Contains(N))
                {
                    i -= 1;
                    continue;
                }
                Numeros[i] = N;
            }

            return Numeros;
        }

        //Recebe o código e a tentativa e devolve o feed back
        //CCCC signifiva que acertou tds os nº
        string Testar(int[] Codigo, string Tentativa)
        {
            string Resposta = "";

            //Está certo no local certo
            for (int p = 0; p < 4; p++)
            {
                string Letra = "";

                if (Tentativa[p].ToString()== Codigo[p].ToString())
                {
                    Letra = "C";
                }

                //Verificar se existe noutra posição
                {
                    for (int i = 0; Letra == "" && i < 4; i++)
                    {
                        if (Codigo[i].ToString() == Tentativa[p].ToString())
                        {
                            Letra = "E";
                            break;
                        }
                    }
                    if (Letra == "")
                        Letra = "X";

                    Resposta += Letra;
                }
            }

            return Resposta;
        }

        //Botão para testar a combinação
        private void btConfirmar_Click(object sender, EventArgs e)
        {   
            string Tentativa = tbUtilizador.Text;
            if (Tentativa.Length != 4 )
            {
                MessageBox.Show("Tem de ter 4 numeros para o código secreto."); return;
            }

            //Verificar se a tentativa tem nº repetidos
            for (int i = 0; i < 4; i++)
            {
                if (Tentativa.IndexOf(Tentativa[i]) != Tentativa.LastIndexOf(Tentativa[i]))
                {
                    MessageBox.Show("O código não tem numeros repetidos"); return;
                }
            }
            //Retirar a tentativa da tb
            tbUtilizador.Text = "";

            //Verificar
            string Teste = Testar(Codigo, Tentativa);

            //Adicionar à listbox
            string Linha = $"{Tentativa} - {Teste}";
            lbTentativas.Items.Add(Linha);

            //Se ganhou mostrar uma messagebox a perguntar se quer jogar novamente
            if (Teste == "CCCC")
            {
                DialogResult Resposta = MessageBox.Show("Acertou o código secreto, deseja jogar novamente?",
                    "Game Over", MessageBoxButtons.YesNo);

                if (Resposta == DialogResult.Yes)
                {
                    Codigo = GerarCodigo();
                    lbTentativas.Items.Clear();
                    tbUtilizador.Clear();
                    tbUtilizador.Focus();
                }

                else { this.Close(); }
            }
        }
    }
}
