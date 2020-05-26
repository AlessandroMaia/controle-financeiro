using ControleFinanceiro.Properties;
using ControleFinanceiro.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class FormTelaInicial : Form
    {
        private string CaminhoDaPastaDeImagens = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace(@"bin\Debug\" , @"Imagens\");
        private Button btnSelecionado;
        private Panel pnlSelecionado;

        public FormTelaInicial()
        {
            InitializeComponent();
        }
        private void CarregarPainelFilho(object FormFilho)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);
            Form f = FormFilho as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(f);
            this.pnlPrincipal.Tag = f;
            f.Show();
        }
        private void BotaoSelecionado(Panel lateralDoBotao, Button button,  string nomeDaImagemAzul)
        {
            if (button.ForeColor != Color.FromArgb(68, 138, 255))
            {
                lateralDoBotao.BackColor = Color.FromArgb(68, 138, 255);
                button.ForeColor = Color.FromArgb(68, 138, 255);
                button.Image = Image.FromFile(CaminhoDaPastaDeImagens + nomeDaImagemAzul);
                if (btnSelecionado != null)
                {
                    pnlSelecionado.BackColor = Color.FromArgb(51, 51, 51);
                    btnSelecionado.ForeColor = Color.FromArgb(186, 186, 186);
                    btnSelecionado.Image = Image.FromFile(CaminhoDaPastaDeImagens + btnSelecionado.Name + "Cinza.png");
                }
                btnSelecionado = button;
                pnlSelecionado = lateralDoBotao;
            }
        }

        private void btnRecolherMenu_MouseHover(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 200)
            {
                btnRecolherMenu.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconRecolherMenuAzul.png");
            }
            else
            {
                btnRecolherMenu.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconAmpliarMenuAzul.png");
            }
        }
        private void btnRecolherMenu_MouseLeave(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 200)
            {
                btnRecolherMenu.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconRecolherMenu.png");
            }
            else
            {
                btnRecolherMenu.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconAmpliarMenu.png");
            }
        }
        private void btnMinimizarJanela_MouseHover(object sender, EventArgs e)
        {
            btnMinimizarJanela.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconMinimizarJanelaAzul.png");
        }
        private void btnMinimizarJanela_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizarJanela.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconMinimizarJanela.png");
        }
        private void btnFecharJanela_MouseHover(object sender, EventArgs e)
        {
            btnFecharJanela.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconFecharJanelaAzul.png");
        }
        private void btnFecharJanela_MouseLeave(object sender, EventArgs e)
        {
            btnFecharJanela.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconFecharJanela.png");
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(pnlBorderBtnDashboard, btnDashboard, "btnDashboardAzul.png");
        }
        private void btnTransacao_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(pnlBorderBtnTransacao, btnTransacao, "btnTransacaoAzul.png");
            CarregarPainelFilho(new FormTransacao());
        }
        private void btnConta_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(pnlBorderBtnConta, btnConta, "btnContaAzul.png");
        }
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(pnlBorderBtnRelatorio, btnRelatorio, "btnRelatorioAzul.png");
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(pnlBorderBtnCategoria, btnCategoria, "btnCategoriaAzul.png");
            CarregarPainelFilho(new FormCategoria());
        }
        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(pnlBorderBtnConfiguracao, btnConfiguracao, "btnConfiguracaoAzul.png");
            CarregarPainelFilho(new FormConfiguracao());
        }
        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarJanela_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnRecolherMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 200)
            {
                btnRecolherMenu.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconAmpliarMenu.png");
                pnlMenu.Width = 50;
            }
            else
            {
                btnRecolherMenu.Image = Image.FromFile(CaminhoDaPastaDeImagens + "IconRecolherMenu.png");
                pnlMenu.Width = 200;
            }
        }
    }
}
