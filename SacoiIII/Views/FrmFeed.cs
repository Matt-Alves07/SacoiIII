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
            foreach (NotificacaoDTO Linha in NotificacoesController.ExibirNotificacoes())
            {
                //Your code goes here!
            }
        }
    }
}
