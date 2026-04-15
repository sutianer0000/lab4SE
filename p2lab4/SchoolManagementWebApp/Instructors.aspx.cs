using BAL;
using DAL.Models;
using System;

namespace WebUI
{
    public partial class Instructors : System.Web.UI.Page
    {
        private readonly InstructorService _service = new InstructorService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack) BindGrid();
        }

        private void BindGrid()
        {
            gvInstructors.DataSource = _service.GetAll();
            gvInstructors.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var instructor = new Instructor
            {
                InstructorName = txtName.Text,
                DepartmentID = int.Parse(txtDeptID.Text)
            };
            _service.Add(instructor);
            Response.Write("Instructor added successfully!");
            BindGrid();
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            var instructor = _service.GetById(int.Parse(txtID.Text));
            if (instructor != null)
            {
                txtName.Text = instructor.InstructorName;
                txtDeptID.Text = instructor.DepartmentID.ToString();
            }
            else Response.Write("Instructor not found!");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var instructor = new Instructor
            {
                InstructorID = int.Parse(txtID.Text),
                InstructorName = txtName.Text,
                DepartmentID = int.Parse(txtDeptID.Text)
            };
            _service.Update(instructor);
            Response.Write("Instructor updated successfully!");
            BindGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _service.Delete(int.Parse(txtID.Text));
            Response.Write("Instructor deleted successfully!");
            BindGrid();
        }
    }
}