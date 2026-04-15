using BAL;
using DAL.Models;
using System;

namespace WebUI
{
    public partial class Students : System.Web.UI.Page
    {
        private readonly StudentService _service = new StudentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack) BindGrid();
        }

        private void BindGrid()
        {
            gvStudents.DataSource = _service.GetAll();
            gvStudents.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentName = txtName.Text,
                DateOfBirth = DateTime.Parse(txtDOB.Text),
                City = txtCity.Text,
                Age = int.Parse(txtAge.Text),
                YearOfEnroll = int.Parse(txtYear.Text),
                Major = txtMajor.Text,
                GPA = decimal.Parse(txtGPA.Text)
            };
            _service.Add(student);
            Response.Write("Student added successfully!");
            BindGrid();
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            var student = _service.GetById(int.Parse(txtID.Text));
            if (student != null)
            {
                txtName.Text = student.StudentName;
                txtDOB.Text = student.DateOfBirth.ToString("yyyy-MM-dd");
                txtCity.Text = student.City;
                txtAge.Text = student.Age.ToString();
                txtYear.Text = student.YearOfEnroll.ToString();
                txtMajor.Text = student.Major;
                txtGPA.Text = student.GPA.ToString();
            }
            else Response.Write("Student not found!");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentID = int.Parse(txtID.Text),
                StudentName = txtName.Text,
                DateOfBirth = DateTime.Parse(txtDOB.Text),
                City = txtCity.Text,
                Age = int.Parse(txtAge.Text),
                YearOfEnroll = int.Parse(txtYear.Text),
                Major = txtMajor.Text,
                GPA = decimal.Parse(txtGPA.Text)
            };
            _service.Update(student);
            Response.Write("Student updated successfully!");
            BindGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _service.Delete(int.Parse(txtID.Text));
            Response.Write("Student deleted successfully!");
            BindGrid();
        }
    }
}