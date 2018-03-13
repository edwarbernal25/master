using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace master
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private String stringconexion = "Data source=localhost; uid=edwar;password=12345;database=login";



      

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void iniciar_Click(object sender, EventArgs e)
        {
            MySqlConnection Connection = new MySqlConnection(stringconexion);
            Connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = ("select *from usuarios where usuario='" + user.Text + "'and clave= '" + pass.Text + "';");
            MySqlDataReader leer = cmd.ExecuteReader();
            
            var nombres=leer.GetName(1);
            if (leer.Read())

            {
                string sql = "SELECT nombre FROM usuarios WHERE usuario=" +user.Text + "";
                
                cmd.ExecuteReader = new SqlCommand(sql, cnn);
                Response.Write("<script>alert('Bienvenido') </script>");
            }
            else
            {
                Response.Write("<script>alert('Datos incorrectos') </script>");
            }
        }
    }
}