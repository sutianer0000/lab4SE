using BAL;
using System;

namespace LoginWebUI
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly UserService _userService = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (_userService.ValidateUser(username, password))
            {
                Session["Username"] = username;
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Login successful! Welcome " + username;
            }
            else
            {
                lblMessage.Text = "Invalid username or password!";
            }
        }
    }
}