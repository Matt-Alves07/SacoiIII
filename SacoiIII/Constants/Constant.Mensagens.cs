using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacoiIII.Constants
{
    class MessagesConstants
    {
        #region Connection
        //Instânciação da classe ConnectionConstants para uso no acesso ao banco de dados
        ConnectionConstant connection = new ConnectionConstant();
        #endregion

        #region Table Messages
        //Criação da constante que armazena a informação necessária para chegar a tabela mensagen
        private const string TBMensagem = ".mensagens";
        public string GetTBMensagens() => connection.GetDataBase() + TBMensagem;
        #endregion

        #region PAdicionarMensagem
        //Criação da constante que armazena a informação necessária para chamar a procedure AdicionarEmail
        private const string PAdicionarMensagem = ".AdicionarEmail";
        public string GetPAdicionarMensagem() => connection.GetDataBase() + PAdicionarMensagem;
        #endregion

        #region PRetornarMensagem
        //Criação da constante que armazena a informação necessária para chamar a procedure RetornarEmail
        private const string PRetornarMensagem = ".RetornarEmail";
        public string GetPRetornarMensagem() => connection.GetDataBase() + PRetornarMensagem;
        #endregion

        #region PListarMensagemUsuario
        //Criação da constante que armazena a informação necessária para chamar a procedure VisualizarEmailUser
        private const string PVisualizarMensagemUsuario = ".VisualizarEmailUser";
        public string GetPVisualizarMensagemUsuario() => connection.GetDataBase() + PVisualizarMensagemUsuario;
        #endregion

        #region PListarMensagemAdmin
        //Criação da constante que armazena a informação necessária para chamar a procedure VisualizarEmailAdmin
        private const string PVisualizarMensagemAdmin = ".VisualizarEmailAdmin";
        public string GetPVisualizarMensagemAdmin() => connection.GetDataBase() + PVisualizarMensagemAdmin;
        #endregion
    }
}