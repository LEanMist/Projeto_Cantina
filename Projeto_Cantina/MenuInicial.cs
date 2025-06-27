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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void btnIniciarPedido_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            var opcoes = new OpçoesPedido();
            if (opcoes.ShowDialog() == DialogResult.OK)
            {
                var formPrincipal = new Cantina();
                formPrincipal.TipoPedido = opcoes.TipoPedidoSelecionado;
                formPrincipal.ShowDialog();
                this.Show();
            }
            else
            {
                this.Show(); 
            }
        }

        private void btnAcessoRestrito_Click(object sender, EventArgs e)
        {
            this.Hide(); 

            using (var loginLoja = new LoginLoja())
            {
                loginLoja.ShowDialog(); 
            }

            this.Show(); 
        }

        private void btnChamada_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var loginLoja = new Chamada())
            {
                loginLoja.ShowDialog();
            }

            this.Show();
        }
    }
}
