using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina1
{
    public class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Produtos(string nome, double preco, int quantidade = 1)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double Subtotal() => Preco * Quantidade;
        
        public override string ToString()
        {
            if (Quantidade > 1)
            {
                return $"{Nome} - R$ {Preco:F2} x {Quantidade}";
            }
            else
            {
                return $"{Nome} - R$ {Preco:F2}";
            }
        }
    }
}
