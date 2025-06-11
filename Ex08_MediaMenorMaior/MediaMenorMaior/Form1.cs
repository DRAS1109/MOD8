namespace MediaMenorMaior
{
    public partial class Form1 : Form
    {
        float Soma, Maior = float.MinValue, Menor = float.MaxValue;
        int Contar;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float Numero = (float)numericUpDown.Value;

            Contar++;
            Soma += Numero;
            double Media = Soma / Contar;

            if (Numero > Maior)
            {
                Maior = Numero;
            }
            ;

            if (Numero < Menor)
            {
                Menor = Numero;
            }

            lbEscrever.Text = $"Média: {Math.Round(Media, 2)} \nMaior: {Maior} \nMenor: {Menor}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            Soma = Maior = Menor = Contar = 0;
            lbEscrever.Text = "";
        }
    }
}
