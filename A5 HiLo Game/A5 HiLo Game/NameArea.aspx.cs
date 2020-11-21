//*********************************************
// File			 : NameArea.aspx.cs
// Project		 : A5 - HiLo in ASP.NET
// Programmer	 : Nick Byam, Nikola Ristic
// Last Change   : 2020-11-20
// Description	 : Code behind for the NameArea page which gives event handlers instruction on what to do when a button is clicked
//               : and when the page loads.
//*********************************************


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
            //create cookie
            HttpCookie cookie = new HttpCookie("username");
            //place valid name in the cookie
            cookie.Value = Username.Text;
            //add to the rest of the cookies
            Response.Cookies.Add(cookie);
            //redirect to next page
            Response.Redirect("MaxNumGet.aspx");
        }
    }
}