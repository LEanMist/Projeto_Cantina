using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cantina
{
    public partial class ControleChamada : Form
    {
        public ControleChamada()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void ControleChamada_Load(object sender, EventArgs e)
        {
            AtualizarListas();
        }
        private void AtualizarListas()
        {
            ListaConcluidos.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.PedidosConcluidos)
            {
                ListaConcluidos.Items.Add(pedido.NomeCliente);
            }

            ListaClientesConcluidos.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.ClientesConcluidos)
            {
                ListaClientesConcluidos.Items.Add(pedido.NomeCliente);
            }

            ListaClientesPendentes.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.ClientesPendentes)
            {
                ListaClientesPendentes.Items.Add(pedido.NomeCliente);
            }
        }

        private void btnPedidoConcluido_Click(object sender, EventArgs e)
        {
            int indice = ListaConcluidos.SelectedIndex;
            if (indice >= 0 && indice < GerenciadorPedidos.PedidosConcluidos.Count)
            {
                Pedido pedido = GerenciadorPedidos.PedidosConcluidos[indice];
                GerenciadorPedidos.PedidosConcluidos.Remove(pedido);
                GerenciadorPedidos.ClientesConcluidos.Add(pedido);
                GerenciadorPedidos.RemoverDaLista(pedido);
                AtualizarListas();
                AtualizarChamada();
            }
        }
        private void btnPedidoPendente_Click(object sender, EventArgs e)
        {
            int indice = ListaConcluidos.SelectedIndex;
            if (indice >= 0 && indice < GerenciadorPedidos.PedidosConcluidos.Count)
            {
                Pedido pedido = GerenciadorPedidos.PedidosConcluidos[indice];
                GerenciadorPedidos.PedidosConcluidos.Remove(pedido);
                GerenciadorPedidos.ClientesPendentes.Add(pedido);
                GerenciadorPedidos.RemoverDaLista(pedido);
                AtualizarListas();
                AtualizarChamada();
            }
        }
        public void AtualizarChamada()
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
