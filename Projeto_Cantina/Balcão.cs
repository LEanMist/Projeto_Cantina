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
        private List<Pedido> pedidosPendentes = new List<Pedido>();
        private List<Pedido> pedidosConcluidos = new List<Pedido>();
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
                ListaPedidos.Items.Add($"Cliente: {pedido.NomeCliente}  - {ResumoProdutos(pedido)} -- Tipo Pedido: {pedido.TipoPedido}");
            }

            ListaConcluidos.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.PedidosConcluidos)
            {
                ListaConcluidos.Items.Add($"Cliente: {pedido.NomeCliente} - {ResumoProdutos(pedido)} -- Tipo Pedido: {pedido.TipoPedido}");
            }
        }

        private string ResumoProdutos(Pedido pedido)
        {
            return string.Join(", ", pedido.Produtos.Select(p => $"{p.Nome} x{p.Quantidade}"));
        }


        private void btnConcluir_Click(object sender, EventArgs e)
        {
            int index = ListaPedidos.SelectedIndex;
            if (index < 0) return;

            var pedido = GerenciadorPedidos.PedidosPendentes[index];
            GerenciadorPedidos.ConcluirPedido(pedido);

            AtualizarListas();
        }

        private void btnVoltarStatus_Click(object sender, EventArgs e)
        {
            int index = ListaConcluidos.SelectedIndex;
            if (index < 0) return;

            var pedido = GerenciadorPedidos.PedidosConcluidos[index];
            GerenciadorPedidos.VoltarStatus(pedido);

            AtualizarListas();
        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
