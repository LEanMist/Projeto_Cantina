using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina1
{
    public partial class FormFormaPagamento : Form
    {
        public string FormaSelecionada { get; private set; } = "";
        public FormFormaPagamento()
        {
            InitializeComponent();
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            FormaSelecionada = "Dinheiro";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCartao_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("É cartão de Crédito?", "Tipo de Cartão",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
                FormaSelecionada = "Cartão (Crédito)";
            else
                FormaSelecionada = "Cartão (Débito)";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            FormaSelecionada = "Pix";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
