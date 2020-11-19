using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A5_HiLo_Game
{
    public partial class NameArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("username");
            cookie.Value = Username.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("MaxNumGet.aspx");
        }

        protected void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}