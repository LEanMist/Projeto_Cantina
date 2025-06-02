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
    public partial class Form1 : Form
    {
        private Carrinho carrinho = new Carrinho();
        private readonly List<Produtos> catalogo = new List<Produtos>
        {
            new Produtos("Pão de Queijo",      3.50),
            new Produtos("Coxinha",            5.00),
            new Produtos("Pastel de Carne",    6.00),
            new Produtos("Pastel de Queijo",   5.50),
            new Produtos("Suco Natural (300ml)", 4.00),
            new Produtos("Refrigerante Lata",  4.50),
            new Produtos("Hambúrguer Simples", 8.00),
            new Produtos("Hambúrguer c/ Queijo", 9.00),
            new Produtos("X-Tudo",            12.00),
            new Produtos("Água Mineral 500ml", 2.50)
        };
        public Form1()
        {
            InitializeComponent();
            CarregarProdutos();
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            Total.Text = $"Total: R$ {carrinho.Total():F2}";
        }

        private void CarregarProdutos()
        {
            ListaProdutos.Items.Clear();
            foreach (var p in catalogo)
            {
                ListaProdutos.Items.Add(p.MostrarSemQuantidade());
            }
        }

        private void CarregarCarrinho()
        {
            ListaCarrinho.Items.Clear();
            foreach (var prod in carrinho.Items)
            {
                ListaCarrinho.Items.Add(prod); // ← adiciona o objeto
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int idx = ListaProdutos.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            var baseProd = catalogo[idx];
            var produto = carrinho.AdicionarItem(baseProd);
            CarregarCarrinho();
            AtualizarTotal();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var selecionado = ListaCarrinho.SelectedItem as Produtos;
            if (selecionado == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            bool removido = carrinho.RemoverItem(selecionado);
            CarregarCarrinho();
            AtualizarTotal();
        }
    }
}
