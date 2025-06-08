using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Projeto_Cantina
{
    public partial class LoginsAcessos : Form
    {
        public string PerfilSelecionado { get; set; }
        public LoginsAcessos()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string usuario = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (PerfilSelecionado == "Atendente")
            {
                if (usuario == "atendente" && senha == "123")
                {
                    this.Hide();
                    var balcao = new Balcão(); 
                    balcao.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos para o perfil de Atendente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (PerfilSelecionado == "Cozinheiro")
            {
                if (usuario == "cozinheiro" && senha == "123")
                {
                    this.Hide();
                    var telaCozinheiro = new Cozinha(); // seu form para cozinha
                    telaCozinheiro.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos para o perfil de Cozinheiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (PerfilSelecionado == "Dono")
            {
                if (usuario == "dono" && senha == "123")
                {
                    this.Hide();
                    var telaGerenciamento = new TelaGerenciamento();
                    telaGerenciamento.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos para o perfil de Dono/Gerente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoltarPerfis_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
