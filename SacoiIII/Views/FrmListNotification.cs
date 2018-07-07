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
        #region Controller
        NotificacoesController Controller = new NotificacoesController();
        #endregion

        public FrmListNotification()
        {
            InitializeComponent();
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

            //Executa o loop montado na DAO e recebido pelo controller para popular a Data Grid View
            foreach (var notificacao in Controller.GetNotificacoes())
            {
                DGVNotification.Rows.Add(notificacao.notificacao, notificacao.texto, notificacao.usuario, notificacao.user_name, notificacao.valido);
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
                FrmInfoNotification frmInfo = new FrmInfoNotification(notificacao, usuario, user_name, conteudo, valido);
                frmInfo.ShowDialog();
            }
        }

        private void FrmListNotification_Enter(object sender, EventArgs e)
        {
            ListarNotificacoes();
        }
    }
}
