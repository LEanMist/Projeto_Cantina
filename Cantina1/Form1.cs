using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Cantina1
{
    public partial class Form1 : Form
    {
        private Carrinho carrinho = new Carrinho();
        private List<Produtos> catalogo = new List<Produtos>()
        {
            new Produtos("Pão de Queijo", 3.50),
            new Produtos("Coxinha", 5.00),
            new Produtos("Pastel de Carne", 6.00),
            new Produtos("Pastel de Queijo", 5.50),
            new Produtos("Suco Natural (300ml)", 4.00),
            new Produtos("Refrigerante Lata", 4.50),
            new Produtos("Hambúrguer Simples", 8.00),
            new Produtos("Hambúrguer com Queijo", 9.00),
            new Produtos("X-Tudo", 12.00),
            new Produtos("Água Mineral (500ml)", 2.50)
        };
        public Form1()
        {
            InitializeComponent();

            foreach (var p in catalogo)
            {
                ListaProdutos.Items.Add(p);
            }

            AtualizarTotal();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            var baseProd = ListaProdutos.SelectedItem as Produtos;
            if (baseProd == null)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            var pedido = carrinho.AdicionarProduto(baseProd);
            if (pedido != null)
            {
                ListaCarrinho.Items.Add(pedido);
                AtualizarTotal();
            }
        }


        private void Remover_Click(object sender, EventArgs e)
        {
            Produtos selecionado = ListaCarrinho.SelectedItem as Produtos;

            if (selecionado == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            bool removido = carrinho.RemoverProduto(selecionado);

            if (removido)
            {
                ListaCarrinho.Items.Remove(selecionado);
            }
            else
            {
                int i = ListaCarrinho.SelectedIndex;
                ListaCarrinho.Items[i] = selecionado;
            }

            AtualizarTotal();
        }
        private void AtualizarTotal()
        {
            Total.Text = $"Total: R${carrinho.Total():F2}";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ListaCarrinho.Items.Count == 0)
            {
                MessageBox.Show("Adicione itens ao carrinho antes de finalizar o pedido.");
                return;
            }

            string nome = Microsoft.VisualBasic.Interaction.InputBox("Digite seu nome:", "Identificação");
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Nome é obrigatório.");
                return;
            }

            string forma = MostrarSelecaoFormaPagamento();
            if (string.IsNullOrEmpty(forma)) return;

            decimal total = CalcularTotalCarrinho();
            decimal valorPago = 0;
            string resumo = $"Pedido finalizado!\nCliente: {nome}\nForma de pagamento: {forma}\nTotal: R$ {total:F2}";

            if (forma == "Dinheiro")
            {
                while (true)
                {
                    string entrada = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Total: R$ {total:F2}\nInforme o valor pago:", "Pagamento em Dinheiro");

                    if (string.IsNullOrWhiteSpace(entrada)) return;

                    if (decimal.TryParse(entrada, out valorPago))
                    {
                        if (valorPago >= total)
                        {
                            decimal troco = valorPago - total;
                            resumo += $"\nPago: R$ {valorPago:F2}\nTroco: R$ {troco:F2}";
                            break;
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

            var pedido = new Pedido(nome, carrinho.Itens);
            BancoPedidos.Pedidos.Add(pedido);

            MessageBox.Show(resumo, "Confirmação");
            ResetarPedido();
            this.Visible = true;
        }
         
        
        private string MostrarSelecaoFormaPagamento()
        {
            using (var f = new FormFormaPagamento())
            {
                this.Visible = false;
                return f.ShowDialog() == DialogResult.OK ? f.FormaSelecionada : null;
            }
        }
        private decimal CalcularTotalCarrinho()
        {
            decimal total = 0;
            foreach (Produtos p in ListaCarrinho.Items)
                total += (decimal)p.Subtotal(); 
            return total;
        }
        private void ResetarPedido()
        {
            carrinho.limpar();
            ListaCarrinho.Items.Clear();
            Total.Text = "Total: R$ 0,00"; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (var f = new Balcao())
                f.ShowDialog();
        }
    }
    
}
     
