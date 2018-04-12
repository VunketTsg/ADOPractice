using ADOLog4Net.EmployeeDAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ADOLog4Net.EmployeeUI
{
    public partial class EmployeeDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadID();
            }
        }

        public void LoadID()
        {
            DBHelper dbh = new DBHelper();
            DataSet dsemployee = dbh.GetAllEmpID();
            DropDownList1.DataSource = dsemployee;
            DropDownList1.DataTextField = "EmployeeID";
            DropDownList1.DataValueField = "EmployeeID";
            DropDownList1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            BindEmployees();
        }

        public void BindEmployees()
        {

            EmployeeDac emp = new EmployeeDac();
            int eid = Convert.ToInt32(DropDownList1.SelectedValue);
            // DataSet dsEmployee = emp.GetAllEmployeByID(eid);
            EmployeeDac.MyData mydata = emp.GetAllEmployeByID(eid);

            if (mydata.dsEmployers.Tables[0].Rows.Count > 0)
            {


                empid.Text = mydata.dsEmployers.Tables[0].Rows[0][0].ToString();
                elname.Text = mydata.dsEmployers.Tables[0].Rows[0][1].ToString();
                empFname.Text = mydata.dsEmployers.Tables[0].Rows[0][2].ToString();
                city.Text = mydata.dsEmployers.Tables[0].Rows[0][3].ToString();

            }

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            EmployeeDac edc = new EmployeeDac();
            int id = Convert.ToInt32(empid.Text);
            bool result = edc.DeleteEmployee(id);

            if (result)
            {
                BindEmployees();
            }

            Response.Redirect("~/EmployeeUI/EmployeeDisplay");
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