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
    class MensagensDAO
    {
        #region Class instances
        MensagensDTO DTO = new MensagensDTO();
        MessagesConstants Messages = new MessagesConstants();
        ConnectionConstant Connection = new ConnectionConstant();
        Error Error = new Error();
        #endregion

        #region MySQL Attributes
        //Criação e instânciação das variáveis de uso comum do MySQL
        string query = "";
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader reader;
        #endregion

        #region Set Message
        public void SetMessage(string message) => DTO.mensagem = message;

        public void SetReceiver(string receiver) => DTO.user_receiver = receiver;

        public void SetMessage(string sender, string receiver, string about, string texto)
        {
            DTO.user_receiver = receiver;
            DTO.user_sender = sender;
            DTO.assunto = about;
            DTO.texto = texto;
        }

        public void SetMessage(string sender, string receiver, string about, string texto, string criacao)
        {
            DTO.user_receiver = receiver;
            DTO.user_sender = sender;
            DTO.assunto = about;
            DTO.texto = texto;
            DTO.criacao = criacao;
        }

        public void SetMessage(string message, string sender, string receiver, string about, string texto, string criacao)
        {
            DTO.mensagem = message;
            DTO.user_receiver = receiver;
            DTO.user_sender = sender;
            DTO.assunto = about;
            DTO.texto = texto;
            DTO.criacao = criacao;
        }
        #endregion

        #region Creat Message
        public void CreateMessage()
        {
            //atribuição dos valores necessários nas variáveis de origem do MySQL
            #region Change MySQL Attributes
            query = $"CALL {Messages.GetPAdicionarMensagem()}('{DTO.user_sender}', '{DTO.user_receiver}', '{DTO.assunto}', '{DTO.texto}');";
            connection = new MySqlConnection(Connection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database Access
            //Tentativa de inserção dos dados no banco
            try
            {
                //Inicia a comunicação com o  MySQL
                connection.Open();

                //Tenta executar a query e retorna uma string como resultado
                using (reader = command.ExecuteReader())
                {
                    if (reader == null)
                    {
                        //Caso não tenha inserido, retorna uma mensagem de falha
                        Error.SendAttention("Ocorreu um erro ao enviar a mensagem.\nCaso persista, entre em contato com o suporte", "Erro");
                    }
                    else
                    {
                        //Case tenha inserido, retorna uma mensagem de sucesso
                        Error.SendOK("Mensagem enviada com sucesso.\nQuando este usuário acessar a lista de mensagens ela será exibida para ele.", "Enviado");
                    }
                }
            }
            catch (Exception ex)
            {
                //Caso seja gerada alguma exceção, joga ela na tela do usuario
                Error.SendError(ex.ToString(), "Exceção Interna");
            }
            finally
            {
                //Encerra a comunicação com o MySQL
                connection.Close();
            }
            #endregion
        }
        #endregion

        #region Return Message
        public MensagensDTO GetMensagem()
        {
            #region Change MySQL Attributes
            //atribuição dos valores necessários nas variáveis de origem do MySQL
            query = $"CALL {Messages.GetPRetornarMensagem()}('{DTO.mensagem}');";
            connection = new MySqlConnection(Connection.GetConnection());
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
                        DTO.user_sender = reader.GetString(0);
                        DTO.assunto = reader.GetString(1);
                        DTO.texto = reader.GetString(2);
                    }
                }

                return DTO;
            }
            catch (Exception ex)
            {
                //No caso de erro no MySQL, dispara uma exceção dizendo o que ocorreu
                Error.SendError("Ocorreu um erro interno.\nCaso persista, entre em contato com o suporte.\nInformação sobre o erro: " + ex.ToString(), "Erro Interno");
                return null;
            }
            finally
            {
                //Encerra a conexão com o banco de dados
                connection.Close();
            }
            #endregion
        }
        #endregion

        #region List Admin Messages
        public List<MensagensDTO> GetMensagensAdmin()
        {
            #region Change MySQL Attributes
            //atribuição dos valores necessários nas variáveis de origem do MySQL
            query = $"CALL {Messages.GetPVisualizarMensagemAdmin()}('{DTO.user_receiver}');";
            connection = new MySqlConnection(Connection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region List Creation
            //Cria a lista que será retornada
            List<MensagensDTO> list = new List<MensagensDTO>();
            //Limpa qualquer lixo de memória que possa haver na lista
            list.Clear();
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
                        //Instância o DTO de mensagen para preencher com os valores que estão vindo do banco para adicionar a lista depois
                        MensagensDTO mensagens = new MensagensDTO();
                        //Atribui os valores que vieram do banco a instância criada
                        mensagens.mensagem = reader.GetString(0);
                        mensagens.user_sender = reader.GetString(1);
                        mensagens.assunto = reader.GetString(2);
                        mensagens.texto = reader.GetString(3);
                        //Adiciona a instância criada a lista que será retornada depois
                        list.Add(mensagens);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                //No caso de erro no MySQL, dispara uma exceção dizendo o que ocorreu
                Error.SendError("Ocorreu um erro interno.\nCaso persista, entre em contato com o suporte.\nInformação sobre o erro: " + ex.ToString(), "Erro Interno");
                return null;
            }
            finally
            {
                //Encerra a conexão com o banco de dados
                connection.Close();
            }
            #endregion
        }
        #endregion

        #region List User Messages
        public List<MensagensDTO> GetMensagensUsers()
        {
            //atribuição dos valores necessários nas variáveis de origem do MySQL
            #region Change MySQL Attributes
            query = $"CALL {Messages.GetPVisualizarMensagemUsuario()}('{DTO.user_receiver}');";
            connection = new MySqlConnection(Connection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region List Creation
            //Cria a lista que será retornada
            List<MensagensDTO> list = new List<MensagensDTO>();
            //Limpa qualquer lixo de memória que possa haver na lista
            list.Clear();
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
                        //Instância o DTO de mensagen para preencher com os valores que estão vindo do banco para adicionar a lista depois
                        MensagensDTO mensagens = new MensagensDTO();
                        //Atribui os valores que vieram do banco a instância criada
                        mensagens.mensagem = reader.GetString(0);
                        mensagens.user_sender = reader.GetString(1);
                        mensagens.assunto = reader.GetString(2);
                        mensagens.texto = reader.GetString(3);
                        //Adiciona a instância criada a lista que será retornada depois
                        list.Add(mensagens);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                //No caso de erro no MySQL, dispara uma exceção dizendo o que ocorreu
                Error.SendError("Ocorreu um erro interno.\nCaso persista, entre em contato com o suporte.\nInformação sobre o erro: " + ex.ToString(), "Erro Interno");
                return null;
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