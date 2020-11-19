using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A5_HiLo_Game
{
    public partial class HiloGame : System.Web.UI.Page
    {
        int savedMax = 0;
        int savedMin = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie max = Request.Cookies.Get("maxNum");
            //savedMax = (int)max.Value;
            HttpCookie username = Request.Cookies.Get("Username");
            Gamegreeting.InnerHtml = "Hello there " + username.Value + "! Please choose a number between "+ savedMax + " and " + savedMin + "!";
        }
    }
}