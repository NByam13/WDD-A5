using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A5_HiLo_Game
{
    public partial class winPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            winGreeting.InnerHtml = "Congratulations! You won!";

        }

        protected void replay_Click(object sender, EventArgs e)
        {
            // reset all cookies
            foreach(HttpCookie cookie in Response.Cookies)
            {
                if(cookie.Name != "username")
                {
                    cookie.Value = "";
                }
            }

            Response.Redirect("./MaxNumGet.aspx");
        }
    }
}