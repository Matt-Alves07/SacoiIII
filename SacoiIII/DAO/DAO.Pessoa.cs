using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SacoiIII.Constants;
using SacoiIII.DTO;

namespace SacoiIII.DAO
{
    class PessoaDAO
    {
        #region Constants
        //Instânciação da Constante de Pessoas para leitura dos atributos presentes na Constatne
        ConnectionConstant ConstantConnection = new ConnectionConstant();
        PessoaConstant ConstantPessoa = new PessoaConstant();
        #endregion

        #region DTOs
        //Instânciação do DTO Pessoa para leitura e escrita dos atributos presentes no DTO
        PessoaDTO DTOPessoa = new PessoaDTO();
        #endregion

        #region MySQL Attributes
        //Criação e instânciação das variáveis de uso comum do MySQL
        string query = "";
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader reader;
        #endregion

        #region Sets
        //Metodo e seus overloads para inserir dados nos atributos do DTO
        public void SetPessoa(string _user_name) => DTOPessoa.user_name = _user_name;

        public void SetPessoa(string _user_name, string _pass)
        {
            DTOPessoa.user_name = _user_name;
            DTOPessoa.senha = _pass;
        }

        public void SetPessoa(string _user_name, string _p_nome, string _s_nome, string _email, string _pass, string _cargo)
        {
            DTOPessoa.user_name = _user_name;
            DTOPessoa.p_nome = _p_nome;
            DTOPessoa.s_nome = _s_nome;
            DTOPessoa.email = _email;
            DTOPessoa.senha = _pass;
            DTOPessoa.cargo = _cargo;
        }

        public void SetPessoa(string _pessoa, string _user_name, string _p_nome, string _s_nome, string _email, string _pass, string _cargo)
        {
            DTOPessoa.pessoa = _pessoa;
            DTOPessoa.user_name = _user_name;
            DTOPessoa.p_nome = _p_nome;
            DTOPessoa.s_nome = _s_nome;
            DTOPessoa.email = _email;
            DTOPessoa.senha = _pass;
            DTOPessoa.cargo = _cargo;
        }

        public void SetPessoa(string _pessoa, string _user_name, string _p_nome, string _s_nome, string _email, string _pass, string _cargo, string _admin)
        {
            DTOPessoa.pessoa = _pessoa;
            DTOPessoa.user_name = _user_name;
            DTOPessoa.p_nome = _p_nome;
            DTOPessoa.s_nome = _s_nome;
            DTOPessoa.email = _email;
            DTOPessoa.senha = _pass;
            DTOPessoa.cargo = _cargo;
            DTOPessoa.admin = _admin;
        }
        #endregion

        #region Insert
        //Metodo que usa os atributos do DTO e as constantes de conexão e pessoa para inserir um novo usuário no banco
        public string InsertPessoa()
        {
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetPAdicionarUsuario()}('{DTOPessoa.user_name}', '{DTOPessoa.p_nome}', '{DTOPessoa.s_nome}', '{DTOPessoa.email}', '{DTOPessoa.senha}', '{DTOPessoa.cargo}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database Access
            //Abertura da conexão ao MySQL e tentativa de chamada da procedure para inserir usuario
            try
            {
                //Tentatica de abertura da conexão ao banco de dados
                connection.Open();

                //Usa a variável reader para armazenar o resultado, se ela não ficar vazia, o insert foi feito com sucesso
                using (reader = command.ExecuteReader())
                {
                    if (reader == null)
                    {
                        return "falha";
                    }
                    else
                    {
                        return "sucesso";
                    }
                }
            }
            catch (Exception ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                throw new Exception(ex.ToString());
            }
            finally
            {
                //Encerramento da conexão ao banco de dados
                connection.Close();
            }
            #endregion
        }
        #endregion

        #region Login
        //Metodo que usa os atributos do DTO, os valores das constantes de conexão e pessoa e para efetuar login
        public string[] EfetuarLogin()
        {
            //Criação e inicialização do vetor que retorna o resultado da procedure do banco de dados
            string[] result = { "", "" };
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetPEfetuarLogin()}('{DTOPessoa.user_name}', '{DTOPessoa.senha}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão ao MySQL e tentativa de chamada da Procedure para efetuar login
            try
            {
                //Tentativa de abertura de conexão ao banco de dados
                connection.Open();

                //Efetua a chamada da Procedure e insere o retorno na variável reader
                using (reader = command.ExecuteReader())
                {
                    //Loopa a variavel reader para extrair as informações contidas nelas
                    while (reader.Read())
                    {
                        //Atribui os valores que vieram da Procedure EfetuarLogin que estavam na variável reader as posições do array que será retornado
                        result[0] = reader.GetString(0).ToLower();
                        result[1] = reader.GetString(1).ToLower();
                    }
                }

                //Retorno o array com os resultados da Procedure EfetuarLogin
                return result;
            }
            catch (Exception ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                throw new Exception(ex.ToString());
            }
            finally
            {
                //Encerra a conexão ao banco de dados
                connection.Close();
            }
            #endregion
        }
        #endregion

        #region Disponibility
        //Metodo que o atributo user_name do DTO, os valores das constantes de conexão e pessoa verificar se o nome de usuário já está cadastrado
        public Boolean VerificarDisponibilidade()
        {
            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetPVerificarNome()}('{DTOPessoa.user_name}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão com o MySQL e tentativa de chamada da Procedure para verificar a disponibilidade do nome de usuário
            try
            {
                //Abertura da conexão ao banco de dados
                connection.Open();

                //Efetua a consulta e atribui o resultado temporariamente na variavel de uso comum reader
                reader = command.ExecuteReader();

                //Loopa a variavel reader para buscar suas informações
                while (reader.Read())
                {
                    //Verifica qual foi o resultado da consulta existente em reader
                    if (reader.GetString(0).ToLower() == "usado")
                    {
                        //Informa que o nome de usuário já está em uso
                        return false;
                    }
                    else if (reader.GetString(0).ToLower() == "livre")
                    {
                        //Informa que o nome de usuário está disponível
                        return true;
                    }
                    else
                    {
                        //Lança uma exceção caso nenhuma das condições acima sejam satisfeitas
                        throw new Exception("O valor retornado não é aceito pelo sistema.");
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                //No caso de erro no MySQL, dispara uma exceção dizendo o que ocorreu
                throw new Exception(ex.ToString());
            }
            finally
            {
                //Encerra a conexão com o banco de dados
                connection.Close();
            }
            #endregion
        }
        #endregion
    }
}
