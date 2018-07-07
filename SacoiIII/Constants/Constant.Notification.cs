using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacoiIII.Constants
{
    class NotificationConstant
    {
        #region Connection
        //Instânciação da classe ConnectionConstants para uso no acesso ao banco de dados
        ConnectionConstant connection = new ConnectionConstant();
        #endregion

        #region TBNotificações
        //Criação da constante que acessa a tabela notificações e metodo para retornar a string com as informações necessários para efetuar o acesso
        private const string tbNotification = ".notificacoes";
        public string GetTBNotificacoes() => connection.GetDataBase() + tbNotification;
        #endregion

        #region PAdicionarNotificacao
        //Criação da constante que aponta a Procedure AdicionarNotificacao e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pAdicionarNotificacao = ".AdicionarNotificacao";
        public string GetPAdicionarNotificacao() => connection.GetDataBase() + pAdicionarNotificacao;
        #endregion

        #region PDeletarNotificacao
        //Criação da constante que aponta a Procedure DeletarNotificacao e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string PDeletarNotificacao = ".DeletarNotificacao";
        public string GetPDeletarNotificacao() => connection.GetDataBase() + PDeletarNotificacao;
        #endregion

        #region PExibirNotificacao
        //Criação da constante que aponta a Procedure ExibirNotificacao e metodo que retorna a string com a informação necessária para chamar a Procedure
        //Essa Procedure lista as notificações que são exibidas nas telas home
        private const string pExibirNotificacao = ".ExibirNotificacoes";
        public string GetPExibirNotificacoes() => connection.GetDataBase() + pExibirNotificacao;
        #endregion

        #region PListarNotificacao
        //Criação da constante que aponta a Procedure ListarNotificacao e metodo que retorna a string com a informação necessária para chamar a Procedure
        //Essa procedure lista as notificações que são exibidas na tela de listar notificações
        private const string pListarNotificacao = ".ListarNotificacoes";
        public string GetPListarNotificacoes() => connection.GetDataBase() + pListarNotificacao;
        #endregion

        #region PListarNotificacoesWithInvalidas
        //Criação da constante que aponta a Procedure ListarNotificacao e metodo que retorna a string com a informação necessária para chamar a Procedure
        //Essa procedure lista as notificações que são exibidas na tela de listar notificações incluind as invalidas
        private const string pListarNotificacoes = ".ListarNotificacoesWithInvalidas";
        public string GetPListarNotificacoesWithInvalidas() => connection.GetDataBase() + pListarNotificacoes;
        #endregion

        #region PInvalidarNotificacao
        //Criação da constante que aponta a Procedure InvalidarNotificacao e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pInvalidarNotificacao = ".InvalidarNotificacao";
        public string GetPInvalidarNotificacao() => connection.GetDataBase() + pInvalidarNotificacao;
        #endregion

        #region PAlterarNotificacao
        //Criação da constante que aponta a Procedure AlterarNotificacao e metodo que retorna a string com a informação necessário para chamar a procedure
        private const string pAlterarNotificacao = ".AlterarNotificacao";
        public string GetPAlterarNotificacao() => connection.GetDataBase() + pAlterarNotificacao;
        #endregion
    }
}
