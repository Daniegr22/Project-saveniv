using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace danielprojectasp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Application["uName1"] = "Amit123";
            //Application["uName2"] = "GuyGuy";
            //Application["uName3"] = "Ariel123";
            //Application["uPass1"] = "Amit1234@";
            //Application["uPass2"] = "Guy1234@";
            //Application["uPass3"] = "Ariel1234@";
            //Application["aName1"] = "GuyTheKing";
            //Application["aName2"] = "Gilad123";
            //Application["aPass1"] = "Guy2468!";
            //Application["aPass2"] = "Gilad1968@";
            Application["visitor"] = 0;//כמה לא רשומים מחוברים
            Application["logins"] = 0;//כמה רשומים מחוברים סך הכל כולל מנהלי מערכת
            Application["online"] = 0;//כמה מחוברים סך הכל כולל מנהלי מערכת, רשומים ולא רשומים
            Application["onlineAdmin"] = 0;//כמה מנהלי מערכת מחוברים
            Application["count2"] = 0;
            Application["allEnterAdmin"] = 0;
            Application["allEnter"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["userName"] = "Visitor";
            Session["OkToEnter"] = 0;
            Session["Login"] = false;
            Session["Admin"] = false;
            Session["count1"] = 0;
            Session["userToUpdate"] = 0;
            Application["allEnter"] = (int)Application["allEnter"] + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["logins"] = (int)Application["logins"] - 1;
            Application["online"] = (int)Application["online"] - 1;

            if ((bool)Session["Admin"] == true)
            {
                Application["onlineAdmin"] = (int)Application["onlineAdmin"] - 1;
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}