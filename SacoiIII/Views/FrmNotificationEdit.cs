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
    public partial class FrmNotificationEdit : Form
    {
        #region Local Atributtes
        //Criação das variavéis que recebem o texto da notificação, o UUID do criador e o nome de usuário que efetuou login
        string Text = "";
        string User = "";
        string Notification = "";
        #endregion

        #region Error
        Error Error = new Error();
        #endregion

        #region Controller
        NotificacoesController Controller = new NotificacoesController();
        #endregion

        public FrmNotificationEdit(string _text, string _user_loged, string _notification)
        {
            InitializeComponent();
            Text = _text;
            User = _user_loged;
            Notification = _notification;
            TxtNotification.Text = Text;
            TxtNotification.Focus();
        }

        #region Hover
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

        #region Validar Notificação
        private Boolean ValidarCampo(string valor)
        {
            if (valor.Length >= 250)
            {
                Error.SendAttention("A notificação não pode ter mais que 250 caracteres", "Tamanho excedido");
                return false;
            }
            else if (valor == "")
            {
                Error.SendAttention("Não é permitido salvar uma notificação vazia", "Notificação vazia");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNotification.Text = "";
            TxtNotification.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Criação da variável que irá receber o resultado da chamada do metodo de alterar notificações
            string result = "";

            //Valida se o usuário realmente deseja fazer isso e diz que não haverá volta
            if (Error.SendQuestion("Essa ação não pode ser revertida.\nDeseja realmente alterar essa notificação?", "Confirmar alteração") == DialogResult.Yes)
            {
                //Verifica o preenchimento do texto da notificação que será armazenado
                if (ValidarCampo(TxtNotification.Text))
                {
                    //Atribui o resultado do metodo alterar notificações
                    result = Controller.AlterarNotificacao(User, Notification, TxtNotification.Text);

                    //Valida o resultado de acordo com o retorno
                    if (result == "sucesso")
                    {
                        //Informa que a notificação foi alterada com sucesso
                        Error.SendOK("Notificação alterada com sucesso.", "Sucesso");
                        //Verifica se o Form que mostra detalhes da notificação está aberto
                        if (Application.OpenForms.OfType<FrmInfoNotification>().Count() > 0)
                        {
                            //Fecha o Form que mostra os detalhes da notificação
                            Application.OpenForms["FrmInfoNotification"].Close();
                            //Traz o Form que lista todas as notificações para a frente da tela
                            Application.OpenForms["FrmListNotification"].BringToFront();
                        }
                        //Esconde o Form de edição da notificação
                        this.Close();
                    }
                    else if (result != "")
                    {
                        //Exibe uma mensagem generica informando que algo não ocorreu como deveria
                        Error.SendAttention("Ocorreu um erro ao executar essa ação.\nCaso persista, contate o suporte.", "Erro");
                    }
                }
            }
        }
    }
}
