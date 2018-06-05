using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SacoiIII.Controller;
using SacoiIII.DTO;

namespace SacoiIII.Views
{
    public partial class FrmFeed : Form
    {
        #region Objects
        //Instânciação dos objetos Controller para uso interno
        NotificacoesController NotificacoesController = new NotificacoesController();
        #endregion

        public FrmFeed()
        {
            InitializeComponent();
        }

        private void FrmFeed_Load(object sender, EventArgs e)
        {
            ExibirNotificacoes();
        }

        public void ExibirNotificacoes()
        {
            //Variáveis para alinhamento das notificações e variável para o controle do switch
            int i = 1;
            int top_align = 50;
            int top_align_user = 35;
            int left_align = 40;
            int left_align_user = 40;
            foreach (NotificacaoDTO Linha in NotificacoesController.ExibirNotificacoes())
            {
                switch (i)
                {
                    case 1:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser1 = new Label();
                        lblUser1.Text = Linha.user_name.ToString() + ":";
                        lblUser1.Left = left_align_user;
                        lblUser1.Top = top_align_user;
                        lblUser1.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot1 = new Label();
                        lblNot1.Text = Linha.texto.ToString();
                        lblNot1.Top = top_align;
                        lblNot1.Left = left_align;
                        lblNot1.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser1);
                        this.Controls.Add(lblNot1);
                        break;
                    case 2:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser2 = new Label();
                        lblUser2.Text = Linha.user_name.ToString() + ":";
                        lblUser2.Left = left_align_user;
                        lblUser2.Top = top_align_user + 100;
                        lblUser2.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot2 = new Label();
                        lblNot2.Text = Linha.texto.ToString();
                        lblNot2.Left = left_align;
                        lblNot2.Top = top_align + 100;
                        lblNot2.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser2);
                        this.Controls.Add(lblNot2);
                        break;
                    case 3:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser3 = new Label();
                        lblUser3.Text = Linha.user_name.ToString() + ":";
                        lblUser3.Left = left_align_user;
                        lblUser3.Top = top_align_user + 200;
                        lblUser3.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot3 = new Label();
                        lblNot3.Text = Linha.texto.ToString();
                        lblNot3.Left = left_align;
                        lblNot3.Top = top_align + 200;
                        lblNot3.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser3);
                        this.Controls.Add(lblNot3);
                        break;
                    case 4:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser4 = new Label();
                        lblUser4.Text = Linha.user_name.ToString() + ":";
                        lblUser4.Left = left_align_user;
                        lblUser4.Top = top_align_user + 300;
                        lblUser4.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot4 = new Label();
                        lblNot4.Text = Linha.texto.ToString();
                        lblNot4.Left = left_align;
                        lblNot4.Top = top_align + 300;
                        lblNot4.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser4);
                        this.Controls.Add(lblNot4);
                        break;
                    case 5:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser5 = new Label();
                        lblUser5.Text = Linha.user_name.ToString() + ":";
                        lblUser5.Left = left_align_user;
                        lblUser5.Top = top_align_user + 400;
                        lblUser5.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot5 = new Label();
                        lblNot5.Text = Linha.texto.ToString();
                        lblNot5.Left = left_align;
                        lblNot5.Top = top_align + 400;
                        lblNot5.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser5);
                        this.Controls.Add(lblNot5);
                        break;
                    case 6:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser6 = new Label();
                        lblUser6.Text = Linha.user_name.ToString() + ":";
                        lblUser6.Left = left_align_user;
                        lblUser6.Top = top_align_user + 500;
                        lblUser6.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot6 = new Label();
                        lblNot6.Text = Linha.texto.ToString();
                        lblNot6.Left = left_align;
                        lblNot6.Top = top_align + 500;
                        lblNot6.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser6);
                        this.Controls.Add(lblNot6);
                        break;
                    case 7:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser7 = new Label();
                        lblUser7.Text = Linha.user_name.ToString() + ":";
                        lblUser7.Left = left_align_user;
                        lblUser7.Top = top_align_user + 600;
                        lblUser7.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot7 = new Label();
                        lblNot7.Text = Linha.texto.ToString();
                        lblNot7.Left = left_align;
                        lblNot7.Top = top_align + 600;
                        lblNot7.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser7);
                        this.Controls.Add(lblNot7);
                        break;
                    case 8:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser8 = new Label();
                        lblUser8.Text = Linha.user_name.ToString() + ":";
                        lblUser8.Left = left_align_user;
                        lblUser8.Top = top_align_user + 700;
                        lblUser8.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot8 = new Label();
                        lblNot8.Text = Linha.texto.ToString();
                        lblNot8.Left = left_align;
                        lblNot8.Top = top_align + 700;
                        lblNot8.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser8);
                        this.Controls.Add(lblNot8);
                        break;
                    case 9:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser9 = new Label();
                        lblUser9.Text = Linha.user_name.ToString() + ":";
                        lblUser9.Left = left_align_user;
                        lblUser9.Top = top_align_user + 800;
                        lblUser9.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot9 = new Label();
                        lblNot9.Text = Linha.texto.ToString();
                        lblNot9.Left = left_align;
                        lblNot9.Top = top_align + 800;
                        lblNot9.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser9);
                        this.Controls.Add(lblNot9);
                        break;
                    case 10:
                        //Criação da Label para receber o nome de usuário e definição de suas propriedades
                        Label lblUser10 = new Label();
                        lblUser10.Text = Linha.user_name.ToString() + ":";
                        lblUser10.Left = left_align_user;
                        lblUser10.Top = top_align_user + 900;
                        lblUser10.AutoSize = true;
                        //Criação da Label para receber o texto da notificação e as suas propriedades
                        Label lblNot10 = new Label();
                        lblNot10.Text = Linha.texto.ToString();
                        lblNot10.Left = left_align;
                        lblNot10.Top = top_align + 900;
                        lblNot10.AutoSize = true;
                        //Comandos para adicionar as duas label no programa
                        this.Controls.Add(lblUser10);
                        this.Controls.Add(lblNot10);
                        break;
                }
                i += 1;
            }
        }
    }
}
