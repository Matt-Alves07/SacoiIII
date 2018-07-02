using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacoiIII.DTO
{
    class NotificacaoDTO
    {
        public string notificacao { get; set; }
        public string texto { get; set; }
        public string usuario { get; set; }
        public string user_name { get; set; }
        public string valido { get; set; }
        public string criacao { get; set; }

        public override bool Equals(object obj)
        {
            var dTO = obj as NotificacaoDTO;
            return dTO != null &&
                   notificacao == dTO.notificacao &&
                   texto == dTO.texto &&
                   usuario == dTO.usuario &&
                   user_name == dTO.user_name &&
                   valido == dTO.valido &&
                   criacao == dTO.criacao;
        }
    }
}
