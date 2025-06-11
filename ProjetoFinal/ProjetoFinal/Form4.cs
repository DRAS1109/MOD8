using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoFinal
{
    public partial class Form4 : Form
    {
        public Form4()
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
            // Valida inputs
            string Objeto1 = "Montante Inicial do Empréstimo", Objeto2 = "Montante Mensal", Texto = "apenas números e no máximo um separador decimal";

            float MontanteInicial = ApenasNumeros(tbEmprestimo.Text, Objeto1, Texto);
            float PrestacaoMensal = ApenasNumeros(tbMensal.Text, Objeto2, Texto);

            if (MontanteInicial == -1 || PrestacaoMensal == -1)
                return;

            float Taxa = (float)nudJuros.Value / 12 / 100;
            int Tempo = 0;
            double NMeses;
            double MontanteRestante;


            if (nudTempo.Value != 0)
            {
                if (rbMeses.Checked == false && rbAnos.Checked == false)
                {
                    MessageBox.Show("Deve escolher apresentar o Tempo em meses ou anos"); return;
                }

                if (rbMeses.Checked)
                    Tempo = (int)nudTempo.Value;

                else
                    Tempo = (int)nudTempo.Value * 12;
            }

            if (Taxa == 0)
            {
                MontanteRestante = MontanteInicial - (PrestacaoMensal * Tempo);
                NMeses = MontanteRestante / PrestacaoMensal;
            }

            else
            {
                MontanteRestante = MontanteInicial * Math.Pow(1 + Taxa, Tempo)
                              - PrestacaoMensal * (Math.Pow(1 + Taxa, Tempo) - 1) / Taxa;


                NMeses = Math.Log(PrestacaoMensal / (PrestacaoMensal - MontanteRestante * Taxa)) / Math.Log(1 + Taxa);
                NMeses = Math.Round(NMeses);
            }

            int Anos = (int)(NMeses / 12);
            int Meses = (int)Math.Round(NMeses % 12);

            if ((int)NMeses <= 0)
            {
                lbResposta.Text = $"Já acabou de pagar o empréstimo";
            }

            else
            {
                if (NMeses > 0)
                    lbResposta.Text = $"Faltam {Anos} anos e {Meses} meses para acabar de pagar o empréstimo.";

                else
                    lbResposta.Text = $"Faltam {Anos} anos para acabar de pagar o empréstimo.";

            }
        }

        private void prestaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria e mostra o novo Form
            Form2 nForm = new Form2();
            this.Close();
            nForm.ShowDialog();
        }

        private void emprestimoMáximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria e mostra o novo Form
            Form3 nForm = new Form3();
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
