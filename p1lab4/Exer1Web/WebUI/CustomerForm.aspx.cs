using BAL;
using BLL;
using DAL;
using System;

namespace MainWebUI
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        private readonly CustomerService _customerService = new CustomerService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

            if (!IsPostBack)
                BindCustomerGrid();
        }

        private void BindCustomerGrid()
        {
            gvCustomers.DataSource = _customerService.GetAllCustomers();
            gvCustomers.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer { Name = txtName.Text, Email = txtEmail.Text };
            _customerService.AddCustomer(customer);
            Response.Write("Customer added successfully!");
            BindCustomerGrid();
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var customer = _customerService.GetCustomer(id);
            if (customer != null)
            {
                txtName.Text = customer.Name;
                txtEmail.Text = customer.Email;
            }
            else
            {
                Response.Write("Customer not found!");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Email = txtEmail.Text
            };
            _customerService.UpdateCustomer(customer);
            Response.Write("Customer updated successfully!");
            BindCustomerGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _customerService.DeleteCustomer(id);
            Response.Write("Customer deleted successfully!");
            BindCustomerGrid();
        }
    }
}