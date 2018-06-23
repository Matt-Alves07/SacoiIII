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

namespace SacoiIII.Views
{
    public partial class FrmHomeA : Form
    {
        #region Notificações Controller
        //Instâmcia do objeto NotificacaoController para ser acessado para cadastrar notificações
        NotificacoesController NotificacoesController = new NotificacoesController();
        #endregion
        #region Admin Controller
        AdminController Controller = new AdminController();
        #endregion

        #region Local Attributtes
        //Variáveis locais e de acesso interno exclusivamente
        private string UserName = "";
        //Instância do form feed usado para exibir as notificações para usuário e administradores
        FrmFeed feed = new FrmFeed();
        #endregion

        public FrmHomeA(string _user_name)
        {
            InitializeComponent();
            UserName = _user_name;
            LblUserName.Text = LblUserName.Text + UserName;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?\nVocê terá de efetuar login novamente para voltar.", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void FrmHomeA_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void BtnRelistar_Click(object sender, EventArgs e)
        {
            RefreshNotificacao();
        }

        private void BtnMensagens_Click(object sender, EventArgs e)
        {
            FrmMessageA message = new FrmMessageA();
            message.ShowDialog();
        }

        private void BtnListarUsers_Click(object sender, EventArgs e)
        {
            FrmUserList userList = new FrmUserList(UserName);
            userList.Show();
        }

        #region Hover effect in buttons

        private void BtnSolicitaExclusao_MouseEnter(object sender, EventArgs e)
        {
            BtnSolicitaExclusao.ForeColor = Color.White;
        }

        private void BtnSolicitaExclusao_MouseLeave(object sender, EventArgs e)
        {
            BtnSolicitaExclusao.ForeColor = Color.Black;
        }

        private void BtnAtualizarCadastro_MouseEnter(object sender, EventArgs e)
        {
            BtnAtualizarCadastro.ForeColor = Color.White;
        }

        private void BtnAtualizarCadastro_MouseLeave(object sender, EventArgs e)
        {
            BtnAtualizarCadastro.ForeColor = Color.Black;
        }

        private void BtnListPedidoExlusao_MouseEnter(object sender, EventArgs e)
        {
            BtnListPedidoExlusao.ForeColor = Color.White;
        }

        private void BtnListPedidoExlusao_MouseLeave(object sender, EventArgs e)
        {
            BtnListPedidoExlusao.ForeColor = Color.Black;
        }

        private void BtnListPedidoAdmin_MouseEnter(object sender, EventArgs e)
        {
            BtnListPedidoAdmin.ForeColor = Color.White;
        }

        private void BtnListPedidoAdmin_MouseLeave(object sender, EventArgs e)
        {
            BtnListPedidoAdmin.ForeColor = Color.Black;
        }

        private void BtnListarNotificacoes_MouseEnter(object sender, EventArgs e)
        {
            BtnListarNotificacoes.ForeColor = Color.White;
        }

        private void BtnListarNotificacoes_MouseLeave(object sender, EventArgs e)
        {
            BtnListarNotificacoes.ForeColor = Color.Black;
        }

        private void BtnShare_MouseEnter(object sender, EventArgs e)
        {
            BtnShare.ForeColor = Color.White;
            BtnShare.Image = Properties.Resources.share_option_24w;
        }

        private void BtnShare_MouseLeave(object sender, EventArgs e)
        {
            BtnShare.ForeColor = Color.Black;
            BtnShare.Image = Properties.Resources.share_option_24b;
        }

        #endregion

        private void FrmHomeA_Load(object sender, EventArgs e)
        {
            feed.TopLevel = false;
            PnlFeed.Controls.Add(feed);
            feed.Show();
        }

        private void BtnShare_Click(object sender, EventArgs e)
        {
            //Cria a variável que receberá o retorno que veio do controller
            string status = "";

            //Validação caso o campo notificação não tenha sido preenchido
            if (TxtNotification.Text == "")
            {
                MessageBox.Show("Não é possível criar uma notificação vazia.\nPreencha o campo de notificação e tente novamente.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Validação caso o tamanho do texto seja maior que o suportado pelo banco
            else if (TxtNotification.TextLength > 255)
            {
                MessageBox.Show("A notificação possui mais de 255 caracteres.\nReduza seu texto e tente novamente.", "Tamanho excedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Caso esteja valido, usa o controller para inserir a nova notificação
            else
            {
                //A variável local recebe o resultado da inserção através do controller
                status = NotificacoesController.InsertNotificacao(UserName, TxtNotification.Text);

                //Caso não tenha ocorrido problemas pra cadastrar a nova notificação
                if (status == "sucesso")
                {
                    MessageBox.Show("Notificação cadastrada com sucesso.", "Notificação cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshNotificacao();
                    TxtNotification.Text = "";
                }
                //Caso tenha ocorrido algum erro generico
                else if (status == "falha")
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar a notificação.\nSe persistir, contate o suporte.", "Notificação não cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //Caso tenha vindo uma exceção do banco
                else
                {
                    MessageBox.Show(status, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmHomeA_Resize(object sender, EventArgs e)
        {
            this.feed.WindowState = FormWindowState.Minimized;
            this.feed.WindowState = FormWindowState.Maximized;

            //Refaz esse processo para forçaros labels do form Feed se ajustarem
            this.feed.Close();
            FrmFeed feed = new FrmFeed();
            feed.TopLevel = false;
            PnlFeed.Controls.Add(feed);
            feed.Show();
        }

        private void RefreshNotificacao()
        {
            this.feed.Close();
            FrmFeed feed = new FrmFeed();
            feed.TopLevel = false;
            PnlFeed.Controls.Add(feed);
            feed.Show();
        }

        private void BtnListPedidoAdmin_Click(object sender, EventArgs e)
        {
            FrmPedidosAdmin pedidosAdmin = new FrmPedidosAdmin();
            pedidosAdmin.Show();
        }

        private void BtnListPedidoExlusao_Click(object sender, EventArgs e)
        {
            FrmPedidosExclusao pedidosExclusao = new FrmPedidosExclusao();
            pedidosExclusao.Show();
        }

        private void BtnSolicitaExclusao_Click(object sender, EventArgs e)
        {
            #region Local Attributes
            string situacao = "";
            #endregion

            #region Controller Access
            situacao = Controller.SolicitarExclusao(UserName);
            #endregion

            #region Result Validation
            if (situacao == "sucesso")
            {
                MessageBox.Show("Solicitação enviada.\nAguarde enquanto um dos administradores do sistema avalia seu pedido.", "Pedido realizado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (situacao == "solicitado")
            {
                MessageBox.Show("Essa solicitação já foi feita.\nAguarde enquanto um dos administradores do sistema avalia seu pedido.", "Soliciação em analise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion
        }
    }
}