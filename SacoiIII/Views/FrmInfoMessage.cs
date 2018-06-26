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
    public partial class FrmInfoMessage : Form
    {
        public FrmInfoMessage(string sender, string about, string text)
        {
            InitializeComponent();
            LblSender.Text = sender;
            LblAbout.Text = about;
            LblText.Text = text;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
