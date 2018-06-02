using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacoiIII.Views
{
    public partial class FrmHomeA : Form
    {
        public FrmHomeA(string _user_name)
        {
            InitializeComponent();
            LblUserName.Text = LblUserName.Text + _user_name;
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

        private void FrmHomeA_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void BtnRelistar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa funcionalidade ainda não está implementada.", "Em progresso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMensagens_Click(object sender, EventArgs e)
        {
            FrmMessageA message = new FrmMessageA();
            message.ShowDialog();
        }

        private void BtnListarUsers_Click(object sender, EventArgs e)
        {
            FrmUserList userList = new FrmUserList();
            userList.ShowDialog();
        }

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
    }
}