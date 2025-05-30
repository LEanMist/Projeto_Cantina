using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina1
{
    public class Pedido
    {
        public string NomeCliente { get; set; }
        public string FormaPagamento { get; set; }
        public List<Produtos> Itens { get; set; } = new List<Produtos>();

        public double Total => Itens.Sum(p => p.Subtotal());

        public Pedido(string nome, string formaPagamento, List<Produtos> itens)
        {
            NomeCliente = nome;
            FormaPagamento = formaPagamento;
            foreach (var p in itens)
            Itens.Add(new Produtos(p.Nome, p.Preco, p.Quantidade));
        }

        public override string ToString()
        {
            string resumoProdutos = string.Join(", ", Itens.Select(p => $"{p.Nome} x{p.Quantidade}"));
            return $"{NomeCliente} - {resumoProdutos} - Total: R$ {Total:F2}";
        }
    }
}
