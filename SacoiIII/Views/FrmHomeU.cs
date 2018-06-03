﻿using System;
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
    public partial class FrmHomeU : Form
    {
        #region Notificações Controller
        //Instâmcia do objeto NotificacaoController para ser acessado para cadastrar notificações
        NotificacoesController NotificacoesController = new NotificacoesController();
        #endregion

        #region Local Attributtes
        //Variáveis locais e de acesso interno exclusivamente
        private string UserName = "";
        #endregion

        public FrmHomeU(string _user_name)
        {
            InitializeComponent();
            UserName = _user_name;
            LblUserName.Text = LblUserName.Text + UserName;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?\nVocê terá de efetuar login novamente para voltar.", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                Close();
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void FrmHomeU_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void BtnMensagens_Click(object sender, EventArgs e)
        {
            FrmMessageU message = new FrmMessageU();
            message.ShowDialog();
        }

        private void BtnRelistar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa funcionalidade ainda não está implementada.", "Em progresso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUserAtualizar_MouseEnter(object sender, EventArgs e)
        {
            BtnUserAtualizar.ForeColor = Color.White;
        }

        private void BtnUserAtualizar_MouseLeave(object sender, EventArgs e)
        {
            BtnUserAtualizar.ForeColor = Color.Black;
        }

        private void BtnSolModerar_MouseEnter(object sender, EventArgs e)
        {
            BtnSolModerar.ForeColor = Color.White;
        }

        private void BtnSolModerar_MouseLeave(object sender, EventArgs e)
        {
            BtnSolModerar.ForeColor = Color.Black;
        }

        private void BtnSolExcluir_MouseEnter(object sender, EventArgs e)
        {
            BtnSolExcluir.ForeColor = Color.White;
        }

        private void BtnSolExcluir_MouseLeave(object sender, EventArgs e)
        {
            BtnSolExcluir.ForeColor = Color.Black;
        }

        private void BtnListarNotificacoes_MouseEnter(object sender, EventArgs e)
        {
            BtnListarNotificacoes.ForeColor = Color.White;
        }

        private void BtnListarNotificacoes_MouseLeave(object sender, EventArgs e)
        {
            BtnListarNotificacoes.ForeColor = Color.Black;
        }

        private void FrmHomeU_Load(object sender, EventArgs e)
        {
            FrmFeed feed = new FrmFeed();
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
                MessageBox.Show("Não é possível criar uma notificação vazia.\nPreench o campo de notificação e tente novamente.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Notificação cadastrada com sucesso.\nAtualize a pagina e ela estará na lista de notificações recentes", "Notificação cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}