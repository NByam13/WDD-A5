﻿using System;
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
            rangeCheck1.MaximumValue = max.Value;
            rangeCheck1.MinimumValue = min.Value;
            Gamegreeting.InnerHtml = "Hello there " + username.Value + "! Please choose a number between "+ min.Value + " and " + max.Value + "!";

            if (!Page.IsPostBack) // if this is the first time getting to this page, set the random number.
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
            string cookieRnd = Request.Cookies.Get("rndNum").Value;
            int maxNum = Int32.Parse(Request.Cookies.Get("maxNum").Value);
            int minNum = Int32.Parse(Request.Cookies.Get("minNum").Value);
            int guessNum = Int32.Parse(guess);
            int randomNum= Int32.Parse(cookieRnd);
            if(guessNum<randomNum)
            {
                Response.Cookies["minNum"].Value = (guessNum + 1).ToString();
            }
            else if (guessNum > randomNum)
            {
                Response.Cookies["maxNum"].Value = (guessNum - 1).ToString();
            }
            else if(guessNum==randomNum)
            {

            }
            //Regex reg = new Regex(pattern);
            //if(reg.IsMatch(guess)==true)
            //{
            //    int guessNum = Int32.Parse(guess);
            //    int randomNum= Int32.Parse(cookieRnd);
            //    //HttpCookie max = Request.Cookies.Get("maxNum");
            //    //HttpCookie min = Request.Cookies.Get("minNum");
            //    HttpCookie username = Request.Cookies.Get("Username");

            //    if (guessNum==randomNum)
            //    {

            //    }
            //    else if((guessNum<randomNum) && (guessNum>=minNum))
            //    {
            //        Response.Cookies["minNum"].Value = (guessNum+1).ToString();
            //    }
            //    else if ((guessNum > randomNum) && (guessNum <= maxNum))
            //    {
            //        Response.Cookies["maxNum"].Value = (guessNum + 1).ToString();
            //    }
            //    else
            //    {
            //        //tell user its invalid
            //    }
            //}
            //else
            //{
            //    //tell user its invalid

            //}
        }

        protected void ChoiceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
