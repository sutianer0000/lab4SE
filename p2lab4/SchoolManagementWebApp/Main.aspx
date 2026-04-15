<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebUI.Main" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"><title>Main</title></head>
<body>
    <form id="form1" runat="server">
        <h2>School Management System</h2>
        <asp:Label ID="lblWelcome" runat="server"></asp:Label>
        <br /><br />
        <asp:Menu ID="menuMain" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem Text="Home" NavigateUrl="Main.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Students" NavigateUrl="Students.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Courses" NavigateUrl="Courses.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Instructors" NavigateUrl="Instructors.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Departments" NavigateUrl="Departments.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Enrollments" NavigateUrl="StudentEnrollments.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Logout" NavigateUrl="Login.aspx"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <br /><br />
        <p>Welcome to the School Management System. Use the menu to navigate.</p>
    </form>
</body>
</html>