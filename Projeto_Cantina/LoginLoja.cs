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
    public partial class LoginLoja : Form
    {
        public LoginLoja()
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

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text.Equals("admin") && txtSenha.Text.Equals("123"))
                {
                    var perfis = new Perfis();
                    perfis.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Login ou Senha Incorretos", "ERRO", MessageBoxButtons.OK);

                    txtLogin.Focus();
                    txtSenha.Text = "";
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Login ou Senha Incorretos", ex.Message, MessageBoxButtons.OK);
            }
        }
    }
}
