using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BlogInteractivo
{
    public static class ConnectionClass
    {
        private static SqlConnection connection;
        public static SqlConnection Connection
        {
            get { return GetConnection(); }
        }

        private static SqlConnection GetConnection()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                string cadenaconexion = "Data Source=URIBE_DELL;Initial Catalog=BLOG_INTERACTIVO;Integrated Security=True";
                connection = null;
                string respuesta = string.Empty;
                try
                {
                    connection = new SqlConnection(cadenaconexion);
                    connection.Open();
                }
                catch (Exception Ex)
                {
                    respuesta = Ex.Message;
                }
            }
            return connection;
        }

        public static void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch 
            {

            }
        }
    }
}