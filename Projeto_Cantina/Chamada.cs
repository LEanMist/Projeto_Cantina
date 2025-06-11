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
    public partial class Chamada : Form
    {
        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            AtualizarNome();
        }
        private void AtualizarNome()
        {
            ListaNomes.Items.Clear();
            foreach (var pedido in GerenciadorPedidos.PedidosPreparacao)
            {
                ListaNomes.Items.Add($"{NomesClientes(pedido)}");
            }

            txtChamada.Text.Clone();
            foreach (var pedido in GerenciadorPedidos.PedidosConcluidos)
            {
                txtChamada.Text = pedido.NomeCliente;
            }
        }
        private string NomesClientes(Pedido pedido)
        {
            return string.Join(", ", $"{pedido.NomeCliente}");
        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
