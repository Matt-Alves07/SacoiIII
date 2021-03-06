﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SacoiIII.DAO;
using SacoiIII.DTO;

namespace SacoiIII.Controller
{
    abstract class PessoaController
    {
        #region DAO & DTO
        //Instância de objeto que será usado para acessar a camada model(dao)
        PessoaDAO PessoaDAO = new PessoaDAO();
        //Instância de objeto que será usado para acessar a camada model(dto)
        PessoaDTO PessoaDTO = new PessoaDTO();
        #endregion

        #region Insert Pessoa
        //Metodo responsável por atribuir os valores que vieram da camada view aos atributos do DTO e chamar os metodos necessários da camada DAO
        public string InsertPessoa(string _user_name, string _p_nome, string _s_nome, string _email, string _senha, string _cargo)
        {
            //Atribuição de valor nos atributos do DTO acessados pela camada DAO para realizar o insert no banco de dados posteriormente
            PessoaDAO.SetPessoa(_user_name, _p_nome, _s_nome, _email, _senha, _cargo);

            //Chamada do metodo que executa a Procedure Adicionar Usuario no banco de dados
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
        public string VerificarNome(string _user_name)
        {
            //Atribuição de valor ao atributo user_name do DTO usado pela camada DAO para realizar o metodo de Verificar Disponibilidade
            PessoaDAO.SetPessoa(_user_name);

            //Chamada do metodo que executa a Procedure Verificar Nome usuario no banco de dados
            return PessoaDAO.VerificarDisponibilidade();
        }
        #endregion

        #region Return User
        //Metodo responsável por atribuir os valores que vieram da camada view aos atributos do DTO e chamar os metodos necessários da Camada DAO
        public PessoaDTO GetPessoa(string _user_name)
        {
            //Atribuição do nome de usuário para ser usado como parâmetro de pesquisa no MySQL e retornar os atributos do usuário desejado
            PessoaDAO.SetPessoa(_user_name);

            //Retorno do registro encontrado com o nome de usuário que foi informado
            return PessoaDAO.RetornaPessoa();
        }
        #endregion

        #region Solicitar Exclusao
        //Metodo responsável por atribuir o valor que veio da camada view ao atriburo do DTO e chamar os metodos necessários da camada DAO
        public string SolicitarExclusao(string _user_name)
        {
            //Atribuição de valor ao atributo User Name do DTO usado pela camada DAO para realizar o pedido de exclusão posteriormente
            PessoaDAO.SetPessoa(_user_name);

            //Chamada do metodo que executa a Procedure Solicitar Exclusão no banco de dados
            return PessoaDAO.SolicitarExclusao();
        }
        #endregion

        #region Update User
        //Criação do metodo Controller para atribuir os valores dos seus parâmetros na DAO e execução do metodo AlterarUsuario da DAO
        public string UpdateUser(string _pessoa, string _p_nome, string _s_nome, string _email, string _cargo, string _senha)
        {
            //Atribui o valor dos parâmetros ao atributos do DTO, acessado pela camada DAO
            PessoaDAO.SetPessoa(_pessoa, "", _p_nome, _s_nome, _email, _senha, _cargo);

            //Retorna o resultado encontrado na execução do metodo da DAO para a camada view
            return PessoaDAO.AlterarUsuario();
        }
        #endregion
    }
}