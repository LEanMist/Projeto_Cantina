using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Cantina1
{
    public partial class Form1 : Form
    {
        private Carrinho carrinho = new Carrinho();
        private List<Produtos> catalogo = new List<Produtos>()
        {
            new Produtos("Pão de Queijo", 3.50),
            new Produtos("Coxinha", 5.00),
            new Produtos("Pastel de Carne", 6.00),
            new Produtos("Pastel de Queijo", 5.50),
            new Produtos("Suco Natural (300ml)", 4.00),
            new Produtos("Refrigerante Lata", 4.50),
            new Produtos("Hambúrguer Simples", 8.00),
            new Produtos("Hambúrguer com Queijo", 9.00),
            new Produtos("X-Tudo", 12.00),
            new Produtos("Água Mineral (500ml)", 2.50)
        };
        public Form1()
        {
            InitializeComponent();

            foreach (var p in catalogo)
            {
                ListaProdutos.Items.Add(p);
            }

            AtualizarTotal();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            var baseProd = ListaProdutos.SelectedItem as Produtos;
            if (baseProd == null)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            var pedido = carrinho.AdicionarProduto(baseProd);
            if (pedido != null)
            {
                ListaCarrinho.Items.Add(pedido);
                AtualizarTotal();
            }
        }


        private void Remover_Click(object sender, EventArgs e)
        {
            Produtos selecionado = ListaCarrinho.SelectedItem as Produtos;

            if (selecionado == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            bool removido = carrinho.RemoverProduto(selecionado);

            if (removido)
            {
                ListaCarrinho.Items.Remove(selecionado);
            }
            else
            {
                int i = ListaCarrinho.SelectedIndex;
                ListaCarrinho.Items[i] = selecionado;
            }

            AtualizarTotal();
        }
        private void AtualizarTotal()
        {
            Total.Text = $"Total: R${carrinho.Total():F2}";
        }
    }  
}
     
