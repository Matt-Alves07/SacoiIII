using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SacoiIII.DAO;
using SacoiIII.DTO;

namespace SacoiIII.Controller
{
    class AdminController: PessoaController
    {
        #region DAO & DTO
        //Instância de objeto que será usado para acessar a camada model(dao)
        PessoaDAO PessoaDAO = new PessoaDAO();
        //Instância de objeto que será usado para acessar a camada model(dto)
        PessoaDTO PessoaDTO = new PessoaDTO();
        #endregion

        #region User List
        //Metodo responsável por retornar a lista de usuários vindos da camada DAO para a camada View
        public List<PessoaDTO> ListarUsuarios()
        {
            //Chamada e retorno da lista de usuários vindos da camada DAO
            return PessoaDAO.ListarUsuarios();
        }
        #endregion

        #region Lista de Pedidos de Admin
        //Metodo responsável por retornar a lista de usuários vindos da camada DAO para a camada View
        public List<PessoaDTO> GetPedidosadmin()
        {
            //Chamada e retorno da lista de usuários vindos da camada DAO
            return PessoaDAO.ListarPedidosAdmin();
        }
        #endregion

        #region Aceitar pedido de admin
        //Metodo responsável por fazer as devidas alterações no cadasro do usuário para torná-lo administrador do sistema
        public string AprovarAdmin(string usuario)
        {
            //Chamada do metodo que atribui ao campo pessoa do DTO o identificador vindo da camada view
            PessoaDAO.SetID(usuario);

            //Chamada e retorno do resultado do metodo que acessa o banco e atualiza o registro tornando o usuário um administrador
            return PessoaDAO.AprovarAdmin();
        }
        #endregion

        #region Rejeitar pedido de admin
        //Metodo responsável por fazer as devidas exclusões para não exibir mais o pedido do mesmo de se tornar administrador
        public string RejeitarAdmin(string usuario)
        {
            //Chamada do metodo que atribui ao campo pessoa do DTO o identificador vindo da camada view
            PessoaDAO.SetID(usuario);

            //Chamada e retorno do resultado do metodo que acessa o banco e exclui o pedido de administrador do usuário selecionado
            return PessoaDAO.RejeitarAdmin();
        }
        #endregion

        #region Lista de Pedidos de Admin
        //Metodo responsável por retornar a lista de usuários vindos da camada DAO para a camada View
        public List<PessoaDTO> GetPedidosExclusao()
        {
            //Chamada e retorno da lista de usuários vindos da camada DAO
            return PessoaDAO.ListarPedidosExclusao();
        }
        #endregion

        #region DeletarUsuario
        //Metodo responsável por fazer as devidas exclusões para não exibir mais o pedido do mesmo de se tornar administrador
        public string DeletarUsuario(string usuario)
        {
            //Chamada do metodo que atribui ao campo pessoa do DTO o identificador vindo da camada view
            PessoaDAO.SetID(usuario);

            //Chamada e retorno do resultado do metodo que acessa o banco e exclui o pedido de administrador do usuário selecionado
            return PessoaDAO.DeletarUsuario();
        }
        #endregion

        #region Rejeitar pedido de exclusão
        //Metodo responsável por fazer as devidas exclusões para não exibir mais o pedido do mesmo de se tornar administrador
        public string DeletarPedidoExclusao(string usuario)
        {
            //Chamada do metodo que atribui ao campo pessoa do DTO o identificador vindo da camada view
            PessoaDAO.SetID(usuario);

            //Chamada e retorno do resultado do metodo que acessa o banco e exclui o pedido de administrador do usuário selecionado
            return PessoaDAO.ApagarPedidoExclusao();
        }
        #endregion
    }
}
