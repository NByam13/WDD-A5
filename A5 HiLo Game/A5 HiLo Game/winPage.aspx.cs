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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}