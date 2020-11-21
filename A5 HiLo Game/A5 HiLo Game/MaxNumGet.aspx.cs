//*********************************************
// File			 : MaxNumGet.aspx.cs
// Project		 : A5 - HiLo in ASP.NET
// Programmer	 : Nick Byam, Nikola Ristic
// Last Change   : 2020-11-20
// Description	 : This page details the event handlers for when the page loads, and what happens when the button is clicked.
//*********************************************


using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A5_HiLo_Game
{
    public partial class MaxNumGet : System.Web.UI.Page
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
            //get username from cookie
            HttpCookie username = Request.Cookies.Get("Username");
            //display greeting to user
            greeting.InnerHtml = "Hello there " + username.Value + "! Please choose a max number greater than 1!";
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
            //create cookies for the maximum and minimum value
            HttpCookie max = new HttpCookie("maxNum");
            HttpCookie min = new HttpCookie("minNum");
            //enter the new max and the minimum as 1
            max.Value = maxNum.Text;
            min.Value = "1";
            //add the cookies to the website
            Response.Cookies.Add(max);
            Response.Cookies.Add(min);
            //go to the next page
            Response.Redirect("./HiloGame.aspx");
        }
    }
}