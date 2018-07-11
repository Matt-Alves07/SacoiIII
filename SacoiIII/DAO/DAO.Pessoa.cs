using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SacoiIII.Constants;
using SacoiIII.DTO;
using SacoiIII.Misc;

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

        #region Error
        private Error Error = new Error();
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
        public void SetID(string _pessoa) => DTOPessoa.pessoa = _pessoa;

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
            #region Local Atributtes
            string resultado = "";
            #endregion

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
                        resultado = "falha";
                    }
                    else
                    {
                        resultado = "sucesso";
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerramento da conexão ao banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            return resultado;
            #endregion
        }
        #endregion

        #region Login
        //Metodo que usa os atributos do DTO, os valores das constantes de conexão e pessoa para efetuar login
        public string[] EfetuarLogin()
        {
            #region Local Atributtes
            //Criação e inicialização do vetor que retorna o resultado da procedure do banco de dados
            string[] result = { "", "" };
            #endregion

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
            }
            catch (MySqlException ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                Error.SendError("Ocorreu um erro.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro Interno");
            }
            finally
            {
                //Encerra a conexão ao banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            //Retorno o array com os resultados da Procedure EfetuarLogin
            return result;
            #endregion
        }
        #endregion

        #region Disponibility
        //Metodo que usa o atributo user_name do DTO, os valores das constantes de conexão e pessoa para verificar se o nome de usuário já está cadastrado
        public string VerificarDisponibilidade()
        {
            #region Local Atributtes
            string result = "";
            #endregion

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
                    //usado == significa que já existe um usuário com esse nome de usuário
                    //livre == significa que não existe registro desse nome de usuário no sistema
                    //Se vier vazia, ocorreu 
                    if (reader.GetString(0).ToLower() != "")
                    {
                        if (reader.GetString(0).ToLower() == "usado")
                        {
                            result = reader.GetString(0).ToLower();
                        }
                        else if (reader.GetString(0).ToLower() == "livre")
                        {
                            result = reader.GetString(0).ToLower();
                        }
                        else
                        {
                            Error.SendAttention("O valor retornado não é aceito pelo sistema.\nCaso persista, contate o suporte.", "Entrada invalida");
                        }
                    }
                    else
                    {
                        Error.SendAttention("O valor retornado não é aceito pelo sistema.\nCaso persista, contate o suporte.", "Entrada invalida");
                    }
                }
            }
            catch (MySqlException ex)
            {
                //No caso de erro no MySQL, dispara uma exceção dizendo o que ocorreu
                Error.SendError("Ocorreu um erro interno.\nCaso perista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão com o banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            return result;
            #endregion
        }
        #endregion

        #region Solicitar Admin
        //Metodo que usa o atributo user_name do DTO e as constants de pessoa e conexão para acessar o banco e realizar o pedido de admin para usuários
        public string SolicitarAdmin()
        {
            #region Local Attributes
            string situacao = "";
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetPSolicitarAdmin()}('{DTOPessoa.user_name}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão com o MySQL e tentativa de chamada da Procedure para verificar a disponibilidade do nome de usuário
            try
            {
                //Abertura da conexão ao banco de dados
                connection.Open();

                //Faz a consulta a Procedure no banco e atribui os valores aos atributos do DTO
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        situacao = reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //No caso de erro no MySQL, dispara uma exceção dizendo o que ocorreu
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão com o banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            return situacao;
            #endregion
        }
        #endregion

        #region Return User
        //Metodo que usa o atributo user_name do DTO e as constants de pessoa e conexão para retornar um registro que será usado para preencher um DTO completo
        public PessoaDTO RetornaPessoa()
        {
            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetPRetornarUsuario()}('{DTOPessoa.user_name}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão com o MySQL e tentativa de chamada da Procedure para verificar a disponibilidade do nome de usuário
            try
            {
                //Abertura da conexão ao banco de dados
                connection.Open();

                //Faz a consulta a Procedure no banco e atribui os valores aos atributos do DTO
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DTOPessoa.pessoa = reader.GetString(0);
                        DTOPessoa.user_name = reader.GetString(1);
                        DTOPessoa.p_nome = reader.GetString(2);
                        DTOPessoa.s_nome = reader.GetString(3);
                        DTOPessoa.email = reader.GetString(4);
                        DTOPessoa.senha = reader.GetString(5);
                        DTOPessoa.cargo = reader.GetString(6);
                        DTOPessoa.admin = reader.GetString(7);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //No caso de erro no MySQL, dispara uma exceção dizendo o que ocorreu
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão com o banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            return DTOPessoa;
            #endregion
        }
        #endregion

        #region User List
        //Criação do metodo que usa as constantes de conexão e de pessoa para chamar a procedure que lista todos os usuários e retorna um lista de DTOs
        public List<PessoaDTO> ListarUsuarios()
        {
            #region Local Attributes
            //Criação dos metodos locais responsáveis por receber a lista que será retornada
            List<PessoaDTO> lista = new List<PessoaDTO>();

            //Limpa a lista para evitar lixo de memória na lista
            lista.Clear();
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetPListarUsuarios()}();";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão com o MySQL e tentativa de chamada da Procedure para listar todos os usuários
            try
            {
                //Abre a conexão ao MySQL
                connection.Open();

                //Usa a variável temporária para armazenar o resultado da query e que será atribuído depois na lista
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            //Instância do DTO Pessoa para atribuição dos valores resultantes da query
                            PessoaDTO pessoa = new PessoaDTO();

                            //Atribuição dos valores resultantes da query aos atributos do DTO Pessoa
                            pessoa.pessoa = reader.GetString(0);
                            pessoa.user_name = reader.GetString(1);
                            pessoa.p_nome = reader.GetString(2);
                            pessoa.s_nome = reader.GetString(3);
                            pessoa.email = reader.GetString(4);
                            pessoa.cargo = reader.GetString(5);
                            pessoa.admin = reader.GetString(6);

                            //Inclusão do DTO Pessoa preenchido a lista que será retornada posteriormente
                            lista.Add(pessoa);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro Interno");
            }
            finally
            {
                connection.Clone();
            }
            #endregion

            #region Return
            //Retorna a lista com todos os usuários registrados
            return lista;
            #endregion
        }
        #endregion

        #region Listar Pedidos Admin
        //Criação do metodo que usa as constantes de conexão e de pessoa para chamar a procedure que lista todos os usuários e retorna um lista de DTOs
        public List<PessoaDTO> ListarPedidosAdmin()
        {
            #region Local Attributes
            //Criação dos metodos locais responsáveis por receber a lista que será retornada
            List<PessoaDTO> lista = new List<PessoaDTO>();

            //Limpa a lista para evitar lixo de memória na lista
            lista.Clear();
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetListarPedidosAdmin()}();";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão com o MySQL e tentativa de chamada da Procedure para listar todos os usuários
            try
            {
                //Abre a conexão ao MySQL
                connection.Open();

                //Usa a variável temporária para armazenar o resultado da query e que será atribuído depois na lista
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            //Instância do DTO Pessoa para atribuição dos valores resultantes da query
                            PessoaDTO pessoa = new PessoaDTO();

                            //Atribuição dos valores resultantes da query aos atributos do DTO Pessoa
                            pessoa.pessoa = reader.GetString(0);
                            pessoa.user_name = reader.GetString(1);
                            pessoa.pedido = reader.GetString(2);
                            pessoa.data_pedido = reader.GetString(3);

                            //Inclusão do DTO Pessoa preenchido a lista que será retornada posteriormente
                            lista.Add(pessoa);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                connection.Clone();
            }
            #endregion

            #region Return
            //Retorna a lista com todos os usuários registrados
            return lista;
            #endregion
        }
        #endregion

        #region AprovarAdmin
        public string AprovarAdmin()
        {
            #region Local atributtes
            //Criação da string que irá armazenar temporariamente o resultado da query no banco
            string resultado = "";
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetAprovarAdmin()}('{DTOPessoa.pessoa}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão ao MySQL e armazenagem do resultado da procedure AprovarAdmin
            try
            {
                //Abre a conexão com o banco do MySQL
                connection.Open();

                //Efetua a chamada da procedure no banco e atribui o resultado ao reader
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultado = reader.GetString(0);
                    }
                }
            }
            catch(MySqlException ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codugo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão aberta ao MySQL
                connection.Close();
            }
            #endregion

            #region Return
            //retorno do resultado da execução da query no banco
            return resultado;
            #endregion
        }
        #endregion

        #region RejeitarAdmin
        public string RejeitarAdmin()
        {
            #region Local atributtes
            //Criação da string que irá armazenar temporariamente o resultado da query no banco
            string resultado = "";
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetRejeitarAdmin()}('{DTOPessoa.pessoa}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão ao MySQL e armazenagem do resultado da procedure AprovarAdmin
            try
            {
                //Abre a conexão com o banco do MySQL
                connection.Open();

                //Efetua a chamada da procedure no banco e atribui o resultado ao reader
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultado = reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão aberta ao MySQL
                connection.Close();
            }
            #endregion

            #region Return
            //retorno do resultado da execução da query no banco
            return resultado;
            #endregion
        }
        #endregion

        #region Solicitar Exclusao
        //Metodo que usa o atributo user_name do DTO e as constants de pessoa e conexão para acessar o banco e realizar o pedido de admin para usuários
        public string SolicitarExclusao()
        {
            #region Local Attributes
            string situacao = "";
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetPSolicitarExclusao()}('{DTOPessoa.user_name}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão com o MySQL e tentativa de chamada da Procedure para verificar a disponibilidade do nome de usuário
            try
            {
                //Abertura da conexão ao banco de dados
                connection.Open();

                //Faz a consulta a Procedure no banco e atribui os valores aos atributos do DTO
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        situacao = reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //No caso de erro no MySQL, dispara uma exceção dizendo o que ocorreu
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão com o banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            //Retorna a string com o resultada da operação
            return situacao;
            #endregion
        }
        #endregion

        #region ApagarPedidoExclusao
        public string ApagarPedidoExclusao()
        {
            #region Local atributtes
            //Criação da string que irá armazenar temporariamente o resultado da query no banco
            string resultado = "";
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetApagarPedidoExclusao()}('{DTOPessoa.pessoa}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão ao MySQL e armazenagem do resultado da procedure AprovarAdmin
            try
            {
                //Abre a conexão com o banco do MySQL
                connection.Open();

                //Efetua a chamada da procedure no banco e atribui o resultado ao reader
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultado = reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                 Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão aberta ao MySQL
                connection.Close();
            }
            #endregion

            #region Return
            return resultado;
            #endregion
        }
        #endregion

        #region Listar Pedidos Exclusão
        //Criação do metodo que usa as constantes de conexão e de pessoa para chamar a procedure que lista todos os usuários e retorna um lista de DTOs
        public List<PessoaDTO> ListarPedidosExclusao()
        {
            #region Local Attributes
            //Criação dos metodos locais responsáveis por receber a lista que será retornada
            List<PessoaDTO> lista = new List<PessoaDTO>();

            //Limpa a lista para evitar lixo de memória na lista
            lista.Clear();
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetListarPedidosExclusao()}();";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão com o MySQL e tentativa de chamada da Procedure para listar todos os usuários
            try
            {
                //Abre a conexão ao MySQL
                connection.Open();

                //Usa a variável temporária para armazenar o resultado da query e que será atribuído depois na lista
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                        {
                            //Instância do DTO Pessoa para atribuição dos valores resultantes da query
                            PessoaDTO pessoa = new PessoaDTO();

                            //Atribuição dos valores resultantes da query aos atributos do DTO Pessoa
                            pessoa.pessoa = reader.GetString(0);
                            pessoa.user_name = reader.GetString(1);
                            pessoa.pedido = reader.GetString(2);
                            pessoa.data_pedido = reader.GetString(3);

                            //Inclusão do DTO Pessoa preenchido a lista que será retornada posteriormente
                            lista.Add(pessoa);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                connection.Clone();
            }
            #endregion

            #region Return
            //Retorna a lista com todos os usuários registrados
            return lista;
            #endregion
        }
        #endregion

        #region Deletar Usuario
        public string DeletarUsuario()
        {
            #region Local atributtes
            //Criação da string que irá armazenar temporariamente o resultado da query no banco
            string resultado = "";
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetDeletarUsuario()}('{DTOPessoa.pessoa}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão ao MySQL e armazenagem do resultado da procedure AprovarAdmin
            try
            {
                //Abre a conexão com o banco do MySQL
                connection.Open();

                //Efetua a chamada da procedure no banco e atribui o resultado ao reader
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultado = reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão aberta ao MySQL
                connection.Close();
            }
            #endregion

            #region Return
            //retorno do resultado da execução da query no banco
            return resultado;
            #endregion
        }
        #endregion

        #region Apagar Pedido Exclusão
        public string RejeitarPedidoExclusao()
        {
            #region Local atributtes
            //Criação da string que irá armazenar temporariamente o resultado da query no banco
            string resultado = "";
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetApagarPedidoExclusao()}('{DTOPessoa.pessoa}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão ao MySQL e armazenagem do resultado da procedure AprovarAdmin
            try
            {
                //Abre a conexão com o banco do MySQL
                connection.Open();

                //Efetua a chamada da procedure no banco e atribui o resultado ao reader
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultado = reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão aberta ao MySQL
                connection.Close();
            }
            #endregion

            #region Return
            //retorno do resultado da execução da query no banco
            return resultado;
            #endregion
        }
        #endregion

        #region Alterar Usuario
        //Metodo encarregado por chamar a procedure responsável por alterar o cadastro do usuário
        public string AlterarUsuario()
        {
            #region Local atributtes
            //Criação da string que irá armazenar temporariamente o resultado da query no banco
            string resultado = "";
            #endregion

            #region Change attributes values
            //atribuição dos valores que serão usados nesse metodo nas variaveis de uso comum da classe
            query = $"CALL {ConstantPessoa.GetAlterarUsuario()}('{DTOPessoa.pessoa}', '{DTOPessoa.p_nome}', '{DTOPessoa.s_nome}', '{DTOPessoa.email}', '{DTOPessoa.senha}', '{DTOPessoa.cargo}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database access
            //Abertura da conexão ao MySQL e armazenagem do resultado da procedure AprovarAdmin
            try
            {
                //Abre a conexão com o banco do MySQL
                connection.Open();

                //Efetua a chamada da procedure no banco e atribui o resultado ao reader
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultado = reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Lança uma exceção, caso seja gerada alguma
                Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
            }
            finally
            {
                //Encerra a conexão aberta ao MySQL
                connection.Close();
            }
            #endregion

            #region Return
            //Retorna o resultado da execução do metodo
            return resultado;
            #endregion
        }
        #endregion
    }
}