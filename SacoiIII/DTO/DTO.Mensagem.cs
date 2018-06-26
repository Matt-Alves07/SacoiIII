using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacoiIII.DTO
{
    class MensagensDTO
    {
        public string mensagem { get; set; }
        public string user_receiver { get; set; }
        public string user_sender { get; set; }
        public string assunto { get; set; }
        public string texto { get; set; }
        public string criacao { get; set; }
    }
}