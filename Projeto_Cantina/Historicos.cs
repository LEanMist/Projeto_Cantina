using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cantina
{
    public class Historicos
    {
        public string NomeCliente { get; set; }
        public string TipoPedido { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime DataHora { get; set; }
        public string ProdutosDetalhes { get; set; }
    }
    public static class GerenciadorHistorico
    {
        public static List<Historicos> ListaHistorico { get; private set; } = new List<Historicos>();

        public static void AdicionarAoHistorico(Pedido pedido)
        {
            var detalhesProdutos = string.Join(", ", pedido.Produtos.Select(p => $"{p.Nome} x{p.Quantidade}"));

            ListaHistorico.Add(new Historicos
            {
                NomeCliente = pedido.NomeCliente,
                TipoPedido = pedido.TipoPedido,
                FormaPagamento = pedido.FormadePagamento,
                DataHora = pedido.DataeHora,
                ProdutosDetalhes = detalhesProdutos
            });
        }
    }
}
