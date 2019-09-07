using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingCart1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserCookie");
            cookie["UserName"] = unameText.Text;
            cookie["UserPassword"] = passwordTxt.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("ProductAdd.aspx");

        }
    }
}