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
using SacoiIII.Controller;

namespace SacoiIII
{
    public partial class FrmLogin : Form
    {
        UsuarioController UsuarioController = new UsuarioController();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            frmCadastro.Show();
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
            #region Local Attributes
            //Criação do array que recebe o resultado do metodo EfetuarLogin do ControllerUsuario e do inteiro que será necessário para o loop
            string[] result = { "", "" };
            short i = 0;
            #endregion

            if (ValidarCampos())
            {
                #region Array loop
                //Preenche o arrya dentro do loop com os resultados vindos do metodo EfetuarLogin do ControllerUsuario
                foreach (string linha in UsuarioController.EfetuarLogin(TxtUserName.Text, TxtSenha.Text))
                {
                    result[i] = linha;
                    i++;
                }
                #endregion

                #region Result
                //Verifica a primeira posição é igual a "true"(existe o usuário e senha) ou se é igua a "false"(não existe), o que passar disso é exceção do MySQL
                if (result[0] == "false")
                {
                    //Exibe a mensagem informando que não foi encontrado o registro dele
                    MessageBox.Show("Usuário e/ou senha incorretos.\nRevise os campos e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result[0] == "true")
                {
                    //Existindo registro, Exibe mensagem informando que foi encontrado; a segunda posição sendo igual a "true", redireciona para a tela de Administradores
                    if (result[1] == "true")
                    {
                        MessageBox.Show("Login efetuado com sucesso!\nClique em OK para continuar para a tela inicial.", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        FrmHomeA homeA = new FrmHomeA(TxtUserName.Text);
                        homeA.Show();
                        Hide();
                    }
                    //Existindo registro, Exibe mensagem informando que foi encontrado; a segunda posição sendo igual a "false", redireciona para a tela de Usuários
                    else if (result[1] == "false")
                    {
                        MessageBox.Show("Login efetuado com sucesso!\nClique em OK para continuar para a tela inicial.", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        FrmHomeU homeU = new FrmHomeU(TxtUserName.Text);
                        homeU.Show();
                        Hide();
                    }
                    //Não existindo registro na segunda posição do array, informa que houve um erro e não redireciona para nenhuma tela
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao carregar as informações do servidor.\nTente novamente e, se persistir, contate o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                #endregion
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

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
