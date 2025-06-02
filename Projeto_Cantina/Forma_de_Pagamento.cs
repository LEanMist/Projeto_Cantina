using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Projeto_Cantina
{
    public partial class Forma_de_Pagamento : Form
    {
        public Forma_de_Pagamento()
        {
            InitializeComponent();
        }
        public List<Produtos> ItensFinalizados { get; set; }
        public decimal TotalGeral { get; set; }

        public string FormaSelecionada { get; set; } = "";

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            decimal valorPago = 0;

            while (true)
            {
                string entrada = Interaction.InputBox(
                    $"Total: R$ {TotalGeral:F2}\nInforme o valor pago:", "Pagamento em Dinheiro");

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    return;
                }

                if (decimal.TryParse(entrada, out valorPago))
                {
                    if (valorPago >= TotalGeral)
                    {
                        decimal troco = valorPago - TotalGeral;

                        FormaSelecionada = "Dinheiro";
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Valor insuficiente. Tente novamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido.");
                }
            }
        }
        private void btnCartao_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("É cartão de Crédito?", "Tipo de Cartão",
                      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
                FormaSelecionada = "Cartão (Crédito)";
            else if (resposta == DialogResult.No)
                FormaSelecionada = "Cartão (Débito)";
            else
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("Confirmar pagamento via PIX?", "PIX",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (confirmar != DialogResult.OK)
                return; // Cancelado

            FormaSelecionada = "Pix";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Forma_de_Pagamento_Load(object sender, EventArgs e)
        {
            if (ItensFinalizados != null && ItensFinalizados.Count > 0)
            {
                Extrato.Items.Clear();

                foreach (var item in ItensFinalizados)
                {
                    Extrato.Items.Add($"{item.Nome}");
                    Extrato.Items.Add($"  Quantidade: {item.Quantidade}");
                    Extrato.Items.Add($"  Total: R$ {item.CalcularValorTotal():F2}");
                    Extrato.Items.Add("");
                }

                Extrato.Items.Add($"------------------------");
                Extrato.Items.Add($"TOTAL GERAL: R$ {TotalGeral:F2}");
            }
        }
    }
}
