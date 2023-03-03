using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace psn
{
    public class cls_banco
    {
        private string _host = "localhost";
        private string _user = "root";
        private string _password= "Pedrobanco00123";
        private string _database = "psn";

        MySqlConnection conexao = null;

        public bool connect()
        {
            conexao = new MySqlConnection("server=" + _host + ";user=" + _user + ";password=" + _password + ";database=" + _database + "");
            try
            {
                conexao.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}