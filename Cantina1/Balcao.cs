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
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            ListaPedidos.Items.Clear();
            foreach (var pedido in BancoPedidos.Pedidos)
            {
                ListaPedidos.Items.Add(pedido);
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            var Pedido = ListaPedidos.SelectedItem;

            if (Pedido != null)
            {
                ListaPedidos.Items.Remove(Pedido);
                ListaConcluidos.Items.Add(Pedido);
            }
            else if (ListaPedidos.Items == null)
            {
                MessageBox.Show("Não a nenhum Pedido no Momento");
            }
            else
            {
                MessageBox.Show("Selecione o Item para concluir");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var concluidos = ListaConcluidos.SelectedItem;

            if (concluidos != null)
            {
                ListaConcluidos.Items.Remove(concluidos);
                ListaPedidos.Items.Add($"{concluidos.ToString()}");
            }
            else if (ListaConcluidos.Items == null)
            {
                MessageBox.Show("Deve haver um pedido para poder voltar seu status");
            }
            else
            {
                MessageBox.Show("Selecione o Item para voltar seu status");
            }
        }
    }
}
