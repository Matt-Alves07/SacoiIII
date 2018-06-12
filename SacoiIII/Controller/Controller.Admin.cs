using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SacoiIII.DAO;

namespace SacoiIII.Controller
{
    class AdminController: PessoaController
    {
        #region
        //Instância de objeto que será usado para acessar a camada model
        PessoaDAO PessoaDAO = new PessoaDAO();
        #endregion

        
    }
}
