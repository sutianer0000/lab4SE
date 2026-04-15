<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="WebUI.Students" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"><title>Students</title></head>
<body>
    <form id="form1" runat="server">
        <h2>Student Management</h2>
        <a href="Main.aspx">Back to Main</a><br /><br />
        <asp:Label runat="server" Text="ID:"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Date of Birth:"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="City:"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Age:"></asp:Label>
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Year of Enroll:"></asp:Label>
        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="Major:"></asp:Label>
        <asp:TextBox ID="txtMajor" runat="server"></asp:TextBox><br />
        <asp:Label runat="server" Text="GPA:"></asp:Label>
        <asp:TextBox ID="txtGPA" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnGet" runat="server" Text="Get" OnClick="btnGet_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br /><br />
        <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </form>
</body>
</html>