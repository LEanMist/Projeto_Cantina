using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cantina
{
    public static class GerenciadorProdutos
    {
        public static List<Produtos> Catalogo { get; set; } = new List<Produtos>
        {
            new Produtos("Pão de Queijo", 3.50,0,true,20),
            new Produtos("Coxinha", 5.00,0,true,20),
            new Produtos("Pastel de Carne", 6.00, 0, true, 20),
            new Produtos("Pastel de Queijo", 5.50, 0, true, 20),
            new Produtos("Suco Natural (300ml)", 4.00, 0, false, 20),
            new Produtos("Refrigerante Lata", 4.50, 0, false, 20),
            new Produtos("Hambúrguer Simples", 8.00, 0, true, 20),
            new Produtos("Hambúrguer c/ Queijo", 9.00, 0, true, 20),
            new Produtos("X-Tudo", 12.00, 0, true, 20),
            new Produtos("Água Mineral 500ml", 2.50, 0, false, 20)
        };
    }
}
