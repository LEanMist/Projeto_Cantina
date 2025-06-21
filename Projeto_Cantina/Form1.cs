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
    public partial class Form1 : Form
    {
        private Carrinho carrinho = new Carrinho();
        private List<Produtos> catalogo => GerenciadorProdutos.Catalogo;

        public string TipoPedido { get; set; } = "";
        private decimal troco = 0;
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            CarregarProdutos();
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            Total.Text = $"Total: R$ {carrinho.Total():F2}";
        }

        private void CarregarProdutos()
        {
            ListaProdutos.Items.Clear();
            foreach (var p in catalogo)
            {
                ListaProdutos.Items.Add(p.MostrarSemQuantidade());
            }
        }

        private void CarregarCarrinho()
        {
            ListaCarrinho.Items.Clear();
            foreach (var prod in carrinho.Items)
            {
                ListaCarrinho.Items.Add(prod); // ← adiciona o objeto
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int idx = ListaProdutos.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            var baseProd = catalogo[idx];

            if (baseProd.Estoque <= 0)
            {
                MessageBox.Show("Produto sem estoque!");
                return;
            }

            var produto = carrinho.AdicionarItem(baseProd);

            CarregarCarrinho();
            AtualizarTotal();
            CarregarProdutos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var selecionado = ListaCarrinho.SelectedItem as Produtos;
            if (selecionado == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            bool removido = carrinho.RemoverItem(selecionado);

            var removed = catalogo.FirstOrDefault(p => p.Nome == selecionado.Nome);

            CarregarCarrinho();
            AtualizarTotal();
            CarregarProdutos();
        }

        private void ResetarPedido()
        {
            carrinho.Limpar();
            ListaCarrinho.Items.Clear();
            Total.Text = "Total: R$ 0,00";
            TipoPedido = string.Empty;

            this.Close();

        }

        private string MostrarFormaPagamento()
        {
            this.Hide();
            using (var f = new Forma_de_Pagamento())
            {

                f.ItensFinalizados = carrinho.Items
                                             .Select(p => new Produtos(p.Nome, p.Preco, p.Quantidade, p.Chapa))
                                             .ToList();
                f.TotalGeral = (decimal)carrinho.Total();
                f.TipoPedido = this.TipoPedido;

                var resultado = f.ShowDialog(this);

                if (resultado == DialogResult.OK)
                {
                    this.troco = f.Troco;
                    return f.FormaSelecionada;
                }
                else
                {
                    this.Show();
                    return null; // usuário cancelou
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ListaCarrinho.Items.Count == 0)
            {
                MessageBox.Show("Adicione itens ao carrinho antes de finalizar o pedido.");
                return;
            }

            string nome = Interaction.InputBox("Digite seu nome:", "Identificação");
            if (string.IsNullOrWhiteSpace(nome)) return;

            string forma = MostrarFormaPagamento();
            if (forma == null) return;



            decimal total = (decimal)carrinho.Total();
            DateTime data = DateTime.Now;
            string resumo =
                $"{data}\n" +
                $"Pedido finalizado!\nCliente: {nome}\n" +
                $"Forma de pagamento: {forma}\n" +
                $"Total: R$ {total:F2}\n" +
                $"Tipo de Pedido: {TipoPedido}";

            if (forma == "Dinheiro" && troco > 0)
            {
                resumo += $"\nTroco: R$ {troco:F2}";
            }

            var pedido = new Pedido
            {
                NomeCliente = nome,
                Produtos = carrinho.Items.Select(p => new Produtos(p.Nome, p.Preco, p.Quantidade, p.Chapa)).ToList(),
                TipoPedido = this.TipoPedido,
                DataeHora = data,
                FormadePagamento = forma
            };


            MessageBox.Show(resumo, "Confirmação");
            GerenciadorPedidos.PedidosPendentes.Add(pedido);
            ResetarPedido();


        }

        private void btnVoltarTipo_Click(object sender, EventArgs e)
        {
            this.Hide();  // Esconde a tela da Cantina

            using (var opcoes = new OpçoesPedido())
            {
                var resultado = opcoes.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    TipoPedido = opcoes.TipoPedidoSelecionado;
                    this.Show();  // Volta pra Cantina caso o usuário apenas troque o tipo
                    MessageBox.Show($"Novo tipo de pedido selecionado: {TipoPedido}", "Atualizado");
                }
                else if (resultado == DialogResult.Cancel)
                {
                    // O usuário quis voltar pro Menu Inicial
                    RestaurarEstoqueECancelarPedido();
                    this.Close();  // Fecha a Cantina e volta pro Menu
                }
            }
        }

        private void RestaurarEstoqueECancelarPedido()
        {
            foreach (var item in carrinho.Items)
            {
                var produtoBase = catalogo.FirstOrDefault(p => p.Nome == item.Nome);
                if (produtoBase != null)
                {
                    produtoBase.Estoque += item.Quantidade; // Restaura o estoque
                }
            }
            
            ResetarPedido();
        }
    }
}
