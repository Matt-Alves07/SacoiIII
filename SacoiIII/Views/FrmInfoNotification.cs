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
            LblUserName.Text = user_name;
            LblValido.Text = valid;
            LblTexto.Text = text;
        }
    }
}
