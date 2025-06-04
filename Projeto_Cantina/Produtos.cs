using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Projeto_Cantina
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

        public double CalcularValorTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return $"{Nome} - R$ {Preco:F2} x {Quantidade}";
        }
        public string MostrarSemQuantidade()
        {
            return $"{Nome} - R$ {Preco:F2}";
        }
    }
}
