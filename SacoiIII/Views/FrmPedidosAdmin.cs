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
using SacoiIII.Views;
using SacoiIII.Misc;

namespace SacoiIII
{
    public partial class FrmPedidosAdmin : Form
    {
        #region Local Atributtes
        //Variáveis de uso local do Form
        AdminController Controller = new AdminController();
        string UserName = "";
        Error Error = new Error();
        #endregion

        public FrmPedidosAdmin(string _username)
        {
            InitializeComponent();
            DGVUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVUser.AllowUserToAddRows = false;
            DGVUser.AllowUserToDeleteRows = false;
            DGVUser.AllowUserToOrderColumns = false;
            DGVUser.AllowUserToResizeColumns = false;
            DGVUser.AllowUserToResizeRows = false;
            DGVUser.ReadOnly = true;
            UserName = _username;
            ListarRegistros();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            FrmHomeA Form = new FrmHomeA(UserName);
            Form.Show();
            this.Close();
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
            DialogResult result = Error.SendQuestion("Deseja tornar este usuário um administrador do sistema?", "Alterar");
            if(result == DialogResult.Yes)
            {
                situacao = Controller.AprovarAdmin(pessoa);
                if (situacao == "sucesso")
                {
                    Error.SendOK("Usuário alterado com sucesso.\nQuando ele acessar novamente o sistema já será um administrador", "Sucesso");
                    ListarRegistros();
                }
                else
                {
                    Error.SendAttention("Ocorreu um erro: " + situacao, "Erro");
                }
            }
            else if (result == DialogResult.No)
            {
                result = Error.SendQuestion("Deseja excluir o pedido deste usuário?", "Excluir");
                if (result == DialogResult.Yes)
                {
                    situacao = Controller.RejeitarAdmin(pessoa);
                    if (situacao == "sucesso")
                    {
                        Error.SendOK("Pedido recusado com sucesso.", "Sucesso");
                        ListarRegistros();
                    }
                    else
                    {
                        Error.SendAttention("Ocorreu um erro: " + situacao, "Erro");
                    }
                }
            }
        }
    }
}
