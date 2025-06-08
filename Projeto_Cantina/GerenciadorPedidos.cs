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
        public static List<Pedido> PedidosPendentes { get; private set; } = new List<Pedido>();

        public static void ConcluirPedido(Pedido pedido)
        {
            PedidosConcluidos.Add(pedido);
            PedidosPendentes.Remove(pedido);
        }

        public static void VoltarStatus(Pedido pedido)
        {
            PedidosConcluidos.Remove(pedido);
            PedidosPendentes.Add(pedido);
        }
    }
}
