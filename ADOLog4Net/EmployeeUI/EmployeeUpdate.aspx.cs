using ADOLog4Net.EmployeeDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOLog4Net.EmployeeUI
{
    public partial class EmployeeUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
           
            EmployeeDac edc = new EmployeeDac();
            int id = Convert.ToInt32(TextBox4.Text);
            EmployeeDac.MyData mydataobj = edc.GetAllEmployeByID(id);


            Label1.Text = mydataobj.dsEmployers.Tables[0].Rows[0][0].ToString();
            TextBox1.Text = mydataobj.dsEmployers.Tables[0].Rows[0][1].ToString();
            TextBox2.Text = mydataobj.dsEmployers.Tables[0].Rows[0][2].ToString();
            TextBox3.Text = mydataobj.dsEmployers.Tables[0].Rows[0][3].ToString();

            // GridView1.DataSource = mydataobj.dsEmployers;
            // GridView1.DataBind();

            int count = mydataobj.rowscount;
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            EmployeeDac edc = new EmployeeDac();
            int empid = Convert.ToInt32(TextBox4.Text);
            bool result = edc.UpdateEmployee(empid, TextBox1.Text, TextBox2.Text, TextBox3.Text);


            if (result)
            {

            }
            Response.Redirect("~/EmployeeUI/EmployeeDisplay.aspx");
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeUI/EmployeeUpdate.aspx");
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