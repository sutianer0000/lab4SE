using System;

namespace MainWebUI
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblWelcome.Text = "Welcome, " + Session["Username"].ToString() + "!";
            }
        }
    }
}