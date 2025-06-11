using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPessoas_Estatisticas
{
    public partial class Form3 : Form
    {
        public Form3(string mensagem)
        {
            InitializeComponent();
            lbMensagem.Text = mensagem;
        }
    }
}
