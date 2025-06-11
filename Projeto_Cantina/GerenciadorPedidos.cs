using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cantina
{
    public static class GerenciadorPedidos
    {
        public static List<Pedido> PedidosPendentes { get; private set; } = new List<Pedido>();
        public static List<Pedido> PedidosPreparacao { get; private set; } = new List<Pedido>();
        public static List<Pedido> PedidosConcluidos { get; private set; } = new List<Pedido>();
        public static List<Pedido> PedidosCozinha { get; private set; } = new List<Pedido>();
        public static List<Pedido> CozinhaConcluidos { get; private set; } = new List<Pedido>();

        public static bool PCozinha(Pedido pedido)
        {
            return pedido.Produtos.Any(p => p.Chapa);
        }
        public static void PedidoEmPreparacao(Pedido pedido)
        {
            if (PedidosPendentes.Remove(pedido))
            {
                PedidosPreparacao.Add(pedido);
                PedidosCozinha.Add(pedido);
            }
        }
        public static void VoltarStatusBalcao(Pedido pedido)
        {
            if (PedidosPreparacao.Remove(pedido))
            {
                PedidosPendentes.Add(pedido);
                PedidosCozinha.Remove(pedido);
            }
        }
        public static void ConcluirPedido(Pedido pedido)
        {
            if (PedidosPendentes.Remove(pedido))
            {
                PedidosConcluidos.Add(pedido);
            }
        }
        public static void VoltarStatusConcluidos(Pedido pedido)
        {
            if (PedidosConcluidos.Remove(pedido))
            {
                PedidosPendentes.Add(pedido);
            }
        }
        public static void ConcluirNaCozinha(Pedido pedido)
        {
            if (PedidosCozinha.Remove(pedido))
            {
                PedidosPreparacao.Remove(pedido);
                CozinhaConcluidos.Add(pedido);
                PedidosConcluidos.Add(pedido);
            }
        }
        public static void VoltarStatusCozinha(Pedido pedido)
        {
            if (CozinhaConcluidos.Remove(pedido))
            {
                PedidosPreparacao.Add(pedido);
                PedidosCozinha.Add(pedido);
                PedidosConcluidos.Remove(pedido);
            }
        }
    }
}
