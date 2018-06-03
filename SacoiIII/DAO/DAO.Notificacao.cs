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
        public void SetNotificacao(string _user_name, string _texto)
        {
            DTONotificacao.user_name = _user_name;
            DTONotificacao.texto = _texto;
        }
        #endregion

        #region InsertNotification
        //Metodo que usa os atributos do DTO e as constantes de conexão e pessoa para inserir uma nova notificação no banco de dados
        public string InsertNotification()
        {
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

        #region
        //Metodo que usa os atributos do DTO e as constantes de conexão e notificação para exibir as notificações cadastradas e validas
        public List<NotificacaoDTO> ExibirNotificacoes()
        {
            #region Change attributes values
            //Atribuição dos valores que serão usados nesse metodo nas variáveis de uso comum da classe
            query = $"CALL {notificationconstant.GetPExibirNotificacoes()};";
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
                        NotificacaoDTO notificacao = new NotificacaoDTO();
                        notificacao.user_name = reader.GetString(0);
                        notificacao.texto = reader.GetString(1);
                        notificacoes.Add(notificacao);
                    }
                }

                //Retorna a lista de notificações para o local onde foi chamado
                return notificacoes;
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
    }
}
