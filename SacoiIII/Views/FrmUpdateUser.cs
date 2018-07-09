using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SacoiIII.Misc;
using SacoiIII.Controller;

namespace SacoiIII.Views
{
    public partial class FrmUpdateUser : Form
    {
        #region Local Atributtes
        //Criação de atributos locais
        string UserName = "";
        string IDUsuario = "";
        string Admin = "";
        #endregion

        #region Error
        //Instância da classe Error para exibir as mensagens(textbox) para o usuário
        Error Error = new Error();
        #endregion

        #region Controller
        //Instância da classe Controller de Usuário, usado para carregar os dados do registros do usuário que está logado no sistema
        //e também para salvar as alterações após clicar no botão salvar e validar os campos
        UsuarioController Controller = new UsuarioController();
        #endregion

        public FrmUpdateUser(string _user_name)
        {
            InitializeComponent();
            UserName = _user_name;
            PreencherCampos(UserName);
        }

        #region Sair
        private void BtnSair_Click(object sender, EventArgs e)
        {
            string admin = "";
            admin = Controller.GetPessoa(UserName).admin;
            if (admin == "Sim")
            {
                FrmHomeA Form = new FrmHomeA(UserName);
                Form.Show();
                this.Close();
            }
            else if (admin == "Não")
            {
                FrmHomeU Form = new FrmHomeU(UserName);
                Form.Show();
                this.Close();
            }
        }
        #endregion

        #region Alteração do checkbox de exibir senha
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
        #endregion

        #region Limpar Campos
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtPNome.Text = "";
            TxtSNome.Text = "";
            TxtEmail.Text = "";
            TxtCargo.Text = "";
            TxtSenha.Text = "";
            TxtRSenha.Text = "";
            TxtPNome.Focus();
        }
        #endregion

        #region Hover
        //Efeito hover nos botões
        private void BtnSalvar_MouseEnter(object sender, EventArgs e)
        {
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Image = Properties.Resources.success_32w;
        }

        private void BtnSalvar_MouseLeave(object sender, EventArgs e)
        {
            BtnSalvar.ForeColor = Color.Black;
            BtnSalvar.Image = Properties.Resources.success_32b;
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
        #endregion

        #region Preencher Campos
        private void PreencherCampos(string _user_name)
        {
            var Usuario = Controller.GetPessoa(UserName);
            TxtPNome.Focus();
            TxtPNome.Text = Usuario.p_nome;
            TxtSNome.Text = Usuario.s_nome;
            TxtCargo.Text = Usuario.cargo;
            TxtEmail.Text = Usuario.email;
            TxtSenha.Text = Usuario.senha;
            TxtRSenha.Text = Usuario.senha;
            IDUsuario = Usuario.pessoa;
            Admin = Usuario.admin;
        }
        #endregion

        #region Validar Campos
        private Boolean ValidarCampos()
        {
            if (TxtPNome.Text == "")
            {
                Error.SendAttention("O campo primeiro nome não pode ficar vazio.", "Campo vazio");
                return false;
            }
            else if (TxtPNome.TextLength > 30)
            {
                Error.SendAttention("O campo primeiro nome não pode ter mais que 30 caracteres.", "Tamanho excedido");
                return false;
            }
            else if (TxtSNome.Text == "")
            {
                Error.SendAttention("O campo sobrenome não pode ficar vazio.", "Campo vazio");
                return false;
            }
            else if (TxtSNome.TextLength > 100)
            {
                Error.SendAttention("O campo sobrenome não pode ter mais de 100 caracteres.", "Tamanho excedido");
                return false;
            }
            else if (TxtEmail.Text == "")
            {
                Error.SendAttention("O campo email não pode ficar vazio.", "Campo vazio");
                return false;
            }
            else if (TxtEmail.TextLength > 100)
            {
                Error.SendAttention("O campo email não pode ter mais de 100 caracteres.", "Tamanho excedido");
                return false;
            }
            else if (TxtCargo.Text == "")
            {
                Error.SendAttention("O campo cargo não pode ficar vazio.", "Campo vazio");
                return false;
            }
            else if (TxtCargo.TextLength > 25)
            {
                Error.SendAttention("O campo cargo não pode ter mais de 25 caracteres.", "Tamanho excedido");
                return false;
            }
            else if (TxtSenha.Text == "")
            {
                Error.SendAttention("O campo senha não pode ficar vazio.", "Campo vazio");
                return false;
            }
            else if (TxtSenha.TextLength > 20)
            {
                Error.SendAttention("O campo senha não pode ter mais de 20 caracteres.", "Tamano excedido");
                return false;
            }
            else if (TxtRSenha.Text == "")
            {
                Error.SendAttention("O campo que repete a senha não pode ficar vazio.", "Campo vazio");
                return false;
            }
            else if (TxtRSenha.TextLength > 20)
            {
                Error.SendAttention("O campo que repete a senha não pode ter mais de 20 caracteres.", "Tamanho excedido");
                return false;
            }
            else if (TxtSenha.Text != TxtRSenha.Text)
            {
                Error.SendAttention("As senhas devem ser iguais.", "Senhas diferentes");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Valida o preenchimento dos campos de preenchimento por parte do usuário
            if (ValidarCampos())
            {
                //Cria uma variavel do tipo string para armazenar o resultado do metodo do Controller que altera o cadastro do Usuário
                string Result = "";
                
                //Se estiver valido, chama o metodo do Controller para processar as alterações
                Result = Controller.UpdateUser(IDUsuario, TxtPNome.Text, TxtSNome.Text, TxtEmail.Text, TxtCargo.Text, TxtSenha.Text);

                //Valida o resultado recebido do Controller
                if (Result == "sucesso")
                {
                    Error.SendOK("Alteração realizada com sucesso.\nClique em OK para voltar a tela Home", "Alterado com sucesso");
                    string admin = "";
                    admin = Controller.GetPessoa(UserName).admin;
                    if (admin == "Sim")
                    {
                        FrmHomeA Form = new FrmHomeA(UserName);
                        Form.Show();
                        this.Close();
                    }
                    else if (admin == "Não")
                    {
                        FrmHomeU Form = new FrmHomeU(UserName);
                        Form.Show();
                        this.Close();
                    }
                }
                else if (Result == "")
                {
                    Error.SendAttention("Ocorreu um erro ao atualizar seu cadastro.\nCaso persista, contate o suporte", "Falha ao atualizar");
                }
            }
        }

        #region Pass button hover effect
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
        #endregion
    }
}