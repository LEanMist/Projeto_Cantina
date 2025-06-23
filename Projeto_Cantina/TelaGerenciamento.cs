using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Projeto_Cantina
{
    public partial class TelaGerenciamento : Form
    {
        private BindingList<Produtos> bindingProdutos;
        private Stack<List<Produtos>> historicoUndo = new Stack<List<Produtos>>();
        private Stack<List<Produtos>> historicoRedo = new Stack<List<Produtos>>();
        private bool precisaSalvarAntesDeSair = false;
        private List<Produtos> estadoSalvo = new List<Produtos>();


        public TelaGerenciamento()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            CarregarGerenciador();
            Gerenciador.CellBeginEdit += Gerenciador_CellBeginEdit;
            Gerenciador.EditingControlShowing += Gerenciador_EditingControlShowing;
        }
        private void CarregarGerenciador()
        {
            bindingProdutos = new BindingList<Produtos>(GerenciadorProdutos.Catalogo);
            Gerenciador.DataSource = bindingProdutos;

            foreach (DataGridViewColumn col in Gerenciador.Columns)
            {
                if (col.Name == "Quantidade")
                    col.Visible = false;
            }

            estadoSalvo = ClonarEstadoAtual();
        }

        private List<Produtos> ClonarEstadoAtual()
        {
            return GerenciadorProdutos.Catalogo
                .Select(p => new Produtos(p.Nome, p.Preco, p.Quantidade, p.Chapa, p.Estoque))
                .ToList();
        }

        private void RestaurarEstado(List<Produtos> estado)
        {
            GerenciadorProdutos.Catalogo.Clear();
            foreach (var p in estado)
                GerenciadorProdutos.Catalogo.Add(p);

            bindingProdutos.ResetBindings();
        }

        private void SalvarAlteracoes()
        {
            Gerenciador.EndEdit();
            historicoUndo.Clear();
            historicoRedo.Clear();
            precisaSalvarAntesDeSair = false;

            estadoSalvo = ClonarEstadoAtual();

            MessageBox.Show("Alterações salvas com sucesso!", "Sucesso");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarAlteracoes();
        }
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Nome do produto:", "Novo Produto");
            if (string.IsNullOrWhiteSpace(nome)) return;

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

            historicoUndo.Push(ClonarEstadoAtual());
            historicoRedo.Clear();
            precisaSalvarAntesDeSair = true;

            var novoProduto = new Produtos(nome, preco, 0, chapa, estoque);
            GerenciadorProdutos.Catalogo.Add(novoProduto);
            bindingProdutos.ResetBindings();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (historicoUndo.Count > 0)
            {
                historicoRedo.Push(ClonarEstadoAtual());
                var estadoAnterior = historicoUndo.Pop();
                RestaurarEstado(estadoAnterior);
                precisaSalvarAntesDeSair = true;
            }
            else
            {
                MessageBox.Show("Nenhuma alteração para desfazer.");
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (historicoRedo.Count > 0)
            {
                historicoUndo.Push(ClonarEstadoAtual());
                var estadoPosterior = historicoRedo.Pop();
                RestaurarEstado(estadoPosterior);
                precisaSalvarAntesDeSair = true;
            }
            else
            {
                MessageBox.Show("Nenhuma alteração para refazer.");
            }
        }
        private void btnVoltarPerfis_Click(object sender, EventArgs e)
        {
            if (precisaSalvarAntesDeSair)
            {
                var resposta = MessageBox.Show(
                    "Existem alterações não salvas. Tem certeza que deseja voltar para os Perfis sem salvar?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resposta == DialogResult.No)
                    return;

                RestaurarEstado(estadoSalvo);
                precisaSalvarAntesDeSair = false;
            }

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void Gerenciador_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            historicoUndo.Push(ClonarEstadoAtual());
            historicoRedo.Clear();
            precisaSalvarAntesDeSair = true;
        }

        private void Gerenciador_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int colunaEstoque = Gerenciador.Columns["Estoque"].Index;
            int colunaPreco = Gerenciador.Columns["Preco"].Index;

            TextBox tb = e.Control as TextBox;
            tb.KeyPress -= ApenasNumeros_KeyPress;
            tb.KeyPress -= ApenasNumerosEDecimal_KeyPress;

            if (Gerenciador.CurrentCell.ColumnIndex == colunaEstoque)
            {
                tb.KeyPress += ApenasNumeros_KeyPress;
            }
            else if (Gerenciador.CurrentCell.ColumnIndex == colunaPreco)
            {
                tb.KeyPress += ApenasNumerosEDecimal_KeyPress;
            }
        }

        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ApenasNumerosEDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            bool jaTemVirgula = tb.Text.Contains(',') || tb.Text.Contains('.');

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
 
                if ((e.KeyChar == ',' || e.KeyChar == '.') && !jaTemVirgula)
                {

                }
                else
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void TelaGerenciamento_Click(object sender, EventArgs e)
        {
            Gerenciador.ClearSelection();
            this.ActiveControl = null;
        }
    }
}

        