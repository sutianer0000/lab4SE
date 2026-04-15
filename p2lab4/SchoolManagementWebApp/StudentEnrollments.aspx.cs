using BAL;
using DAL.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebUI
{
    public partial class StudentEnrollments : System.Web.UI.Page
    {
        private readonly StudentCourseService _service = new StudentCourseService();
        private string connStr => ConfigurationManager.ConnectionStrings["SchoolDBConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack)
            {
                LoadCourses();
                BindGrid();
            }
        }

        private void LoadCourses()
        {
            using (var conn = new SqlConnection(connStr))
            {
                var cmd = new SqlCommand("GetCourses", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                ddlCourses.DataSource = table;
                ddlCourses.DataTextField = "CourseName";
                ddlCourses.DataValueField = "CourseID";
                ddlCourses.DataBind();
            }
        }

        private void BindGrid()
        {
            if (ddlCourses.SelectedValue != null)
            {
                int courseId = int.Parse(ddlCourses.SelectedValue);
                gvEnrollments.DataSource = _service.GetByCourse(courseId);
                gvEnrollments.DataBind();
            }
        }

        protected void ddlCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var sc = new StudentCourse
            {
                StudentID = 1, // replace with actual student ID as needed
                CourseID = int.Parse(ddlCourses.SelectedValue)
            };
            _service.Add(sc);
            Response.Write("Enrollment added successfully!");
            BindGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvEnrollments.SelectedRow != null)
            {
                int studentId = int.Parse(gvEnrollments.SelectedRow.Cells[0].Text);
                _service.Delete(studentId);
                Response.Write("Enrollment deleted successfully!");
                BindGrid();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}