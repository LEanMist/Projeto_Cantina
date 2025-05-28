using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Cantina1
{
    public class Carrinho
    {
        public List<Produtos> Itens { get; set; } = new List<Produtos>();

        public Produtos AdicionarProduto(Produtos produtobase)
        {
            string input = Interaction.InputBox($"Quantas unidades de'{produtobase.Nome}' deseja adicionar?:", "Quantidade", "1");

            if (string.IsNullOrWhiteSpace(input))
                return null;

            if (!int.TryParse(input, out int Qtd) || Qtd <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return null;
            }

            var p = new Produtos(produtobase.Nome, produtobase.Preco, Qtd);
            Itens.Add(p);
            return p;
        }

        public bool RemoverProduto(Produtos produtoSelecionado)
        {
            while (true)
            {
                string input = Interaction.InputBox($"Quantas unidades de '{produtoSelecionado.Nome}' deseja remover?:", "Quantidade", "1");
                
                if (string.IsNullOrWhiteSpace(input))
                    return false;
               
                if (!int.TryParse(input, out int Qtd) || Qtd <= 0)
                {
                    MessageBox.Show("Digite um valor invalido.");
                    continue;
                }

                if (Qtd > produtoSelecionado.Quantidade)
                {
                    MessageBox.Show("Quantidade maior que a disponível.");
                    continue;
                }

                if (Qtd == produtoSelecionado.Quantidade)
                {
                    Itens.Remove(produtoSelecionado);
                    return true;
                }
               
                produtoSelecionado.Quantidade -= Qtd;
                return false; 
                
            }
        }
        public void limpar()
        {
            Itens.Clear();
        }
       
        public double Total() => Itens.Sum(item => item.Subtotal());
    }
}
