using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacoiIII.Views
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            BtnDisp.ForeColor = Color.White;
            BtnDisp.Image = Properties.Resources.search_16w;
        }

        private void BtnDisp_MouseLeave(object sender, EventArgs e)
        {
            BtnDisp.ForeColor = Color.Black;
            BtnDisp.Image = Properties.Resources.search_16b;
        }

        private void BtnCadastro_MouseEnter(object sender, EventArgs e)
        {
            BtnCadastro.ForeColor = Color.White;
            BtnCadastro.Image = Properties.Resources.success_32w;
        }

        private void BtnCadastro_MouseLeave(object sender, EventArgs e)
        {
            BtnCadastro.ForeColor = Color.Black;
            BtnCadastro.Image = Properties.Resources.success_32b;
        }

        private void BtnLimpar_MouseEnter(object sender, EventArgs e)
        {
            BtnLimpar.ForeColor = Color.White;
            BtnLimpar.Image = Properties.Resources.backspace_32w;
        }

        private void BtnLimpar_MouseLeave(object sender, EventArgs e)
        {
            BtnLimpar.ForeColor = Color.Black;
            BtnLimpar.Image = Properties.Resources.backspace_32b;
        }

        private void ChkSenha_MouseEnter(object sender, EventArgs e)
        {
            ChkSenha.ForeColor = Color.White;
            ChkSenha.Image = Properties.Resources.pin_code_24w;
        }

        private void ChkSenha_MouseLeave(object sender, EventArgs e)
        {
            ChkSenha.ForeColor = Color.Black;
            ChkSenha.Image = Properties.Resources.pin_code_24b;
        }

        private void ChkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSenha.Checked)
            {
                TxtSenha.UseSystemPasswordChar = false;
                TxtRSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
                TxtRSenha.UseSystemPasswordChar = true;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtPNome.Text = "";
            TxtSNome.Text = "";
            TxtUserName.Text = "";
            TxtEmail.Text = "";
            TxtCargo.Text = "";
            TxtSenha.Text = "";
            TxtRSenha.Text = "";
            TxtPNome.Focus();
        }

        private Boolean ValidarCampos()
        {
            if(TxtPNome.Text == "")
            {
                MessageBox.Show("O campo primeiro nome tem preenchimento obrigatório", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPNome.Focus();
                return false;
            }
            else if (TxtSNome.Text == "")
            {
                MessageBox.Show("O campo sobrenome tem preenchimento obrigatório", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSNome.Focus();
                return false;
            }
            else if (TxtUserName.Text == "")
            {
                MessageBox.Show("O campo nome de usuário tem preenchimento obrigatório", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
                return false;
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("O campo email tem preenchimento obrigatório", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEmail.Focus();
                return false;
            }
            else if (TxtCargo.Text == "")
            {
                MessageBox.Show("O campo cargo tem preenchimento obrigatório", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCargo.Focus();
                return false;
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("O campo senha tem preenchimento obrigatório", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Focus();
                return false;
            }
            else if (TxtRSenha.Text == "")
            {
                MessageBox.Show("O campo de repetição de senha tem preenchimento obrigatório", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtRSenha.Focus();
                return false;
            }
            else if (TxtSenha.Text != TxtRSenha.Text)
            {
                MessageBox.Show("As senhas devem ser iguais", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Parabéns por preencher todos os campos.\nMas essa funcionalidade ainda não está implementada.", "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
