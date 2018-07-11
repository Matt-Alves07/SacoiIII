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
    class NotificacaoDAO
    {
        #region Constants
        //Instânciação da Constante de Pessoas para leitura dos atributos presentes na Constatne
        ConnectionConstant ConstantConnection = new ConnectionConstant();
        NotificationConstant notificationconstant = new NotificationConstant();
        #endregion

        #region DTOs
        //Instânciação do DTO Notificação para leitura e escrita dos atributos presentes no DTO
        NotificacaoDTO DTONotificacao = new NotificacaoDTO();
        #endregion

        #region Error
        //Instância da classe de mensagens
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

        #region Sets
        //Metodo e seus overloads para inserir dados nos atributos do DTO
        public void SetNotificacao(string _notification) => DTONotificacao.notificacao = _notification;

        public void SetUsuario(string _user) => DTONotificacao.usuario = _user;

        public void SetNotificacao(string _user_name, string _texto)
        {
            DTONotificacao.user_name = _user_name;
            DTONotificacao.texto = _texto;
        }

        public void SetNotificacao(string _notification, string _user_name, string _texto)
        {
            DTONotificacao.notificacao = _notification;
            DTONotificacao.user_name = _user_name;
            DTONotificacao.texto = _texto;
        }

        public void SetNotificacao(string _notification, string _usuario, string _user_name, string _texto)
        {
            DTONotificacao.notificacao = _notification;
            DTONotificacao.usuario = _usuario;
            DTONotificacao.user_name = _user_name;
            DTONotificacao.texto = _texto;
        }

        public void SetNotificacao(string _notification, string _usuario, string _user_name, string _texto, string _valido)
        {
            DTONotificacao.notificacao = _notification;
            DTONotificacao.usuario = _usuario;
            DTONotificacao.user_name = _user_name;
            DTONotificacao.texto = _texto;
            DTONotificacao.valido = _valido;
        }
        #endregion

        #region InsertNotification
        //Metodo que usa os atributos do DTO e as constantes de conexão e pessoa para inserir uma nova notificação no banco de dados
        public string InsertNotification()
        {
            #region Local Atributtes
            string resultado = "";
            #endregion

            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {notificationconstant.GetPAdicionarNotificacao()}('{DTONotificacao.user_name}', '{DTONotificacao.texto}');";
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
                Error.SendError("Ocorreu um erro interno.\nCaso persista, entre em contato com o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
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

        #region Exibir Notificações
        //Metodo que usa os atributos do DTO e as constantes de conexão e notificação para exibir as notificações cadastradas e validas
        public List<NotificacaoDTO> ExibirNotificacoes()
        {
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {notificationconstant.GetPExibirNotificacoes()}();";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region
            //Criação da lista que será retornada com os valores vindos do banco
            List<NotificacaoDTO> notificacoes = new List<NotificacaoDTO>();
            notificacoes.Clear();
            #endregion

            #region Database Access
            //Abertura da conexão ao MySQL e tentativa de chamada da procedure para exibir notificações
            try
            {
                //Tentatica de abertura da conexão ao banco de dados
                connection.Open();

                //Usa a variável reader para armazenar o resultado, e em seguida preenche a lista com os registros vindos do banco
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            NotificacaoDTO notificacao = new NotificacaoDTO();
                            notificacao.user_name = reader.GetString(0);
                            notificacao.texto = reader.GetString(1);
                            notificacoes.Add(notificacao);
                        }
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
            //Retorna a lista de notificações para o local onde foi chamado
            return notificacoes;
            #endregion
        }
        #endregion

        #region Listar Notificações
        //Lista todas as mensagens cadastradas, indiferente de quem criou
        public List<NotificacaoDTO> GetNotificacoes()
        {
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {notificationconstant.GetPListarNotificacoes()}();";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region
            //Criação da lista que será retornada com os valores vindos do banco
            List<NotificacaoDTO> notificacoes = new List<NotificacaoDTO>();
            notificacoes.Clear();
            #endregion

            #region Database Access
            //Abertura da conexão ao MySQL e tentativa de chamada da procedure para exibir notificações
            try
            {
                //Tentatica de abertura da conexão ao banco de dados
                connection.Open();

                //Usa a variável reader para armazenar o resultado, e em seguida preenche a lista com os registros vindos do banco
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            NotificacaoDTO notificacao = new NotificacaoDTO();
                            notificacao.notificacao = reader.GetString(0);
                            notificacao.texto = reader.GetString(1);
                            notificacao.usuario = reader.GetString(2);
                            notificacao.user_name = reader.GetString(3);
                            notificacao.valido = reader.GetString(4);
                            notificacoes.Add(notificacao);
                        }
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
            //Retorna a lista de notificações para o local onde foi chamado se não estiver vazia
            return notificacoes;
            #endregion
        }
        #endregion

        #region Listar Notificações incluindo invalidas
        //Lista todas as notificações, inclusive invalidas, quando o check box está marcado na tela de listar todas as notificações
        public List<NotificacaoDTO> GetNotificacaosWithInvalidas()
        {
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {notificationconstant.GetPListarNotificacoesWithInvalidas()}();";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region
            //Criação da lista que será retornada com os valores vindos do banco
            List<NotificacaoDTO> notificacoes = new List<NotificacaoDTO>();
            notificacoes.Clear();
            #endregion

            #region Database Access
            //Abertura da conexão ao MySQL e tentativa de chamada da procedure para exibir notificações
            try
            {
                //Tentatica de abertura da conexão ao banco de dados
                connection.Open();

                //Usa a variável reader para armazenar o resultado, e em seguida preenche a lista com os registros vindos do banco
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            NotificacaoDTO notificacao = new NotificacaoDTO();
                            notificacao.notificacao = reader.GetString(0);
                            notificacao.texto = reader.GetString(1);
                            notificacao.usuario = reader.GetString(2);
                            notificacao.user_name = reader.GetString(3);
                            notificacao.valido = reader.GetString(4);
                            notificacoes.Add(notificacao);
                        }
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
            //Retorna a lista de notificações para o local onde foi chamado se não estiver vazia
            return notificacoes;
            #endregion
        }
        #endregion

        #region Invalidar Notificação
        //Invalida a notificação desejada e retira ela da listagem do home, caso ela esteja aparecendo
        public string InvalidarNotificacao()
        {
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {notificationconstant.GetPInvalidarNotificacao()}('{DTONotificacao.usuario}', '{DTONotificacao.notificacao}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database Access
            //Abertura da conexão ao MySQL e tentativa de chamada da procedure para exibir notificações
            try
            {
                //Tentatica de abertura da conexão ao banco de dados
                connection.Open();

                //Usa a variável reader para armazenar o resultado, e em seguida preenche a lista com os registros vindos do banco
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Verifica o numero do erro gerado, para saber se é uma mensagem personalizada ou se é erro do MySQL
                if (ex.Number.ToString() == "1644")
                {
                    Error.SendError(ex.Message.ToString(), "Erro");
                }
                else
                {
                    //Lança a mensagem informando o numero da exceção encontrada
                    Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
                }
            }
            finally
            {
                //Encerramento da conexão ao banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            //Retorna a lista de notificações para o local onde foi chamado se não estiver vazia
            return "";
            #endregion
        }
        #endregion

        #region Deletar Notificação
        //Deleta a notificação desejada após confirmação de exclusão
        public string DeletarNotificacao()
        {
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {notificationconstant.GetPDeletarNotificacao()}('{DTONotificacao.usuario}', '{DTONotificacao.notificacao}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database Access
            //Abertura da conexão ao MySQL e tentativa de chamada da procedure para exibir notificações
            try
            {
                //Tentatica de abertura da conexão ao banco de dados
                connection.Open();

                //Usa a variável reader para armazenar o resultado, e em seguida preenche a lista com os registros vindos do banco
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Verifica o numero do erro gerado, para saber se é uma mensagem personalizada ou se é erro do MySQL
                if (ex.Number.ToString() == "1644")
                {
                    Error.SendError(ex.Message.ToString(), "Erro");
                }
                else
                {
                    //Lança a mensagem informando o numero da exceção encontrada
                    Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
                }
            }
            finally
            {
                //Encerramento da conexão ao banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            //Retorna a lista de notificações para o local onde foi chamado se não estiver vazia
            return "";
            #endregion
        }
        #endregion

        #region Alterar Notificação
        //Executa a procedure de alterar notificação com os UUIDs de usuário e notificação e o texto da notificação
        public string AlterarNotificacao()
        {
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {notificationconstant.GetPAlterarNotificacao()}('{DTONotificacao.usuario}', '{DTONotificacao.notificacao}', '{DTONotificacao.texto}');";
            connection = new MySqlConnection(ConstantConnection.GetConnection());
            command = new MySqlCommand(query, connection);
            #endregion

            #region Database Access
            //Abertura da conexão ao MySQL e tentativa de chamada da procedure para exibir notificações
            try
            {
                //Tentatica de abertura da conexão ao banco de dados
                connection.Open();

                //Usa a variável reader para armazenar o resultado, e em seguida preenche a lista com os registros vindos do banco
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Verifica o numero do erro gerado, para saber se é uma mensagem personalizada ou se é erro do MySQL
                if (ex.Number.ToString() == "1644")
                {
                    Error.SendError(ex.Message.ToString(), "Erro");
                }
                else
                {
                    //Lança a mensagem informando o numero da exceção encontrada
                    Error.SendError("Ocorreu um erro interno.\nCaso persista, contate o suporte com o codigo: " + ex.Number.ToString(), "Erro interno");
                }
            }
            finally
            {
                //Encerramento da conexão ao banco de dados
                connection.Close();
            }
            #endregion

            #region Return
            //Retorna a lista de notificações para o local onde foi chamado se não estiver vazia
            return "";
            #endregion
        }
        #endregion
    }
}
