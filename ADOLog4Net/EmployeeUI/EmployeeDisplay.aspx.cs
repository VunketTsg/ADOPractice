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
    public partial class EmployeeDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          // log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            if (!Page.IsPostBack)
            {

                LoadCities();
            }
        }
        public void LoadCities()
        {
            

            DBHelper dbh = new DBHelper();
            DataSet dsemployee = dbh.GetAllCities();
            DropDownList1.DataSource = dsemployee;
            DropDownList1.DataTextField = "city";
            DropDownList1.DataValueField = "City";
            DropDownList1.DataBind();
        }
        protected void DsplyEmp_Click(object sender, EventArgs e)
        {
            BindEmployees();
        }

        public void BindEmployees()
        {
            EmployeeDac emp = new EmployeeDac();

            DataSet dsEmployee = emp.GetAllEmployee();
            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = dsEmployee;
                GridView1.DataBind();
            }
            else
            {

            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow grdobj = GridView1.Rows[e.RowIndex];

            Label lblEmpId = (Label)grdobj.FindControl("Label5");
            TextBox Lname = (TextBox)grdobj.FindControl("TextBox2");
            TextBox Fname = (TextBox)grdobj.FindControl("TextBox3");
            TextBox city = (TextBox)grdobj.FindControl("TextBox4");

            int EmpId = Convert.ToInt32(lblEmpId.Text);
            string LName = Lname.Text;
            string FName = Fname.Text;
            string City = city.Text;

            EmployeeDac edc = new EmployeeDac();
            bool result = edc.UpdateEmployee(EmpId, LName, FName, City);
            if (result)
            {
                //reset
                GridView1.EditIndex = -1;
                //rebind data to refresh
                BindEmployees();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            GridView1.EditIndex = e.NewEditIndex;
            BindEmployees();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow grdobj = GridView1.Rows[e.RowIndex];

            Label lblEmpId = (Label)grdobj.FindControl("Label1");

            int empid = Convert.ToInt32(lblEmpId.Text);

            EmployeeDac edc = new EmployeeDac();
            bool result = edc.DeleteEmployee(empid);

            if (result)
            {
                BindEmployees();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int newpageindx = e.NewPageIndex;

            GridView1.PageIndex = newpageindx;

            BindEmployees();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindEmployees();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeDac edc = new EmployeeDac();
            EmployeeDac.MyData mydataobj = edc.GetAllEmployeByCity(DropDownList1.SelectedValue);

            GridView1.DataSource = mydataobj.dsEmployers;
            GridView1.DataBind();

            int count = mydataobj.rowscount;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //    EmployeeDac edc = new EmployeeDac();
            //   // int id = Convert.ToInt32(TextBox5.Text);
            //    EmployeeDac.MyData mydataobj = edc.GetAllEmployeByID(id);

            //    GridView1.DataSource = mydataobj.dsEmployers;
            //    GridView1.DataBind();

            //    int count = mydataobj.rowscount;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //    if(e.CommandName == "Button2")
            //    {
            //        int index = Convert.ToInt32(e.CommandArgument);
            //        GridViewRow row = GridView1.Rows[index];
            //        Response.Redirect("~/EmployeeUI/EmployeeUpdate.aspx?Empid =" + row.Cells[0].Text);
            // }
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