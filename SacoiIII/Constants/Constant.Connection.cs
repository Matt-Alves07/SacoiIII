using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacoiIII.Constants
{
    class ConnectionConstant
    {
        #region Connection
        //Criação da constante que fornece os dados para acessar o MySQL
        private const string connection = "datasource=localhost;port=3306;user=root;password=M1nh@S3nh@";
        //Criação do metodo que retorna a constante de conexão
        public string GetConnection() => connection;
        #endregion

        #region Database
        //Criação da constante que diz qual o banco a ser acessado
        private const string database = "sacoi";
        //Criação do metodo que retorna o nome do banco a ser acessado
        public string GetDataBase() => database;
        #endregion
    }
}
