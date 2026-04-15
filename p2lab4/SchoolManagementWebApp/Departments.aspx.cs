using BAL;
using DAL.Models;
using System;

namespace WebUI
{
    public partial class Departments : System.Web.UI.Page
    {
        private readonly DepartmentService _service = new DepartmentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack) BindGrid();
        }

        private void BindGrid()
        {
            gvDepartments.DataSource = _service.GetAll();
            gvDepartments.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var dept = new Department { DepartmentName = txtName.Text };
            _service.Add(dept);
            Response.Write("Department added successfully!");
            BindGrid();
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            var dept = _service.GetById(int.Parse(txtID.Text));
            if (dept != null)
                txtName.Text = dept.DepartmentName;
            else
                Response.Write("Department not found!");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var dept = new Department
            {
                DepartmentID = int.Parse(txtID.Text),
                DepartmentName = txtName.Text
            };
            _service.Update(dept);
            Response.Write("Department updated successfully!");
            BindGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _service.Delete(int.Parse(txtID.Text));
            Response.Write("Department deleted successfully!");
            BindGrid();
        }
    }
}