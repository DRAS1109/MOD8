namespace Ementa
{
    public partial class Ementa : Form
    {
        //Array de strings
        string[] Sobremesas = { "Gelado", "Bolo Bolacha", "Musse" };
        string[] Pratos = { "Bife", "Arroz Pato" };
        string[] Pratos_Vegi = { "Salada", "Tofu" };
        string[] Bebidas = { "Água", "Sumo" };

        public Ementa()
        {
            InitializeComponent();
        }

        //Preenche a listbox com o array de opções
        void PreencherListBox(ListBox listBox, string[] Opcoes)
        {
            //Limpar os pratos anteriores
            listBoxTodas.Items.Clear();

            //Adicionar ao array
            listBoxTodas.Items.AddRange(Opcoes);
        }

        //Botão Sobremesa
        private void radioButtonSobremesa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSobremesa.Checked)
            {
                PreencherListBox(listBoxTodas, Sobremesas);
            }
        }

        //Botão Prato
        private void radioButtonPrato_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrato.Checked)
            {
                //verificar se é vegeteriano
                if (checkBoxVegetariano.Checked)
                    PreencherListBox(listBoxTodas, Pratos_Vegi);

                else
                    PreencherListBox(listBoxTodas, Pratos);
            }
        }

        //Botão Bebida
        private void radioButtonBebida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBebida.Checked)
            {
                PreencherListBox(listBoxTodas, Bebidas);
            }
        }

        //Botão de comfirmar
        private void button1_Click(object sender, EventArgs e)
        {
            //Caso não tenha nenhum items selecionado deve mostrar um aviso
            if (listBoxTodas.SelectedIndex == -1)
            {
                MessageBox.Show("Tem de selecionar um prato primeiro"); return;
            }

            //Remove o item selecionado na listbox
            string Escolhida = listBoxTodas.Items[listBoxTodas.SelectedIndex].ToString();
            listBoxSelecionadas.Items.Add(Escolhida);
        }
    }
}
