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
    public partial class FrmMessageU : Form
    {
        #region Local Attributes
        string user = "";
        MessageController Controller = new MessageController();
        #endregion

        public FrmMessageU(string _user_name)
        {
            InitializeComponent();
            //Atribui o nome de usuário da instância do form a variável da classe
            user = _user_name;
            //COnfigurações da Data Grid View
            DGVMessage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVMessage.AllowUserToAddRows = false;
            DGVMessage.AllowUserToDeleteRows = false;
            DGVMessage.AllowUserToOrderColumns = false;
            DGVMessage.AllowUserToResizeColumns = false;
            DGVMessage.AllowUserToResizeRows = false;
            DGVMessage.ReadOnly = true;
            //Chamada do metodo que preenche a Data Grid View para exibir o form já preenchido
            ListarMensagens();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarMensagens()
        {
            //Limpa os registros existentes na Data Grid View
            DGVMessage.Rows.Clear();
            //Faz um loop para preencher a Data Grid View
            foreach (var linha in Controller.GetMensagensUsers(user))
            {
                DGVMessage.Rows.Add(linha.mensagem, linha.user_sender, linha.assunto, linha.texto);
            }
        }

        private void BtnRelistar_Click(object sender, EventArgs e)
        {
            //Chama o metodo que atualiza os registros no Data Grid View
            ListarMensagens();
        }

        private void DGVMessage_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVMessage.SelectedRows[0].Cells[1].Value.ToString() != "")
            {
                string remetente = DGVMessage.SelectedRows[0].Cells[1].Value.ToString();
                string assunto = DGVMessage.SelectedRows[0].Cells[2].Value.ToString();
                string texto = DGVMessage.SelectedRows[0].Cells[3].Value.ToString();
                FrmInfoMessage infoMessage = new FrmInfoMessage(remetente, assunto, texto);
                infoMessage.ShowDialog();
            }
        }
    }
}
