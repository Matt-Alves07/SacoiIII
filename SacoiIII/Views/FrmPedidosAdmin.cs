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
using SacoiIII.DTO;

namespace SacoiIII
{
    public partial class FrmPedidosAdmin : Form
    {
        #region Local Atributtes
        //Variáveis de uso local do Form
        AdminController Controller = new AdminController();
        PessoaDTO Pessoa = new PessoaDTO();
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
            foreach (PessoaDTO Pessoa in Controller.GetPedidosadmin())
            {
                DGVUser.Rows.Add(Pessoa.pessoa, Pessoa.pedido, Pessoa.user_name, Pessoa.data_pedido);
            }
        }

        private void BtnRelistar_Click(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}
