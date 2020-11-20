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

        protected void choiceCheck_Click(object sender, EventArgs e)
        {
            string guess = ChoiceBox.Text;
            string cookieRnd = Request.Cookies.Get("rndNum").Value;
            int maxNum = Int32.Parse(Request.Cookies.Get("maxNum").Value);
            int minNum = Int32.Parse(Request.Cookies.Get("minNum").Value);
            int guessNum = Int32.Parse(guess);
            int randomNum = Int32.Parse(cookieRnd);
            if (guessNum < randomNum)
            {
                Response.Cookies["minNum"].Value = (guessNum + 1).ToString();
                minNum = guessNum + 1;
                Gamegreeting.InnerHtml = "Hello there " + Request.Cookies.Get("Username").Value + "! Please choose a number between " + minNum + " and " + maxNum + "!";

            }
            else if (guessNum > randomNum)
            {
                Response.Cookies["maxNum"].Value = (guessNum - 1).ToString();
                maxNum = guessNum - 1;
                Gamegreeting.InnerHtml = "Hello there " + Request.Cookies.Get("Username").Value + "! Please choose a number between " + minNum + " and " + maxNum + "!";
            }
            else if (guessNum == randomNum)
            {
                Response.Redirect("./winPage.aspx");
            }
            ChoiceBox.Text = "";
        }

        protected void ChoiceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
