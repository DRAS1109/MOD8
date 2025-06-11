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
    public partial class f_Splash : Form
    {
        public f_Splash()
        {
            InitializeComponent();
        }

        //Timer => 1segundo
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbTempo.Value += 20;

            if (pbTempo.Value == 100)
            {
                timer1.Enabled = false;
                this.Close();
            }

            if (lbMensagem1.Visible)
            {
                lbMensagem1.Visible = false;
                lbMensagem2.Visible = true;
            }
                
            else
            {
                lbMensagem1.Visible = true;
                lbMensagem2.Visible = false;
            }
        }
    }
}
