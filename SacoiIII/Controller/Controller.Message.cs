using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SacoiIII.DAO;
using SacoiIII.DTO;

namespace SacoiIII.Controller
{
    class MessageController
    {
        #region Local attributes
        MensagensDAO DAO = new MensagensDAO();
        #endregion

        #region Create Message
        public void CreateMessage(string sender, string receiver, string about, string text)
        {
            //Usa o set presente na camada DAO para atribuir os valores que vieram da camada View
            DAO.SetMessage(sender, receiver, about, text);
            //Usa o metodo que insere os dados vindo da camada View para realizar o processo de inserção no MySQL
            DAO.CreateMessage();
        }
        #endregion

        #region Return Message
        public MensagensDTO GetMensage(string message)
        {
            //Usa o set presente na camada DAO para atribuir o identificador vindo da camada View ao atributo do DTO
            DAO.SetMessage(message);
            //Usa o metodo que retorna os dados referentes a mensagem desejada para transmiti-los para a camada View
            return DAO.GetMensagem();
        }
        #endregion

        #region List Admin Messages
        public List<MensagensDTO> GetMensagensAdmin(string receiver)
        {
            //Usa o set presente na camada DAO para atribuir o nome de usuário vindo da camada view ao atributo do DTO
            DAO.SetReceiver(receiver);
            //Retorna a lista de mensagens enviadas ou recebidas pelo admin informado
            return DAO.GetMensagensAdmin();
        }
        #endregion

        #region List Users Messages
        public List<MensagensDTO> GetMensagensUsers(string receiver)
        {
            //Usa o set presente na camada DAO para atribuir o nome de usuário vindo da camada View ao atributo do DTO
            DAO.SetReceiver(receiver);
            //Retorna a lista de mensagens recebidas pelo usuário informado
            return DAO.GetMensagensUsers();
        }
        #endregion
    }
}