namespace Calculadora
{
    public partial class Form1 : Form
    {
        //variaveis da class
        string Operacao;
        float PrimeiroNumero;

        public Form1()
        {
            InitializeComponent();
            tbPainel.Text = "0";
        }

        // Evento para todos os Numeros
        private void button0_Click(object sender, EventArgs e)
        {
            //Converter o sender num botão
            Button bt = (Button)sender;
            tbPainel.Text += bt.Text;
        }

        // Botão Operação
        private void buttonSoma_Click(object sender, EventArgs e)
        {
            //Guardar a operação selecionada
            Button bt = (Button)sender;
            Operacao = bt.Text;

            //Guardar o nº atual
            PrimeiroNumero = Convert.ToSingle(tbPainel.Text);

            //limpar o painel
            tbPainel.Text = "0";
        }

        // Botão Igual =
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            //Guardar o nº atual
            float SegundoNumero = Convert.ToSingle(tbPainel.Text);
            float Resultado = 0;

            //Verificar qual é a operação
            switch (Operacao)
            {
                //Executar a operação
                case "+":
                    Resultado = PrimeiroNumero + SegundoNumero;
                    break;

                case "-":
                    Resultado = PrimeiroNumero - SegundoNumero;
                    break;

                case "/":
                    Resultado = PrimeiroNumero / SegundoNumero;
                    break;

                case "*":
                    Resultado = PrimeiroNumero * SegundoNumero;
                    break;

                default:
                    MessageBox.Show("Operação não está definida");
                    break;
            }

            //Limpar a operação
            Operacao = "";

            //Guardar o resultado no painel e na variavel
            tbPainel.Text = Resultado.ToString();
            PrimeiroNumero = Resultado;
        }

        // Botão limpar
        private void buttonC_Click(object sender, EventArgs e)
        {
            tbPainel.Text = "0";
            Operacao = "";
            PrimeiroNumero = 0;
        }
    }
}
