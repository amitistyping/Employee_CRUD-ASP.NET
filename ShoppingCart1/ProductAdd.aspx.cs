using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ShoppingCart1
{
    public partial class ProductAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserCookie"];
            User.Text = cookie["UserName"];
        }

        public string Get_fname()
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
            }
            else
            {
                Response.Write("Please, select a file.");
            }

            string fname = FileUpload1.FileName;
            return fname;
        }

        protected void save_Click(object sender, EventArgs e)
        {
            AddProduct();

        }

        public void AddProduct()
        {
            string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;           
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@prod_name", TextBox1.Text));
            parameters.Add(new SqlParameter("@prod_price", TextBox2.Text));
            parameters.Add(new SqlParameter("@prod_desc", TextBox3.Text));
            parameters.Add(new SqlParameter("@prod_sku", TextBox4.Text));
            parameters.Add(new SqlParameter("@prod_cat", Convert.ToInt32(DropDownList1.SelectedValue)));
            string fname = Get_fname();
            parameters.Add(new SqlParameter("@prod_fname", fname));
            SqlHelper.ExecuteNonQuery(connection, "Add_Prod", parameters.ToArray());
        }
    }

}