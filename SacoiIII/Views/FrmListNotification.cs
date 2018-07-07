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
    public partial class FrmListNotification : Form
    {
        #region Local Atributtes
        string user_logged = "";
        #endregion

        #region Controllers
        //Instância do controller de notificações
        NotificacoesController NotificacoesController = new NotificacoesController();
        //Instância do controller de usuários
        UsuarioController UsuarioController = new UsuarioController();
        #endregion

        public FrmListNotification(string _user_logged)
        {
            InitializeComponent();
            user_logged = _user_logged;
            ListarNotificacoes();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarNotificacoes()
        {
            //Limpa os registros listados na Data Grid View para não duplicar os registros listados
            DGVNotification.Rows.Clear();

            //Verifica se o usuário deseja listar inclusive as notificações que estão invalidas
            if (ChkInvalidas.Checked)
            {
                //Percorre a lista preenchida na camada DAO para popular a Data Grid View com todas as notificações
                foreach (var notificacao in NotificacoesController.GetNotificacaosWithInvalidas())
                {
                    DGVNotification.Rows.Add(notificacao.notificacao, notificacao.texto, notificacao.usuario, notificacao.user_name, notificacao.valido);
                }
            }
            else
            {
                //Percorre a lista preenchida na camada DAO para popular a Data Grid View com as notificações validas
                foreach (var notificacao in NotificacoesController.GetNotificacoes())
                {
                    DGVNotification.Rows.Add(notificacao.notificacao, notificacao.texto, notificacao.usuario, notificacao.user_name, notificacao.valido);
                }
            }
        }

        private void BtnRelistar_Click(object sender, EventArgs e)
        {
            ListarNotificacoes();
        }

        private void DGVNotification_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVNotification.SelectedRows[0].Cells[1].Value.ToString() != "")
            {
                string notificacao = DGVNotification.SelectedRows[0].Cells[0].Value.ToString();
                string conteudo = DGVNotification.SelectedRows[0].Cells[1].Value.ToString();
                string usuario = DGVNotification.SelectedRows[0].Cells[2].Value.ToString();
                string user_name = DGVNotification.SelectedRows[0].Cells[3].Value.ToString();
                string valido = DGVNotification.SelectedRows[0].Cells[4].Value.ToString();
                FrmInfoNotification frmInfo = new FrmInfoNotification(notificacao, usuario, user_name, conteudo, valido, user_logged);
                frmInfo.ShowDialog();
            }
        }

        private void FrmListNotification_Enter(object sender, EventArgs e)
        {
            ListarNotificacoes();
        }

        private void ChkInvalidas_CheckedChanged(object sender, EventArgs e)
        {
            ListarNotificacoes();
        }

        private void FrmListNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            var Usuario = UsuarioController.GetPessoa(user_logged);
            if (Usuario.admin == "Sim")
            {
                Application.OpenForms["FrmHomeA"].Activate();
            }
            else if (Usuario.admin == "Não")
            {
                Application.OpenForms["FrmHomeU"].Activate();
            }
        }
    }
}
