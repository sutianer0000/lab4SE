<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEnrollments.aspx.cs" Inherits="WebUI.StudentEnrollments" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"><title>Student Enrollments</title></head>
<body>
    <form id="form1" runat="server">
        <h2>Student Enrollments</h2>
        <a href="Main.aspx">Back to Main</a><br /><br />
        <asp:Label runat="server" Text="Select Course:"></asp:Label>
        <asp:DropDownList ID="ddlCourses" runat="server" AutoPostBack="true"
            OnSelectedIndexChanged="ddlCourses_SelectedIndexChanged"></asp:DropDownList>
        <br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnRefresh" runat="server" Text="Refresh" OnClick="btnRefresh_Click" />
        <br /><br />
        <asp:GridView ID="gvEnrollments" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </form>
</body>
</html>