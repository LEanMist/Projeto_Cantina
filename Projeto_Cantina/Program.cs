using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cantina
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var opcoes = new OpçoesPedido();
            if (opcoes.ShowDialog() == DialogResult.OK)
            {
                var formPrincipal = new Form1();
                formPrincipal.TipoPedido = opcoes.TipoPedidoSelecionado;
                Application.Run(formPrincipal);
            }
        }
    }
}
