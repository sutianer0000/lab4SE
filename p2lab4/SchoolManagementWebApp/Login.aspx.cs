using BAL;
using System;

namespace WebUI
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly UserService _userService = new UserService();

        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (_userService.ValidateUser(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                Session["Username"] = txtUsername.Text.Trim();
                Response.Redirect("Main.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password!";
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}