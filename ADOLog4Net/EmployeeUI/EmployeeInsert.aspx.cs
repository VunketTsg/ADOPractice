using ADOLog4Net.EmployeeDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOLog4Net.EmployeeUI
{
    public partial class EmployeeInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         

           EmployeeDac edc = new EmployeeDac();
            //EmployeeDac.Employee emp = new EmployeeDac.Employee();
            // emp.EMPID = Convert.ToInt32(TextBox1.Text);
            // int EMPID = Convert.ToInt32(TextBox1.Text);
            // emp.LastName = TextBox2.Text;
            string LastName = TextBox2.Text;
            // emp.FirstName = TextBox3.Text;
            string FirstName = TextBox3.Text;
            // emp.City = TextBox4.Text;
            string City = TextBox4.Text;
            bool result = edc.InsertEmployee(LastName, FirstName, City);

            if (result)
            {
                //TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                Response.Redirect("~/EmployeeUI/EmployeeDisplay.aspx");
            }
            else
            {

            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeUI/EmployeeInsert.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeUI/EmployeeUpdate.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeUI/EmployeeDelete.aspx");
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeUI/EmployeeDisplay.aspx");
        }
    }
}