using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SacoiIII.Views
{
    public partial class FrmMessageA : Form
    {
        public FrmMessageA()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");

                mail.From = new MailAddress("sacoi.tcc@outlook.com");
                mail.To.Add(TxtTo.Text);
                mail.Subject = TxtSubject.Text;
                mail.Body = TxtBody.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sacoi.tcc@outlook.com", "M1nh@S3nh@");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email enviado com sucesso!", "Email Enviado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBody.Text = "";
            TxtSubject.Text = "";
            TxtTo.Text = "";
            TxtTo.Focus();
        }
    }
}
