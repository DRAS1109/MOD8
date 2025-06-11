using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIdade
{
    public partial class f_Sobre : Form
    {
        public f_Sobre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this é uma referencia para o form/objeto
            this.Close();
        }
    }
}
