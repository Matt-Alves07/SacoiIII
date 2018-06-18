using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacoiIII.Constants
{
    class PessoaConstant
    {
        #region Connection
        //Instânciação da classe ConnectionConstants para uso no acesso ao banco de dados
        ConnectionConstant connection = new ConnectionConstant();
        #endregion

        #region TBUsuarios
        //Criação da constante que acessa a tabela usuários e metodo para retornar a string com as informações necessários para efetuar o acesso
        private const string tbUsuarios = ".usuarios";
        public string GetTBUsuarios() => connection.GetDataBase() + tbUsuarios;
        #endregion

        #region TBModeracao
        //Criação da constante que acessa a tabela de pedidos de moderação e metodo para retornar a string com as informações necessárias para efetuar o acesso
        private const string tbModeracao = ".pedidosmoderacao";
        public string GetTBModeracao() => connection.GetDataBase() + tbModeracao;
        #endregion

        #region TBExclusao
        //Criação da constante que acessa a tabela de pedidos de exclusão e metodo para retornar a string com as informações necessárias para efetuar o acesso
        private const string tbExclusao = ".pedidoexclusao";
        public string GetTBExclusao() => connection.GetDataBase() + tbExclusao;
        #endregion

        #region PAdicionarUsuario
        //Criação da constante que aponta a Procedure AdicionarUsuario e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pAdicionarUsuario = ".AdicionarUsuario";
        public string GetPAdicionarUsuario() => connection.GetDataBase() + pAdicionarUsuario;
        #endregion

        #region PEfetuarLogin
        //Criação da constante que aponta a Procedure EfetuarLogin e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pEfetuarLogin = ".EfetuarLogin";
        public string GetPEfetuarLogin() => connection.GetDataBase() + pEfetuarLogin;
        #endregion

        #region PDisponivel
        //Criação da constante que aponta a Procedure VerificarNomeUsuario e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pVerificarNome = ".VerificarNomeUsuario";
        public string GetPVerificarNome() => connection.GetDataBase() + pVerificarNome;
        #endregion

        #region PRetornarUsuario
        //Criação da constante que aponta a Procedure RetornarUsuario e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pRetornarUsuario = ".RetornarUsuario";
        public string GetPRetornarUsuario() => connection.GetDataBase() + pRetornarUsuario;
        #endregion

        #region PSolicitarAdmin
        //Criação da constante que aponta a Procedure SolicitarAdmin e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pSolicitarAdmin = ".SolicitarAdmin";
        public string GetPSolicitarAdmin() => connection.GetDataBase() + pSolicitarAdmin;
        #endregion

        #region PListarUsuários
        //Criação da constante que aponta a Procedure ListarUsuarios e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pListarUsuarios = ".ListarUsuarios";
        public string GetPListarUsuarios() => connection.GetDataBase() + pListarUsuarios;
        #endregion

        #region PListarPedidosExclusão
        //Criação da constante que aponta a Procedure ListarPedidosAdmin e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pListarPedidosAdmin = ".ListarPedidosAdmin";
        public string GetListarPedidosAdmin() => connection.GetDataBase() + pListarPedidosAdmin;
        #endregion

        #region PAprovarAdmin
        //Criação da constante que aponta a Procedure AprovarAdmin e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pAprovarAdmin = ".AprovarAdmin";
        public string GetAprovarAdmin() => connection.GetDataBase() + pAprovarAdmin;
        #endregion

        #region PRejeitarAdmin
        //Criação da constante que aponta a Procedure RejeitarAdmin e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pRejeitarAdmin = ".RejeitarAdmin";
        public string GetRejeitarAdmin() => connection.GetDataBase() + pRejeitarAdmin;
        #endregion

        #region ListarPedidosExclusao
        //Criação da constante que aponta a Procedure ListarPedidosExclusao e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pListarPedidosExclusao = ".ListarPedidosExclusao";
        public string GetListarPedidosExclusao() => connection.GetDataBase() + pListarPedidosExclusao;
        #endregion

        #region PDeletarUsuario
        //Criação da constante que aponta a Procedure DeletarUsuario e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pDeletarUsuario = ".DeletarUsuario";
        public string GetDeletarUsuario() => connection.GetDataBase() + pDeletarUsuario;
        #endregion

        #region PDeletarPedidoExclusao
        //Criação da constante que aponta a Procedure ApagarPedidoExclusao e metodo que retorna a string com a informação necessária para chamar a Procedure
        private const string pApagarPedidoExclusao = ".ApagarPedidoExclusao";
        public string GetApagarPedidoExclusao() => connection.GetDataBase() + pApagarPedidoExclusao;
        #endregion
    }
}