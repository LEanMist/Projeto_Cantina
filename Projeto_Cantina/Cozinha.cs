using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cantina
{
    public partial class Cozinha : Form
    {
        private List<Pedido> pedidosPendentes = new List<Pedido>();
        private List<Pedido> pedidosCozinha = new List<Pedido>();
        private List<Pedido> pedidosConcluidos = new List<Pedido>();
        private List<Pedido> pedidosPreparacao = new List<Pedido>();
        public Cozinha()
        {
            InitializeComponent();
        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            AtualizarListas();
        }
        private void AtualizarListas()
        {
            ListaCozinha.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.PedidosCozinha)
            {
                ListaCozinha.Items.Add($"Cliente: {pedido.NomeCliente}\n - Preparar: {ResumoProdutos(pedido)}\n");
            }
            ListaConcluidosCozinha.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.CozinhaConcluidos)
            {
                ListaConcluidosCozinha.Items.Add($"Cliente: {pedido.NomeCliente}\n - Concluido: {ResumoProdutos(pedido)}\n");
            }
        }
        private string ResumoProdutos(Pedido pedido)
        {
            var produtosCozinha = pedido.Produtos
                                .Where(p => p.Chapa) 
                                .Select(p => $"{p.Nome} x{p.Quantidade}");

            return string.Join(", ", produtosCozinha);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            int indice = ListaCozinha.SelectedIndex;
            if (indice < 0 || indice >= GerenciadorPedidos.PedidosCozinha.Count)
            {
                MessageBox.Show("Selecione o pedido.");
                return;
            }

            Pedido pedidoSelecionado = GerenciadorPedidos.PedidosCozinha[indice];
            if (pedidoSelecionado.Produtos.Any(p => p.Chapa))
            {
                GerenciadorPedidos.ConcluirNaCozinha(pedidoSelecionado);
                AtualizarListas();
            }
            else
            {
                MessageBox.Show("Este pedido não contém produtos que precisam de preparo na chapa.");
                return;
            }
        }

        private void btnVoltarStatus_Click(object sender, EventArgs e)
        {
            int indice = ListaConcluidosCozinha.SelectedIndex;
            if (indice < 0 || indice >= GerenciadorPedidos.CozinhaConcluidos.Count)
            {
                MessageBox.Show("Selecione o pedido.");
                return;
            }

            Pedido pedidoSelecionado = GerenciadorPedidos.CozinhaConcluidos[indice];
            if (pedidoSelecionado.Produtos.Any(p => p.Chapa))
            {
                GerenciadorPedidos.VoltarStatusCozinha(pedidoSelecionado);
                AtualizarListas();
            }
            else
            {
                MessageBox.Show("Este pedido não contém produtos que precisam de preparo na chapa.");
                return;
            }
        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
