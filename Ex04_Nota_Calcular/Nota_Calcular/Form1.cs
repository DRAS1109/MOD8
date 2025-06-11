namespace Nota_Calcular
{
    public partial class Form1 : Form
    {
        float Nota;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardar os dados do formulario
                string Nome = tbNome.Text;
                int Teste = Convert.ToInt32(tbTeste.Text);
                int Desafio = Convert.ToInt32(tbDesafio.Text);
                int Projeto = Convert.ToInt32(tbProjeto.Text);

                //Validações
                if (Teste < 0 || Teste > 20)
                {
                    MessageBox.Show("A nota do teste não é válida. Deve ser um valor entre 0 e 20"); return;
                }

                //Calcular a nota
                Nota = (float)((Teste * 0.3) + (Desafio * 0.3) + (Projeto * 0.4));

                //Mostrar
                lbApresentar.Text = $"{Nome} a tua nota final é {Nota}";

                if (Nota >= 10)
                {
                    lbApresentar.Text += "\nTens positiva";
                    lbApresentar.ForeColor = Color.Green; //Alterar a cor do texto
                }

                else
                {
                    lbApresentar.Text += "\nTens negativa";
                    lbApresentar.ForeColor = Color.Red;
                }
            }
            catch (Exception error) //Se ocorrer um erro
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
