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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            AtualizarNome();
        }
        public void AtualizarNome()
        {
            ListaNomes.Items.Clear();

            foreach (var pedido in GerenciadorPedidos.PedidosPreparacao)
            {
                ListaNomes.Items.Add($"{pedido.NomeCliente}");
            }

            if (GerenciadorPedidos.PedidosConcluidos.Any())
            {
                txtChamada.Text = GerenciadorPedidos.PedidosConcluidos.First().NomeCliente;
            }
            else
            {
                txtChamada.Clear();
            }
        }
        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
