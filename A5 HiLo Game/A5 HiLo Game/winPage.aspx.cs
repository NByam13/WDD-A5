//*********************************************
// File			 : winPage.aspx.cs
// Project		 : A5 - HiLo in ASP.NET
// Programmer	 : Nick Byam, Nikola Ristic
// Last Change   : 2020-11-21
// Description	 : The code behind for the landing page that the user gets to when they win. The code behind handles the clearing
//				 : of cookies so that if the user chooses to play again instead of exiting, the max and min will be reset, as well as the
//               : the random number. The name however is not reset.
//*********************************************


using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A5_HiLo_Game
{
    public partial class winPage : System.Web.UI.Page
    {

        /////////////////////////////////////////
        // Method       : Page_Load
        // Description  : The event handler for the page loads. This simply just prints a message to the html
        // Parameters   : object sender : The sender that triggers this event handler
        //              : EventArgs e : Event arguments that the event handler can use
        // Returns      : N/A
        /////////////////////////////////////////
        protected void Page_Load(object sender, EventArgs e)
        {
            winGreeting.InnerHtml = "Congratulations! You won!";
        }


        /////////////////////////////////////////
        // Method       : replay_Click
        // Description  : The event handler for when the user clicks the replay button. Iterates through all cookies and sets the 
        //              : the value of the cookie to an empty string, unless the cookie in question has the key "username". Then
        //              : the user is redirected to the page where they are asked for a max number.
        // Parameters   : object sender : the sender that triggers this event
        //              : EventArgs e : special event args that the event handler has access to.
        // Returns      : N/A
        /////////////////////////////////////////
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