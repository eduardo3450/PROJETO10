using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace projeto10.Dados1
{
    public class Conexao1
    {
        MySqlConnection cn = new MySqlConnection("Server=localhost; DataBase=BD; User=root 3306;pwd=141184");
        public static string msg;

        public MySqlConnection MyConectarBD() //Metodo: MyConectarBD()
        {
            try
            {
                cn.Open();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;
        }

        public MySqlConnection MyDesConectarBD() //Metodo: MyDesConectarBD()
        {
            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;
        }
    }
}