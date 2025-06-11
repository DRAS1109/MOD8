namespace MediaMenorMaiorV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float N1, N2, N3, N4;
            float Maior = 0, Menor = 0;

            N1 = (float)numericUpDown1.Value;
            N2 = (float)numericUpDown2.Value;
            N3 = (float)numericUpDown3.Value;
            N4 = (float)numericUpDown4.Value;

            //Media
            float Media = (N1 + N2 + N3 + N4) / 4;

            //Maior
            if (N1 > N2)
                Maior = N1;

            else
                Maior = N2;

            if (Maior < N3)
                Maior = N3;

            if (Maior < N4)
                Maior = N4;

            //Menor
            if (N1 < N2)
                Menor = N1;

            else
                Menor = N2;

            if (Menor > N3)
                Menor = N3;

            if (Menor > N4)
                Menor = N4;

            lbEscrever.Text = $"Média: {Media} \nMaior: {Maior} \nMenor: {Menor}";
        }
    }
}
