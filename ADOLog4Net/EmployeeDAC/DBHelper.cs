using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADOLog4Net.EmployeeDAC
{
    public class DBHelper
    {
        public DataSet GetAllCities()
        {
            SqlConnection con = new SqlConnection();
            // con.ConnectionString = "Data Source=LAPTOP-1SE8I7RI;Initial Catalog=Northwind;Integrated Security=True";
            con.ConnectionString = CommonUtil.GetConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct(City) from Employees";
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet dsEmployee = new DataSet();
            con.Open();
            da.Fill(dsEmployee);
            con.Close();

            return dsEmployee;
        }

        public DataSet GetAllEmpID()
        {
            SqlConnection con = new SqlConnection();
            // con.ConnectionString = "Data Source=LAPTOP-1SE8I7RI;Initial Catalog=Northwind;Integrated Security=True";
            con.ConnectionString = CommonUtil.GetConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct(EmployeeID) from Employees";
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet dsEmployee = new DataSet();
            con.Open();
            da.Fill(dsEmployee);
            con.Close();

            return dsEmployee;
        }
    }
}