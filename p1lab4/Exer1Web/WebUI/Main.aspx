<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Main.aspx.cs" Inherits="MainWebUI.Main" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Main Form</h2>
            <asp:Label ID="lblWelcome" runat="server"></asp:Label>
            <br /><br />

            <asp:Menu ID="menuMain" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem Text="Home" NavigateUrl="Main.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Customers" NavigateUrl="CustomerForm.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Logout" NavigateUrl="Login.aspx"></asp:MenuItem>
                </Items>
            </asp:Menu>
            <br /><br />

            <div>
                <p>Welcome to the Main Form. Use the menu to navigate.</p>
            </div>
        </div>
    </form>
</body>
</html>