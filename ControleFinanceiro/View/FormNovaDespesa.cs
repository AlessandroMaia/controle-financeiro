using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.View
{
    public partial class FormNovaDespesa : Form
    {
        public FormNovaDespesa()
        {
            InitializeComponent();
        }


        private void btnMaisDetalhes_Click(object sender, EventArgs e)
        {
            if (this.Width == 454)
            {
                this.Width = 804;
                btnMaisDetalhes.Text = "Mais detalhes <";
            }
            else
            {
                this.Width = 454;
                btnMaisDetalhes.Text = "Mais detalhes >";
            }
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
