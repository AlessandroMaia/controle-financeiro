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
    public partial class FormBotaoNovo : Form
    {
        public FormBotaoNovo()
        {
            InitializeComponent();
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovaDespesa_Click(object sender, EventArgs e)
        {
            this.Close();
            FormNovaDespesa formNovaDespesa = new FormNovaDespesa();
            formNovaDespesa.Show();
        }
    }
}
