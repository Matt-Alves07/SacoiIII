using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SacoiIII.DTO;
using SacoiIII.Controller;

namespace SacoiIII.Views
{
    public partial class FrmUserList : Form
    {
        #region Local Attributes
        string username = "";
        #endregion

        #region Controller
        //Instância de objeto para acessar a camada Controller
        AdminController AdminController = new AdminController();
        #endregion

        public FrmUserList(string _user_name)
        {
            InitializeComponent();
            DGVUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVUser.AllowUserToAddRows = false;
            DGVUser.AllowUserToDeleteRows = false;
            DGVUser.AllowUserToOrderColumns = false;
            DGVUser.AllowUserToResizeColumns = false;
            DGVUser.AllowUserToResizeRows = false;
            DGVUser.ReadOnly = true;
            username = _user_name;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarUsuarios()
        {
            #region Data Grid View Clear
            DGVUser.Rows.Clear();
            #endregion

            #region List Read
            foreach (PessoaDTO pessoa in AdminController.ListarUsuarios())
            {
                DGVUser.Rows.Add(pessoa.pessoa, pessoa.user_name, pessoa.p_nome, pessoa.s_nome, pessoa.email, pessoa.cargo, pessoa.admin);
            }
            #endregion
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void DGVUser_DoubleClick(object sender, EventArgs e)
        {
            FrmMessage Message = new FrmMessage(username, DGVUser.SelectedRows[0].Cells[1].Value.ToString());
            Message.Show();
        }

        private void BtnRelistar_Click(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
    }
}
