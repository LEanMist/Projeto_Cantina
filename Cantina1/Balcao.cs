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
    }
}
