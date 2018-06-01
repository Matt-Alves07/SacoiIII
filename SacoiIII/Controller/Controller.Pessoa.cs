using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SacoiIII.DAO;

namespace SacoiIII.Controller
{
    abstract class PessoaController
    {
        #region
        //Instância de objeto que será usado para acessar a camada model
        PessoaDAO PessoaDAO = new PessoaDAO();
        #endregion

        #region Insert Pessoa
        //Metodo responsável por atribuir os valores que vieram da camada view aos atributos do DTO e chamar os metodos necessários da camada DAO
        public string InsertPessoa(string _user_name, string _p_nome, string _s_nome, string _email, string _senha, string _cargo)
        {
            //Atribuição de valor nos atributos do DTO acessados pela camada DAO para realizar o insert no banco de dados posteriormente
            PessoaDAO.SetPessoa(_user_name, _p_nome, _s_nome, _email, _senha, _cargo);

            //Chamada do metodo que faz executa a Procedure Adicionar Usuario no banco de dados
            return PessoaDAO.InsertPessoa();
        }
        #endregion

        #region Efetuar Login
        //Metodo responsável por atribuir os valores que vieram da camada view aos atributos do DTO e chamar os metodos necessários da camada DAO
        public string[] EfetuarLogin(string _user_name, string _pass)
        {
            //Atribuição de valor aos atributos do DTO usados pela camada DAO para realizar o metodo de efetuar login posteriormente
            PessoaDAO.SetPessoa(_user_name, _pass);

            //Chamada do metodo que executa a Procedure Efetuar Login no banco de dados
            return PessoaDAO.EfetuarLogin();
        }
        #endregion

        #region Veriify User Name
        //Metodo responsável por atribuir o nome de usuário que veio da View para o atributo user_name do DTO e chamar os metodos necessários da camada DAO
        public Boolean VerificarNome(string _user_name)
        {
            //Atribuição de valor ao atributo user_name do DTO usado pela camada DAO para realizar o metodo de Verificar Disponibilidade
            PessoaDAO.SetPessoa(_user_name);

            //Chamada do metodo que executa a Procedure Verificar Nome usuario no banco de dados
            return PessoaDAO.VerificarDisponibilidade();
        }
        #endregion
    }
}
