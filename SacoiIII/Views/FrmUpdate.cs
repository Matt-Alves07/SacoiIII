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
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmSobre Sobre = new FrmSobre();
            Sobre.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSenha.Checked)
            {
                TxtSenha.UseSystemPasswordChar = false;
                TxtRSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
                TxtRSenha.UseSystemPasswordChar = true;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtPNome.Text = "";
            TxtSNome.Text = "";
            TxtEmail.Text = "";
            TxtCargo.Text = "";
            TxtSenha.Text = "";
            TxtRSenha.Text = "";
            TxtPNome.Focus();
        }
    }
}
