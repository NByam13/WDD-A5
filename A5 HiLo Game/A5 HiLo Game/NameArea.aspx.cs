using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A5_HiLo_Game
{
    public partial class NameArea : System.Web.UI.Page
    {

        /*
        Name	: Page_Load
        Purpose : Runs every time the page is refreshed
        Inputs	: sender-Where the function is called from
                  e- Information the user sends to the function
        Outputs	: NONE
        Returns	: Nothing
        */
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
        Name	: Enter1_Click
        Purpose : Runs every time the button is valid and its been pressed
        Inputs	: sender-Where the function is called from
                  e- Information the user sends to the function
        Outputs	: NONE
        Returns	: Nothing
        */
        protected void Enter1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("username");
            cookie.Value = Username.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("MaxNumGet.aspx");
        }

        /*
        Name	: Username_TextChanged
        Purpose : Sent here any time the text changes
        Inputs	: sender-Where the function is called from
                  e- Information the user sends to the function
        Outputs	: NONE
        Returns	: Nothing
        */
        protected void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}