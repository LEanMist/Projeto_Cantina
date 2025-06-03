using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cantina
{
    public partial class OpçoesPedido : Form
    {
        public string TipoPedidoSelecionado { get; set; } = "";
        public OpçoesPedido()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            TipoPedidoSelecionado = "Para Viagem";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnAgora_Click(object sender, EventArgs e)
        {
            TipoPedidoSelecionado = "Para Agora";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
