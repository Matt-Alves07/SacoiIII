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
using SacoiIII.DTO;
using SacoiIII.Controller;

namespace SacoiIII.Views
{
    public partial class FrmMessage : Form
    {
        #region Local Atributtes
        //Criação das variáveis que armazenam os nomes de usuários usados como remetente e destinatário
        //Instância dos objetos que armazenam os registros do remetente e do destinatário
        //E instância da Controller Admin usado para acessar a camada view
        string Sender = "", Receiver = "";
        PessoaDTO PessoaSender = new PessoaDTO();
        PessoaDTO PessoaReceiver = new PessoaDTO();
        AdminController Controller = new AdminController();
        #endregion

        public FrmMessage(string _sender, string _receiver)
        {
            InitializeComponent();
            Sender = _sender;
            Receiver = _receiver;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            //Valida se o usuário realmente deseja enviar o email
            if (MessageBox.Show("Enviando email para " + Receiver + " a partir do usuário " + Sender + ".\nDeseja continuar?", "Enviando mensagem", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.Cancel)
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
                    msg.To.Add(PessoaReceiver.email);

                    //Assunto do email
                    msg.Subject = "SACOI " + PessoaSender.p_nome + TxtSubject.Text;

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
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtSubject.Text = "";
            TxtBody.Text = "";
        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            PessoaSender = Controller.GetPessoa(Sender);
            PessoaReceiver = Controller.GetPessoa(Receiver);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}