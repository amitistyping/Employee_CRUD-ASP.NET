using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;

namespace ShoppingCart1
{
    public partial class DispProd : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindProdGrid();
        }

        public void BindProdGrid()
        {
            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM prod_table", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            GridProd.DataSource = dataSet;
            GridProd.DataBind();
        }


    }
}