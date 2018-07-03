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
    public partial class FrmInfoNotification : Form
    {
        #region Local Atributtes
        string notificacao = "";
        string user = "";
        string user_name = "";
        string text = "";
        string valid = "";
        #endregion

        public FrmInfoNotification(string _notificacao, string _user, string _user_name, string _text, string _valid)
        {
            InitializeComponent();
            notificacao = _notificacao;
            user = _user;
            user_name = _user_name;
            text = _text;
            valid = _valid;
        }

        private void FrmInfoNotification_Load(object sender, EventArgs e)
        {
            LblUserName.Text = " " + user_name;
            LblValido.Text = "Notificação valida: " + valid;
            LblTexto.Text = text;
        }

        private void BtnEdit_MouseEnter(object sender, EventArgs e)
        {
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Image = Properties.Resources.update_32w;
        }

        private void BtnEdit_MouseLeave(object sender, EventArgs e)
        {
            BtnEdit.ForeColor = Color.Black;
            BtnEdit.Image = Properties.Resources.update_32b;
        }

        private void BtnDenunciar_MouseEnter(object sender, EventArgs e)
        {
            BtnDenunciar.ForeColor = Color.White;
            BtnDenunciar.Image = Properties.Resources.warning_32w;
        }

        private void BtnDenunciar_MouseLeave(object sender, EventArgs e)
        {
            BtnDenunciar.ForeColor = Color.Black;
            BtnDenunciar.Image = Properties.Resources.warning_32b;
        }

        private void BtnExcluir_MouseEnter(object sender, EventArgs e)
        {
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Image = Properties.Resources.delete_32w;
        }

        private void BtnExcluir_MouseLeave(object sender, EventArgs e)
        {
            BtnExcluir.ForeColor = Color.Black;
            BtnExcluir.Image = Properties.Resources.delete_32b;
        }
    }
}
