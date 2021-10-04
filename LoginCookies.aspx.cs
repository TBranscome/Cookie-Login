using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie_Login
{
    public partial class LoginCookies : System.Web.UI.Page
    {
        
        public bool loggedIn = false;
        string pass = "password";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["authcookie"] != null)
            {
                if (Request.Cookies["authcookie"]["password"] == pass)
                {
                    loggedIn = true;
                    if (loggedIn)
                    {
                        login.Style.Add("display", "none");
                        content.Style.Remove("display");
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == pass)
            {
                if (CheckBox1.Checked)
                {
                    Response.Cookies["authcookie"]["password"] = TextBox1.Text;
                    Response.Cookies["authcookie"].Expires = DateTime.Now.AddMinutes(1);
                    loggedIn = true;
                }
                loggedIn = true;
                if (loggedIn)
                {
                    login.Style.Add("display", "none");
                    content.Style.Remove("display");
                }
            }
        }
    
    }
}