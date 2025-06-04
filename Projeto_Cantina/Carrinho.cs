using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace Projeto_Cantina
{
    public class Carrinho
    {
        public List<Produtos> Items { get; set; } = new List<Produtos>();

        public Produtos AdicionarItem(Produtos produtobase)
        {
            string input = Interaction.InputBox(
       $"Quantas unidades de '{produtobase.Nome}' deseja adicionar?",
       "Quantidade", "1");

            if (string.IsNullOrWhiteSpace(input))
                return null;


            if (!int.TryParse(input, out int qtd) || qtd <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return null;
            }

            var existente = Items.FirstOrDefault(p => p.Nome == produtobase.Nome);
            if (existente != null)
            {
                existente.Quantidade += qtd;
                return existente;
            }

            var novo = new Produtos(produtobase.Nome, produtobase.Preco, qtd);
            Items.Add(novo);
            return novo;
        }

        public bool RemoverItem(Produtos produtoSelecionado)
        {
            while (true)
            {
                string input = Interaction.InputBox(
                    $"Quantas unidades de '{produtoSelecionado.Nome}' deseja remover?",
                    "Quantidade", "1");

                if (string.IsNullOrWhiteSpace(input))
                    return false;                       // usuário cancelou

                if (!int.TryParse(input, out int qtd) || qtd <= 0)
                {
                    MessageBox.Show("Digite um valor inválido.");
                    continue;
                }

                if (qtd > produtoSelecionado.Quantidade)
                {
                    MessageBox.Show("Quantidade maior que a disponível.");
                    continue;
                }

                // remove o item inteiro
                if (qtd == produtoSelecionado.Quantidade)
                {
                    Items.Remove(produtoSelecionado);
                    return true;
                }

                // apenas diminui
                produtoSelecionado.Quantidade -= qtd;
                return false;
            }
        }

        public double Total() => Items.Sum(item => item.CalcularValorTotal());

        public void Limpar()
        {
            Items.Clear();
        }
    }
}
