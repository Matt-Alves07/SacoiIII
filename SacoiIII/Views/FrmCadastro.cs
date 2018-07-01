using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SacoiIII.Controller;
using SacoiIII.Misc;

namespace SacoiIII.Views
{
    public partial class FrmCadastro : Form
    {
        #region Instances
        //Instância do objeto Controller que será usado para intermediar a camada view para a camada model
        UsuarioController UsuarioController = new UsuarioController();
        Error Error = new Error();
        #endregion

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
                Error.SendError("O campo primeiro nome tem preenchimento obrigatório", "Campo vazio");
                TxtPNome.Focus();
                return false;
            }
            else if (TxtSNome.Text == "")
            {
                Error.SendError("O campo sobrenome tem preenchimento obrigatório", "Campo vazio");
                TxtSNome.Focus();
                return false;
            }
            else if (TxtUserName.Text == "")
            {
                Error.SendError("O campo nome de usuário tem preenchimento obrigatório", "Campo vazio");
                TxtUserName.Focus();
                return false;
            }
            else if (TxtEmail.Text == "")
            {
                Error.SendError("O campo email tem preenchimento obrigatório", "Campo vazio");
                TxtEmail.Focus();
                return false;
            }
            else if (TxtCargo.Text == "")
            {
                Error.SendError("O campo cargo tem preenchimento obrigatório", "Campo vazio");
                TxtCargo.Focus();
                return false;
            }
            else if (TxtSenha.Text == "")
            {
                Error.SendError("O campo senha tem preenchimento obrigatório", "Campo vazio");
                TxtSenha.Focus();
                return false;
            }
            else if (TxtRSenha.Text == "")
            {
                Error.SendError("O campo de repetição de senha tem preenchimento obrigatório", "Campo vazio");
                TxtRSenha.Focus();
                return false;
            }
            else if (TxtSenha.Text != TxtRSenha.Text)
            {
                Error.SendError("As senhas devem ser iguais", "Senhas diferentes");
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
            string status = "";
            if (ValidarCampos())
            {
                status = UsuarioController.InsertPessoa(TxtUserName.Text, TxtPNome.Text, TxtSNome.Text, TxtEmail.Text, TxtSenha.Text, TxtCargo.Text);
                if (status == "sucesso")
                {
                    Error.SendOK("Cadastro efetuado com sucesso.\nClique em OK para voltar a tela de login.", "Bem vindo");
                    Close();
                }
                else if (status == "falha")
                {
                    MessageBox.Show("Ocorreu um erro ao efetuar ser cadastro.\nCaso persista, contate o suporte.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(status, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDisp_Click(object sender, EventArgs e)
        {
            #region Local Atributtes
            string resultado = "";
            #endregion

            if (TxtUserName.Text != "")
            {
                resultado = UsuarioController.VerificarNome(TxtUserName.Text);
                if (resultado == "livre")
                {
                    MessageBox.Show("Este nome está disponível para uso.", "Disponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == "usado")
                {
                    MessageBox.Show("Este nome de usuário está sendo usado no momento.\nInsira outro e tente novamente.", "Não disponível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("O campo nome de usuário deve estar preenchido para executar essa funcionalidade.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }
    }
}
