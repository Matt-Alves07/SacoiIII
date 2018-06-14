using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SacoiIII.Views
{
    public partial class FrmMessage : Form
    {
        public FrmMessage()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            try
            {

                //Cria um client SMTP para enviar o email. (host, porta)
                SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);

                //Aqui informa ao programa qual email (junto com a senha) que irá enviar.
                NetworkCredential cred = new NetworkCredential("sacoi.tcc@outlook.com.br", "m1nh4s3nh4");

                //Código para criar o email (sem as informações) que iremos mandar.
                MailMessage msg = new MailMessage();

                //Enviando informações do email
                //Email remetente
                msg.From = new MailAddress("sacoi.tcc@outlook.com.br");

                //Email destinatário
                msg.To.Add(TxtTo.Text);

                //Assunto do email
                msg.Subject = TxtSubject.Text;

                //Corpo de texto do email
                msg.Body = TxtBody.Text;

                //Envia para o SACOI as credenciais do email
                client.Credentials = cred;

                //Habilita o SSL (Secure Sockets Layer) que os servidores de email pedem.
                client.EnableSsl = true;

                //Envia o email
                client.Send(msg);

                MessageBox.Show("Email enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não foi possível enviar o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtBody.Text = "";
            TxtSubject.Text = "";
            TxtTo.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
