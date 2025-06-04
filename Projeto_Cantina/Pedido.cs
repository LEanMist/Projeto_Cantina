using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Projeto_Cantina
{
    public class Pedido
    {
        public string NomeCliente { get; set; }
        public string FormadePagamento { get; set; }
        public DateAndTime DateAndTime { get; set; }
        public List<Produtos> Produtos { get; set; } = new List<Produtos>();
    }
}
