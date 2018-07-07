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
    public partial class FrmInfoNotification : Form
    {
        #region Controller
        //Instância do controller de notificações usado para realizar as operações de deletar e invalidar notificações nesta tela
        private NotificacoesController Controller = new NotificacoesController();
        #endregion

        #region Erro
        Error Error = new Error();
        #endregion

        #region Local Atributtes
        string notificacao = "";
        string user = "";
        string user_name = "";
        string text = "";
        string valid = "";
        #endregion

        public FrmInfoNotification(string _notificacao, string _user, string _user_name, string _text, string _valid)
        {
            InitializeComponent();
            notificacao = _notificacao;
            user = _user;
            user_name = _user_name;
            text = _text;
            valid = _valid;
        }

        private void FrmInfoNotification_Load(object sender, EventArgs e)
        {
            LblUserName.Text = " " + user_name;
            LblValido.Text = "Notificação valida: " + valid;
            LblTexto.Text = text;
        }

        private void BtnEdit_MouseEnter(object sender, EventArgs e)
        {
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Image = Properties.Resources.update_32w;
        }

        private void BtnEdit_MouseLeave(object sender, EventArgs e)
        {
            BtnEdit.ForeColor = Color.Black;
            BtnEdit.Image = Properties.Resources.update_32b;
        }

        private void BtnDenunciar_MouseEnter(object sender, EventArgs e)
        {
            BtnDenunciar.ForeColor = Color.White;
            BtnDenunciar.Image = Properties.Resources.warning_32w;
        }

        private void BtnDenunciar_MouseLeave(object sender, EventArgs e)
        {
            BtnDenunciar.ForeColor = Color.Black;
            BtnDenunciar.Image = Properties.Resources.warning_32b;
        }

        private void BtnExcluir_MouseEnter(object sender, EventArgs e)
        {
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Image = Properties.Resources.delete_32w;
        }

        private void BtnExcluir_MouseLeave(object sender, EventArgs e)
        {
            BtnExcluir.ForeColor = Color.Black;
            BtnExcluir.Image = Properties.Resources.delete_32b;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Verifica se o usuário realmente deseja deletar e avisa que não há como desfazer isso
            if (Error.SendQuestion("Deseja realmente deletar essa notificação?\nEssa ação não pode ser desfeita.", "Excluir") == DialogResult.Yes)
            {
                //Se o usuário clicar em sim, chama o metodo do Controller que cuida da exclusão
                if ((Controller.DeleteNotificacao(notificacao, user)) == "sucesso")
                {
                    Error.SendOK("Notificação deletada com sucesso.", "Sucesso");
                    Close();
                }else
                {
                    Error.SendAttention("Ocorreu um erro ao realizar essa operação.\nCaso persista, contate o suporte.", "Falha");
                }
            }
        }

        private void FrmInfoNotification_Leave(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void BtnDenunciar_Click(object sender, EventArgs e)
        {
            //Verifica se o usuário realmente deseja fazer isso e avisa que para reverter ele terá de ir a tela de editar notificação
            if (Error.SendQuestion("Essa notificação não será mais exibida e para reverter será necessário ir em editar e salvar novamente a notificação para reverter.\nDeseja realmete invalidar essa notificação?", "Invalidar?") == DialogResult.Yes)
            {
                //Se o usuário clicar em sim, chama o metodo do Controllerque cuida do invalidar
                if (Controller.InvalidateNotificacao(notificacao, user) == "sucesso")
                {
                    Error.SendOK("Notificação invalidada com sucesso.", "Sucesso");
                    Close();
                }
                else
                {
                    Error.SendAttention("Ocorreu um erro ao realizar essa operação.\nCaso persista, contate o suporte.", "Falha");
                }
            }
        }
    }
}
