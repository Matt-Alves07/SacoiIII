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

namespace SacoiIII
{
    public partial class FrmPedidosAdmin : Form
    {
        #region Local Atributtes
        //Variáveis de uso local do Form
        AdminController Controller = new AdminController();
        #endregion

        public FrmPedidosAdmin()
        {
            InitializeComponent();
            DGVUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVUser.AllowUserToAddRows = false;
            DGVUser.AllowUserToDeleteRows = false;
            DGVUser.AllowUserToOrderColumns = false;
            DGVUser.AllowUserToResizeColumns = false;
            DGVUser.AllowUserToResizeRows = false;
            DGVUser.ReadOnly = true;
            ListarRegistros();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarRegistros()
        {
            //Limpa os registros existentes na Grid
            DGVUser.Rows.Clear();

            //Loop para cada pedido registrado no banco
            foreach (var Pessoa in Controller.GetPedidosadmin())
            {
                DGVUser.Rows.Add(Pessoa.pessoa, Pessoa.pedido, Pessoa.user_name, Pessoa.data_pedido);
            }
        }

        private void BtnRelistar_Click(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void DGVUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string pessoa = DGVUser.SelectedRows[0].Cells[0].Value.ToString();
            string situacao = "";
            DialogResult result = MessageBox.Show("Deseja tornar este usuário um administrador do sistema?", "Alterar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if(result == DialogResult.Yes)
            {
                situacao = Controller.AprovarAdmin(pessoa);
                if (situacao == "sucesso")
                {
                    MessageBox.Show("Usuário alterado com sucesso.\nQuando ele acessar novamente o sistema já será um administrador", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarRegistros();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + situacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                result = MessageBox.Show("Deseja excluir o pedido deste usuário?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    situacao = Controller.RejeitarAdmin(pessoa);
                    if (situacao == "sucesso")
                    {
                        MessageBox.Show("Pedido recusado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarRegistros();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro: " + situacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
