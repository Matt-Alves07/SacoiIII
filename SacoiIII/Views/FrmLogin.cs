using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SacoiIII.Views;

namespace SacoiIII
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realemte sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            BtnCadastrar.ForeColor = Color.White;
            BtnCadastrar.Image = Properties.Resources.plus_32w;
        }

        private void BtnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            BtnCadastrar.ForeColor = Color.Black;
            BtnCadastrar.Image = Properties.Resources.plus_32b;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.ShowDialog();
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Image = Properties.Resources.login_32w;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.Black;
            BtnLogin.Image = Properties.Resources.login_32b;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Parabéns por preencher todos os campos.\nMas essa funcionalidade ainda não está implementada.", "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSenha.Checked)
            {
                TxtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
            }
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

        private Boolean ValidarCampos()
        {
            if (TxtUserName.Text == "")
            {
                MessageBox.Show("O campo nome de usuário deve estar preenchido para efetuar login", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
                return false;
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("O campo senha deve estar preenchido para efetuar login", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
