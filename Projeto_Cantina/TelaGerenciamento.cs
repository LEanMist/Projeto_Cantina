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
    public partial class TelaGerenciamento : Form
    {
        private BindingList<Produtos> bindingProdutos;
        private List<Produtos> copiaTempProdutos;

        public TelaGerenciamento()
        {
            InitializeComponent();
            CarregarGerenciador();
            Gerenciador.CellValidating += Gerenciador_CellValidating;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void CarregarGerenciador()
        {
            copiaTempProdutos = GerenciadorProdutos.Catalogo.Select(p => new Produtos(p.Nome, p.Preco, p.Quantidade, p.Chapa, p.Estoque)).ToList();
            bindingProdutos = new BindingList<Produtos>(copiaTempProdutos);
            Gerenciador.DataSource = bindingProdutos;

            foreach (DataGridViewColumn col in Gerenciador.Columns)
            {
                if (col.Name == "Quantidade")
                {
                    col.Visible = false;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Gerenciador.EndEdit(); // Termina a edição atual no grid

            GerenciadorProdutos.Catalogo.Clear();
            GerenciadorProdutos.Catalogo.AddRange(copiaTempProdutos.Select(p =>
                new Produtos(p.Nome, p.Preco, p.Quantidade, p.Chapa, p.Estoque)
            ));
            MessageBox.Show("Alterações salvas no catálogo!", "Sucesso");
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Nome do produto:", "Novo Produto");
            if (string.IsNullOrWhiteSpace(nome))
            { return; }

            string precoStr = Microsoft.VisualBasic.Interaction.InputBox("Preço do produto:", "Novo Produto", "0");
            if (!double.TryParse(precoStr, out double preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            string estoqueStr = Microsoft.VisualBasic.Interaction.InputBox("Estoque inicial:", "Novo Produto", "0");
            if (!int.TryParse(estoqueStr, out int estoque) || estoque < 0)
            {
                MessageBox.Show("Estoque inválido.");
                return;
            }

            string chapaStr = Microsoft.VisualBasic.Interaction.InputBox("É chapa? (sim/não):", "Novo Produto", "não");
            bool chapa = chapaStr.Trim().ToLower() == "sim";

            var novoProduto = new Produtos(nome, preco, quantidade: 0, chapa: chapa, estoque: estoque);

            GerenciadorProdutos.Catalogo.Add(novoProduto);
            bindingProdutos.ResetBindings();
            CarregarGerenciador();           
        }

        private void TelaGerenciamento_Click(object sender, EventArgs e)
        {
            Gerenciador.ClearSelection();
            this.ActiveControl = null;
        }

        private void Gerenciador_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (Gerenciador.Columns[e.ColumnIndex].Name == "Estoque")
            {
                string valor = e.FormattedValue.ToString();

                if (!int.TryParse(valor, out int estoque) || estoque < 0)
                {
                    MessageBox.Show("Digite apenas números inteiros positivos para o estoque.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
        private void btnVoltarAlterações_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que deseja descartar todas as alterações feitas e voltar para o estado original?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                CarregarGerenciador();
                MessageBox.Show("Todas as alterações foram descartadas. Dados recarregados.", "Recarregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnVoltarPerfis_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }   
}
