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
    public partial class HistoricoDePedidos : Form
    {
        public HistoricoDePedidos()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void HistoricoDePedidos_Load(object sender, EventArgs e)
        {
            HistoricoPedidos.ReadOnly = true;          
            HistoricoPedidos.AllowUserToAddRows = false; 
            HistoricoPedidos.AllowUserToDeleteRows = false; 
            HistoricoPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            HistoricoPedidos.MultiSelect = false;
            CarregarHistorico();
        }
        private void CarregarHistorico()
        {
            HistoricoPedidos.DataSource = null;
            HistoricoPedidos.DataSource = GerenciadorHistorico.ListaHistorico;

            HistoricoPedidos.Columns["ProdutosDetalhes"].HeaderText = "Produtos";
            HistoricoPedidos.Columns["DataHora"].HeaderText = "Data/Hora";
            HistoricoPedidos.Columns["NomeCliente"].HeaderText = "Cliente";
            HistoricoPedidos.Columns["FormaPagamento"].HeaderText = "Pagamento";
            HistoricoPedidos.Columns["TipoPedido"].HeaderText = "Tipo";

            lblContadores.Text = $"Voltar Balcão: {GerenciadorPedidos.ContadorVoltarBalcao} | Voltar Cozinha: {GerenciadorPedidos.ContadorVoltarCozinha}";
        }

        private void btnVoltarPerfis_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
