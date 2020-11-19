using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A5_HiLo_Game
{
    public partial class MaxNumGet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie username = Request.Cookies.Get("Username");
            greeting.InnerHtml = "Hello there " + username.Value + "! Please choose a max number greater than 1!";
        }

        protected void Enter1_Click(object sender, EventArgs e)
        {
            HttpCookie max = new HttpCookie("maxNum");
            HttpCookie min = new HttpCookie("minNum");
            max.Value = maxNum.Text;
            min.Value = "1";
            Response.Cookies.Add(max);
            Response.Cookies.Add(min);
            Response.Redirect("./HiloGame.aspx");
        }
    }
}