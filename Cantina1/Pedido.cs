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

        public List<Produtos> Itens { get; set; } = new List<Produtos>();

        public double Total => Itens.Sum(p => p.Subtotal());

        public Pedido(string nome, List<Produtos> itens)
        {
            NomeCliente = nome;

            foreach (var p in itens)
            Itens.Add(new Produtos(p.Nome, p.Quantidade));
        }

        public override string ToString()
        {
            string resumoProdutos = string.Join(", ", Itens.Select(p => $"{p.Nome} x{p.Quantidade}\n"));
            return $"{NomeCliente} - {resumoProdutos}";
        }
    }
}
