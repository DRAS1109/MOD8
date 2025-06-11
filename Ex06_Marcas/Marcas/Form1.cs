namespace Marcas
{
    public partial class Form1 : Form
    {
        //Array de strings
        string[] Marcas1 = { "Opel", "Mercedes", "Audi" };
        string[] Marcas2 = { "Ferrari", "Peugeot", "Papa Reformas" };

        //Criar um array vazio de 4 strings
        string[] Teste = new string[4];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Evento é executado antes do formulario ser mostrado para o utilizador
            cbMarcas.Items.Add("Ford");              //Adicionar item a item
            cbMarcas.Items.AddRange(Marcas1);        //Adicionar array de uma só vez
            for (int i = 0; i < Marcas2.Length; i++) //Adicionar o array um de cada vez
                cbMarcas.Items.Add(Marcas2[i]);

            //Bloqueat a combobox para obrigar a escolher uma lista
            cbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //Evento ocorre quando é escolhida uma marca
        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarcas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma marca."); return;
            }

            int Posicao = cbMarcas.SelectedIndex;
            string MarcaEscolhida = cbMarcas.Items[Posicao].ToString();


            //Adicionar a Marca Escolhida 
            lstEscolhidas.Items.Add(MarcaEscolhida);

            //Remover a marca escolhida da combobox
            cbMarcas.Items.RemoveAt(Posicao);
        }

        //Botão Limpar
        private void btLimpar_Click(object sender, EventArgs e)
        {
            //Remover todos os items da listbox
            lstEscolhidas.Items.Clear();

            //Repõe todos os items na combobox
            cbMarcas.Items.Clear();

            cbMarcas.Items.Add("Ford");              //Adicionar item a item
            cbMarcas.Items.AddRange(Marcas1);        //Adicionar array de uma só vez
            for (int i = 0; i < Marcas2.Length; i++) //Adicionar o array um de cada vez
                cbMarcas.Items.Add(Marcas2[i]);
        }

        //Botão Remover
        private void btRemover_Click(object sender, EventArgs e)
        {
            //Caso não tenha nenhum items selecionado deve mostrar um aviso
            if (lstEscolhidas.SelectedIndex == -1)
            {
                MessageBox.Show("Tem de selecionar uma marca primeiro"); return;
            }

            //Remove o item selecionado na listbox
            string MarcaEscolhida = lstEscolhidas.Items[lstEscolhidas.SelectedIndex].ToString();
            cbMarcas.Items.Add(MarcaEscolhida);
            lstEscolhidas.Items.RemoveAt(lstEscolhidas.SelectedIndex);
        }
    }
}
