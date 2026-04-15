<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="WebUI.Courses" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"><title>Courses</title></head>
<body>
    <form id="form1" runat="server">
        <h2>Course Management</h2>
        <a href="Main.aspx">Back to Main</a><br /><br />
        <asp:Label runat="server" Text="ID:"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Course Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Credits:"></asp:Label>
        <asp:TextBox ID="txtCredits" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Department ID:"></asp:Label>
        <asp:TextBox ID="txtDeptID" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Instructor ID:"></asp:Label>
        <asp:TextBox ID="txtInstrID" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnGet" runat="server" Text="Get" OnClick="btnGet_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br /><br />
        <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </form>
</body>
</html>