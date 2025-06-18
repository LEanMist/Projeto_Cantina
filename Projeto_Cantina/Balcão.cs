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
    public partial class Balcão : Form
    {
        public List<Pedido> pedidosPendentes = new List<Pedido>();
        public List<Pedido> pedidosEmPreparo = new List<Pedido>();
        public List<Pedido> pedidosConcluidos = new List<Pedido>();
        public Balcão()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Balcão_Load(object sender, EventArgs e)
        {
            AtualizarListas();
        }

        private void AtualizarListas()
        {
            ListaPedidos.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.PedidosPendentes)
            {
                ListaPedidos.Items.Add($"Cliente: {pedido.NomeCliente}\n  - {ResumoProdutos(pedido)}\n -- Tipo Pedido: {pedido.TipoPedido}\n");
            }

            ListaEmPreparo.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.PedidosPreparacao)
                ListaEmPreparo.Items.Add($"Cliente: {pedido.NomeCliente}\n - {ResumoProdutos(pedido)}\n -- Tipo Pedido: {pedido.TipoPedido}\n");

            ListaConcluidos.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.PedidosConcluidos)
            {
                ListaConcluidos.Items.Add($"Cliente: {pedido.NomeCliente} - {ResumoProdutos(pedido)}\n -- Tipo Pedido:  {pedido.TipoPedido} \n");
            }
        }

        private string ResumoProdutos(Pedido pedido)
        {
            return string.Join(", ", pedido.Produtos.Select(p => $"{p.Nome} x{p.Quantidade}"));
        }

        private void btnEmPreparo_Click(object sender, EventArgs e)
        {
            int indice = ListaPedidos.SelectedIndex;
            if (indice < 0 || indice >= GerenciadorPedidos.PedidosPendentes.Count)
            {
                MessageBox.Show("Selecione o pedido.");
                return;
            }

            Pedido pedidoSelecionado = GerenciadorPedidos.PedidosPendentes[indice];
            if (pedidoSelecionado.Produtos.Any(p => p.Chapa))
            {
                GerenciadorPedidos.PedidoEmPreparacao(pedidoSelecionado);
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
            int indice = ListaEmPreparo.SelectedIndex;
            if (indice < 0 || indice >= GerenciadorPedidos.PedidosPreparacao.Count)
            {
                MessageBox.Show("Selecione o pedido.");
                return;
            }

            Pedido pedidoSelecionado = GerenciadorPedidos.PedidosPreparacao[indice];
            GerenciadorPedidos.VoltarStatusBalcao(pedidoSelecionado);
            AtualizarListas();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            int indice = ListaPedidos.SelectedIndex;
            if (indice < 0 || indice >= GerenciadorPedidos.PedidosPendentes.Count)
            {
                MessageBox.Show("Selecione o pedido.");
                return;
            }

            Pedido pedidoSelecionado = GerenciadorPedidos.PedidosPendentes[indice];

            if (pedidoSelecionado.Produtos.Any(p => p.Chapa))
            {
                MessageBox.Show("Este pedido deve ir para cozinha Em Preparo");
                return;
            }
            else
            {
                GerenciadorPedidos.ConcluirPedido(pedidoSelecionado);
                AtualizarListas();
                AtualizarFormChamada();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            int indice = ListaConcluidos.SelectedIndex;
            
            if (indice < 0 || indice >= GerenciadorPedidos.PedidosConcluidos.Count)
            {
                MessageBox.Show("Selecione o pedido.");
                return;
            }

            Pedido pedidoSelecionado = GerenciadorPedidos.PedidosConcluidos[indice];
            if (pedidoSelecionado.Produtos.Any(p => p.Chapa))
            {
                MessageBox.Show("Voce não pode voltar status de um pedido ja passou pela cozinha");
                return;
            }
            GerenciadorPedidos.VoltarStatusConcluidos(pedidoSelecionado);
            AtualizarListas();
        }
        private void AtualizarFormChamada()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Chamada chamadaForm)
                {
                    chamadaForm.AtualizarNome();
                    break;
                }
            }
        }
        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
