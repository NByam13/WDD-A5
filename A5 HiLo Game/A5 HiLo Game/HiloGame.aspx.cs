using System;
using System.Collections.Generic;

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

        }

        protected void ChoiceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}