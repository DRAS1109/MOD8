using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        float ApenasNumeros(string Dados, string Objeto, string Texto)
        {
            // Substituir vírgula por ponto
            string Resultadostr = "";

            // Contar separadores (pontos)
            int ContarVirgulas = 0;
            for (int i = 0; i < Dados.Length; i++)
            {
                if (Dados[i] == ',' || Dados[i] == '.')
                {
                    Resultadostr += ',';
                    ContarVirgulas++;
                }
                else
                    Resultadostr += Dados[i];
            }

            if (ContarVirgulas > 1)
            {
                MessageBox.Show($"Os dados de {Objeto} contem mais de um separador decimal.");
                return -1;
            }

            // Se acabar em ponto, adicionar 0 (ex: "123." → "123.0")
            if (Resultadostr.EndsWith(","))
                Resultadostr += "0";

            // Verificar se só tem dígitos ou um ponto
            string Digitos = "0123456789";

            for (int i = 0; i < Resultadostr.Length; i++)
            {
                if (Digitos.Contains(Resultadostr[i]) || Resultadostr[i] == ',')
                    continue;

                else
                {
                    MessageBox.Show($"Os dados de {Objeto} contêm caracteres inválidos.\nDeve conter {Texto}.");
                    return -1;
                }
            }

            // Transformar o resultado de string para float
            float Resultado = float.Parse(Resultadostr);
            return Resultado;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (tbEmprestimo.Text == "" || nudPrazo.Value == 0)
            {
                MessageBox.Show("Deve definir valores base para o Montante do Emprestimo e Prazo"); return;
            }

            string Objeto = "Montante do Empréstimo", Texto = "apenas números e no máximo um separador decimal";
            float Montante = ApenasNumeros(tbEmprestimo.Text, Objeto, Texto);

            if (Montante == -1)
                return;

            if (rbMeses.Checked == false && rbAnos.Checked == false)
            {
                MessageBox.Show("Deve escolher apresentar o prazo em meses ou anos"); return;
            }

            float Taxa = (float)nudJuros.Value / 12 / 100;
            int Prazo;

            if (rbMeses.Checked)
                Prazo = (int)nudPrazo.Value;

            else
                Prazo = (int)nudPrazo.Value * 12;

            // Calcular a prestação mensal
            double Prestacao;
            if (Taxa == 0)
            {
                Prestacao = Montante / Prazo;
            }

            else
            {
                Prestacao = (Montante * Taxa) / (1 - Math.Pow(1 + Taxa, -Prazo));
            }

            // Calcular outros detalhes
            double TotalJuros = (Prestacao * Prazo) - Montante;
            double JurosMensais = TotalJuros / Prazo;

            lbResposta.Text = $"Prestação mensal: {Prestacao:F2}€\n" +
                $"Total de juros: {TotalJuros:F2}€\n" +
                $"Média de juros pagos mensalmene: {JurosMensais:F2}€";
        }

        private void emprestimoMaximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria e mostra o novo Form
            Form3 nForm = new Form3();
            this.Close();
            nForm.ShowDialog();
        }

        private void fimEmprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria e mostra o novo Form
            Form4 nForm = new Form4();
            this.Close();
            nForm.ShowDialog();
        }

        private void lbAjuda_Click(object sender, EventArgs e)
        {
            // Cria e mostra o novo Form
            Form1 nForm = new Form1();
            this.Close();
            nForm.ShowDialog();
        }
    }
}
