using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cantina
{
    public static class GerenciadorPedidos
    {
        public static List<Pedido> PedidosConcluidos { get; private set; } = new List<Pedido>();

        public static void AdicionarPedido(string nomeCliente, List<Produtos> produtos)
        {
            PedidosConcluidos.Add(new Pedido
            {
                NomeCliente = nomeCliente,
                Produtos = produtos.Select(p => new Produtos(p.Nome, p.Preco, p.Quantidade)).ToList()
            });
        }
    }
}
