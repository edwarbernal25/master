using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;


namespace master
{
    public class Conexion
    {
        private static string stringConnection = ConfigurationManager.ConnectionStrings["ConexionAsesores"].ConnectionString;

        public MySqlConnection ConexionMySQL()
        {
            MySqlConnection Connection = new MySqlConnection("server=127.0.01; database=login; Uid=edwar; pwd=12345;");

            try
            {
                Connection.Open();
            }
            catch (Exception exc)
            {
                throw new Exception("No se realizó la conexión a la base de pameters: " + exc.Message);
            }

            return Connection;
        }

        
        }
    }
