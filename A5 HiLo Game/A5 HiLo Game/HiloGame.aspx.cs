//*********************************************
// File			 : HiloGame.aspx.cs
// Project		 : A5 - HiLo in ASP.NET
// Programmer	 : Nick Byam, Nikola Ristic
// Last Change   : 2020-11-20
// Description	 : This page is the code behind for the main game page. On this page the random number is picked, validator ranges set
//               : and cookies updated to ensure that accurate information is displayed to the user.
//*********************************************


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A5_HiLo_Game
{
    public partial class HiloGame : System.Web.UI.Page
    {
        Random rnd = new Random();

        /////////////////////////////////////////
        // Method       : Page_Load
        // Description  : A page_load viewstate event handler. It sets the range for the RangeValidator, and if this is the first visit at the
        //              : page then it also chooses a random number and sets it to a cookie.
        // Parameters   : object sender : the object that triggered the event handler and sent it the info
        //              : EventArgs e : Event specific arguments that the event handler can use
        // Returns      : N/A
        /////////////////////////////////////////
        protected void Page_Load(object sender, EventArgs e)
        {
            int maxNum = Int32.Parse(Request.Cookies.Get("maxNum").Value);
            int minNum = Int32.Parse(Request.Cookies.Get("minNum").Value);
            HttpCookie username = Request.Cookies.Get("Username");
            rangeCheck1.MaximumValue = maxNum.ToString();
            rangeCheck1.MinimumValue = minNum.ToString();

            if (!Page.IsPostBack) // if this is the first time getting to this page, set the random number.
            {
                HttpCookie rndNumCookie = new HttpCookie("rndNum");
                int rndNum = rnd.Next(1, maxNum + 1);
                rndNumCookie.Value = rndNum.ToString();
                Response.Cookies.Add(rndNumCookie);
                Gamegreeting.InnerHtml = "Hello there " + username.Value + "! Please choose a number between " + minNum + " and " + maxNum + "!";
            }
        }


        /////////////////////////////////////////
        // Method       : choiceCheck_Click
        // Description  : An event handler for the guess button which takes the current user guess and checks to see if they won.
        //              : If they did not win, the range is adjusted accordingly depending on if the guess was higher or lower than the 
        //              : random number.
        // Parameters   : object sender : the object that triggers the event.
        //              : EventArgs e : Event specific arguments for the event handler to use
        // Returns      : N/A
        /////////////////////////////////////////
        protected void choiceCheck_Click(object sender, EventArgs e)
        {
            string guess = ChoiceBox.Text; // get the guess from the text box
            string cookieRnd = Request.Cookies.Get("rndNum").Value; // get the value of the random number
            int maxNum = Int32.Parse(Request.Cookies.Get("maxNum").Value); // Parse out integer vals from the min and max number cookie vals
            int minNum = Int32.Parse(Request.Cookies.Get("minNum").Value);
            int guessNum = Int32.Parse(guess); // convert guess to an int as well
            int randomNum = Int32.Parse(cookieRnd);
            if (guessNum < randomNum) // if the user's guess was less than random num
            {
                Response.Cookies["minNum"].Value = (guessNum + 1).ToString(); // update the minimum cookie
                minNum = guessNum + 1; // then reprint the greeting with updated vals.
                Gamegreeting.InnerHtml = "Hello there " + Request.Cookies.Get("Username").Value + "! Please choose a number between " + minNum + " and " + maxNum + "!";

            }
            else if (guessNum > randomNum) // if the user's guess was more than random num
            {
                Response.Cookies["maxNum"].Value = (guessNum - 1).ToString(); // decrease max cookie value
                maxNum = guessNum - 1; // reprint the greeting with updated values.
                Gamegreeting.InnerHtml = "Hello there " + Request.Cookies.Get("Username").Value + "! Please choose a number between " + minNum + " and " + maxNum + "!";
            }
            else if (guessNum == randomNum) // if the user guesses the number, redirect to the win page.
            {
                Response.Redirect("./winPage.aspx");
            }
            ChoiceBox.Text = ""; // reset the textbox to empty so that the user doesn't have to delete their old guess.
        }
    }
}
