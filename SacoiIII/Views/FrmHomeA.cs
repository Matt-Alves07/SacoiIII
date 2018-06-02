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
        public FrmHomeA()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            Hide();
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
    }
}
