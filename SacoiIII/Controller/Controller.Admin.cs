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
    }
}
