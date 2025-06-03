using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cantina
{
    public class Pedido
    {
        public string NomeCliente { get; set; }
        public List<Produtos> Produtos { get; set; } = new List<Produtos>();
    }
}
