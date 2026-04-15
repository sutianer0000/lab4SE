using BAL;
using DAL.Models;
using System;

namespace WebUI
{
    public partial class Courses : System.Web.UI.Page
    {
        private readonly CourseService _service = new CourseService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack) BindGrid();
        }

        private void BindGrid()
        {
            gvCourses.DataSource = _service.GetAll();
            gvCourses.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var course = new Course
            {
                CourseName = txtName.Text,
                Credits = int.Parse(txtCredits.Text),
                DepartmentID = int.Parse(txtDeptID.Text),
                InstructorID = int.Parse(txtInstrID.Text)
            };
            _service.Add(course);
            Response.Write("Course added successfully!");
            BindGrid();
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            var course = _service.GetById(int.Parse(txtID.Text));
            if (course != null)
            {
                txtName.Text = course.CourseName;
                txtCredits.Text = course.Credits.ToString();
                txtDeptID.Text = course.DepartmentID.ToString();
                txtInstrID.Text = course.InstructorID.ToString();
            }
            else Response.Write("Course not found!");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var course = new Course
            {
                CourseID = int.Parse(txtID.Text),
                CourseName = txtName.Text,
                Credits = int.Parse(txtCredits.Text),
                DepartmentID = int.Parse(txtDeptID.Text),
                InstructorID = int.Parse(txtInstrID.Text)
            };
            _service.Update(course);
            Response.Write("Course updated successfully!");
            BindGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _service.Delete(int.Parse(txtID.Text));
            Response.Write("Course deleted successfully!");
            BindGrid();
        }
    }
}