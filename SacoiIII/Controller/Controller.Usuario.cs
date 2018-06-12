using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SacoiIII.DAO;

namespace SacoiIII.Controller
{
    class UsuarioController : PessoaController
    {
        #region
        //Instância de objeto que será usado para acessar a camada model
        PessoaDAO PessoaDAO = new PessoaDAO();
        #endregion

        #region Solicitar Admin
        //Metodo responsável por fazer a atribuição dos valores que vieram da camada View para os atributos necessários e 
        //chama o metodo necessário na camada DAO
        public string SolicitarAdmin(string _user_name)
        {
            //Chamada do metodo que preenche o nome de usuário no DTO
            PessoaDAO.SetPessoa(_user_name);

            //Chamada e retorno do metodo que cuida do acesso ao banco para solicitar a mudança de perfil
            return PessoaDAO.SolicitarAdmin();
        }
        #endregion
    }
}
