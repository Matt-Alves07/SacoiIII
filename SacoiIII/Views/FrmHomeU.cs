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
    public partial class FrmHomeU : Form
    {
        public FrmHomeU(string _user_name)
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
    }
}
