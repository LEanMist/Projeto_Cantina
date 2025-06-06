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
            this.Hide(); // Esconde o menu inicial
            var opcoes = new OpçoesPedido();
            if (opcoes.ShowDialog() == DialogResult.OK)
            {
                var formPrincipal = new Form1();
                formPrincipal.TipoPedido = opcoes.TipoPedidoSelecionado;
                formPrincipal.ShowDialog();
                this.Show();
            }
            else
            {
                this.Show(); // Fecha o menu inicial se o usuário cancelar
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
    }
}
