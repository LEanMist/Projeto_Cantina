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
    public partial class Perfis : Form
    {
        public Perfis()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAtendente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginsAcessos = new LoginsAcessos();
            loginsAcessos.PerfilSelecionado = "Atendente";
            if (loginsAcessos.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                this.Close();
            }
            else
            {
                this.Show(); 
            }
        }

        private void btnCozinheiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginsAcessos = new LoginsAcessos();
            loginsAcessos.PerfilSelecionado = "Cozinheiro";
            if (loginsAcessos.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
        private void btnDONOeGERENTE_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var loginsAcessos = new LoginsAcessos();
            loginsAcessos.PerfilSelecionado = "Dono";
            if (loginsAcessos.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnChamada_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginsAcessos = new LoginsAcessos();
            loginsAcessos.PerfilSelecionado = "Chamada";
            if (loginsAcessos.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
