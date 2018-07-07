using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SacoiIII.DAO;
using SacoiIII.DTO;

namespace SacoiIII.Controller
{
    class NotificacoesController
    {
        #region NotificacoesDAO
        //Instância de objeto que será usado para acessar a camada model
        NotificacaoDAO Notificacao = new NotificacaoDAO();
        NotificacaoDTO NotificacaoDTO = new NotificacaoDTO();
        #endregion

        #region Insert Notificação
        //Metodo responsável por atribuir os valores que vieram da camada view aos atributos do DTO e chamar os metodos necessários da camada DAO
        public string InsertNotificacao(string _user_name, string _texto)
        {
            //Atribuição de valor nos atributos do DTO acessados pela camada DAO para realizar o insert no banco de dados posteriormente
            Notificacao.SetNotificacao(_user_name, _texto);

            //Chamada do metodo que executa a Procedure Adicionar Usuario no banco de dados
            return Notificacao.InsertNotification();
        }
        #endregion

        #region Exibir Notificação
        //Metodo responsável por retornar a lista de notificações preenchidas na camada view
        public List<NotificacaoDTO> ExibirNotificacoes()
        {
            return Notificacao.ExibirNotificacoes();
        }
        #endregion

        #region Listar Notificacao
        //Metodo responsável por retornar a lista completa de notificacoes preechidas na camada view
        public List<NotificacaoDTO> GetNotificacoes()
        {
            return Notificacao.GetNotificacoes();
        }
        #endregion

        #region Deletar Notificação
        public string DeleteNotificacao(string _notification, string _user)
        {
            //Atribui o UUID da notificação para ser usado posteriormente
            Notificacao.SetNotificacao(_notification);
            //Atribui o UUID do usuário para ser usado posteriormente
            Notificacao.SetUsuario(_user);

            //Retorna o resultado da execução do metodo DeletarNotificacao na camada DAO
            return Notificacao.DeletarNotificacao();
        }
        #endregion

        #region Invalidar Notificação
        public string InvalidateNotificacao(string _notification, string _user)
        {
            //Atribui o UUID da notificação para ser usado posteriormente
            Notificacao.SetNotificacao(_notification);
            //Atribui o UUID do usuário para ser usado posteriormente
            Notificacao.SetUsuario(_user);

            //Retorna o resultado da execução do metodo DeletarNotificacao na camada DAO
            return Notificacao.InvalidarNotificacao();
        }
        #endregion
    }
}
