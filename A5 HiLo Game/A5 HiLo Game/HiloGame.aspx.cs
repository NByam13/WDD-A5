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
            HttpCookie max = Request.Cookies.Get("maxNum");
            HttpCookie min = Request.Cookies.Get("minNum");
            HttpCookie username = Request.Cookies.Get("Username");
            Gamegreeting.InnerHtml = "Hello there " + username.Value + "! Please choose a number between "+ min.Value + " and " + max.Value + "!";

            if(!Page.IsPostBack) // if this is the first time getting to this page, set the random number.
            {
                HttpCookie rndNumCookie = new HttpCookie("rndNum");
                int rndNum = rnd.Next(1, Int32.Parse(max.Value) + 1);
                rndNumCookie.Value = rndNum.ToString();
                Response.Cookies.Add(rndNumCookie);
            }
        }
        
        protected void choiceCheck_Click(object sender, EventArgs e)
        {
            string guess = ChoiceBox.Text;
            string pattern = "/$[0-9]+^/";
            string cookieRnd = Request.Cookies.Get("rndNum").Value;
            int maxNum = Int32.Parse(Request.Cookies.Get("maxNum").Value);
            int minNum = Int32.Parse(Request.Cookies.Get("minNum").Value);

            Regex reg = new Regex(pattern);
            if(reg.IsMatch(guess))
            {
                int guessNum = Int32.Parse(guess);
                int randomNum= Int32.Parse(cookieRnd);
                HttpCookie max = Request.Cookies.Get("maxNum");
                HttpCookie min = Request.Cookies.Get("minNum");

                if (guessNum==randomNum)
                {

                }
                else if((guessNum<randomNum) && (guessNum>=minNum))
                {
                    min.Value =(guessNum+1).ToString();
                }
                else if ((guessNum > randomNum) && (guessNum <= maxNum))
                {
                    max.Value= (guessNum - 1).ToString();
                }
                else
                {
                    //tell user its invalid
                }
            }
            else
            {
                //tell user its invalid
            }
        }

        protected void ChoiceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}