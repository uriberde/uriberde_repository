using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BlogInteractivo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();

            try
            {
                string sqlCommand = "SELECT * FROM USER_ROLE AS USER_ROLE";
                SqlCommand sqlCom = new SqlCommand(sqlCommand, ConnectionClass.Connection);
                SqlDataAdapter da = null;
                da = new SqlDataAdapter(sqlCom);
                da.Fill(ds.USER_ROLE);
            }
            catch
            {
            }
            finally
            {
                ConnectionClass.CloseConnection();
            }
        }
    }
}
