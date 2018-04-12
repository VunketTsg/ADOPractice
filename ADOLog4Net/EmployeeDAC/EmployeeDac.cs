using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADOLog4Net.EmployeeDAC
{
    public class EmployeeDac
    {
        Logobject lo = new Logobject();

         log4net.ILog log;
        public DataSet GetAllEmployee()
        {

            //log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

           
            log=lo.ConnectionString();

            var constr = CommonUtil.GetConnectionString();
            DataSet result = null;
            try
            {
                //Creating a Sql connection object
                using (SqlConnection con = new SqlConnection(constr))

                //connection object using connection string which contains server name,data base name,connection string(in this case windows authentication)
                // con.ConnectionString = "Data Source=LAPTOP-1SE8I7RI;Initial Catalog=Northwind;Integrated Security=True";
                //con.ConnectionString = CommonUtil.GetConnectionString();
                //Creating SqlCommand object
                using (SqlCommand cmd = new SqlCommand("GetAllEmployes", con))
                {
                    // Declare which type of command we are using (i.e. text,Stored procedure,table)
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Declare command text in this case we declare stored procedure name
                    //cmd.CommandText = "GetAllEmployes";

                    //cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;

                    DataSet dsEmploye = new DataSet();
                    con.Open();

                    da.Fill(dsEmploye);

                    //con.Close();

                    result = dsEmploye;
                }
                throw new Exception("Get All Employee exception", new DataException());
            }

            catch (Exception ex)
            {
                log.Debug(ex.Message, ex);
            }
            return result;

        }

        public MyData GetAllEmployeByCity(string city)
        {
            var constr = CommonUtil.GetConnectionString();
            MyData result = null;
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                // con.ConnectionString = "Data Source=LAPTOP-1SE8I7RI;Initial Catalog=Northwind;Integrated Security=True";
                //  con.ConnectionString = CommonUtil.GetConnectionString();

                using (SqlCommand cmd = new SqlCommand("GetAllEmployeByCity", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  cmd.CommandText = "GetAllEmployeByCity";
                    //  cmd.Connection = con;

                    cmd.Parameters.Add("@City", SqlDbType.NVarChar);
                    cmd.Parameters["@City"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@City"].Value = city;

                    cmd.Parameters.Add("@numrows", SqlDbType.Int);
                    cmd.Parameters["@numrows"].Direction = ParameterDirection.Output;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;

                    DataSet dsEmployee = new DataSet();
                    con.Open();
                    da.Fill(dsEmployee);

                    int rowseffected = Convert.ToInt32(cmd.Parameters["@numrows"].Value);
                  //  con.Close();

                    MyData mydata = new MyData();
                    mydata.dsEmployers = dsEmployee;
                    mydata.rowscount = rowseffected;

                    result = mydata;
                }
                throw new Exception("Get employee by city exception", new DataException());
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return result;
        }



        public MyData GetAllEmployeByID(int empid)
        {

            log4net.Config.XmlConfigurator.Configure();
            //log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            lo.ConnectionString();
            var constr = CommonUtil.GetConnectionString();
            MyData result = null;

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                // con.ConnectionString = "Data Source=LAPTOP-1SE8I7RI;Initial Catalog=Northwind;Integrated Security=True";
                // con.ConnectionString = CommonUtil.GetConnectionString();

                using (SqlCommand cmd = new SqlCommand("GetAllEmployeByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.CommandText = "GetAllEmployeByID";
                    // cmd.Connection = con;

                    cmd.Parameters.Add("@Empid", SqlDbType.NChar);
                    cmd.Parameters["@Empid"].Direction = ParameterDirection.Input;
                    //cmd.Parameters["@Empid"].Value = EMPID;
                    cmd.Parameters["@Empid"].Value = empid;

                    cmd.Parameters.Add("@numrows", SqlDbType.Int);
                    cmd.Parameters["@numrows"].Direction = ParameterDirection.Output;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;

                    DataSet dsEmployee = new DataSet();
                    con.Open();
                    da.Fill(dsEmployee);

                    int rowseffected = Convert.ToInt32(cmd.Parameters["@numrows"].Value);
                   // con.Close();

                    MyData mydata = new MyData();
                    mydata.dsEmployers = dsEmployee;
                    mydata.rowscount = rowseffected;

                    result = mydata;
                    
                }
                throw new Exception("Get employee by id exception", new DataException());
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }

            return result;
        }


        public bool InsertEmployee(string LastName, string FirstName, string City)
        {
            log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            lo.ConnectionString();

            var constr = CommonUtil.GetConnectionString();
            bool result = false;

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                // con.ConnectionString = "Data Source=LAPTOP-1SE8I7RI;Initial Catalog=Northwind;Integrated Security=True";
                // con.ConnectionString = CommonUtil.GetConnectionString();

                using (SqlCommand cmd = new SqlCommand("InsertEmployees", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.CommandText = "InsertEmployees";
                    //  cmd.Connection = con;

                    cmd.Parameters.Add("@EmpLName", SqlDbType.NVarChar);
                    cmd.Parameters["@EmpLName"].Direction = ParameterDirection.Input;
                    //cmd.Parameters["@EmpLName"].Value = empobj.LastName;
                    cmd.Parameters["@EmpLName"].Value = LastName;

                    cmd.Parameters.Add("@EmpFName", SqlDbType.NVarChar);
                    cmd.Parameters["@EmpFName"].Direction = ParameterDirection.Input;
                    // cmd.Parameters["@EmpFName"].Value = empobj.FirstName;
                    cmd.Parameters["@EmpFName"].Value = FirstName;

                    cmd.Parameters.Add("@City", SqlDbType.NVarChar);
                    cmd.Parameters["@City"].Direction = ParameterDirection.Input;
                    //cmd.Parameters["@City"].Value = empobj.City;
                    cmd.Parameters["@City"].Value = City;

                    con.Open();
                    int rowseffected = cmd.ExecuteNonQuery();

                    // con.Close();

                    if (rowseffected > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                    throw new Exception("Insert exception ", new DataException());
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }

            return result;
        }

        public bool UpdateEmployee(int empid, string LastName, string FirstName, string City)
        {

            log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            lo.ConnectionString();

            var constr = CommonUtil.GetConnectionString();
            bool result = false;

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                // con.ConnectionString = "Data Source=LAPTOP-1SE8I7RI;Initial Catalog=Northwind;Integrated Security=True";
                // con.ConnectionString = CommonUtil.GetConnectionString();

                using (SqlCommand cmd = new SqlCommand("UpdateEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.CommandText = "UpdateEmployee";
                    //  cmd.Connection = con;

                    cmd.Parameters.Add("@Empid", SqlDbType.NChar);
                    cmd.Parameters["@Empid"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@Empid"].Value = empid;

                    cmd.Parameters.Add("@EmpLName", SqlDbType.NVarChar);
                    cmd.Parameters["@EmpLName"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@EmpLName"].Value = LastName;

                    cmd.Parameters.Add("@EmpFName", SqlDbType.NVarChar);
                    cmd.Parameters["@EmpFName"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@EmpFName"].Value = FirstName;

                    cmd.Parameters.Add("@City", SqlDbType.NVarChar);
                    cmd.Parameters["@City"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@City"].Value = City;


                    con.Open();
                    int rowseffected = cmd.ExecuteNonQuery();
                 //   con.Close();
                    if (rowseffected > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                    throw new Exception("update employee Exception", new KeyNotFoundException());
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return result;

        }


        public class MyData
        {
            public DataSet dsEmployers;
            public int rowscount;
        }

        public bool DeleteEmployee(int EmpId)
        {

            log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            lo.ConnectionString();

            var constr = CommonUtil.GetConnectionString();
            bool result = false;

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                // con.ConnectionString = "Data Source=LAPTOP-1SE8I7RI;Initial Catalog=Northwind;Integrated Security=True";
                // con.ConnectionString = CommonUtil.GetConnectionString();

                using (SqlCommand cmd = new SqlCommand("DeleteEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.CommandText = "DeleteEmployee";
                    // cmd.Connection = con;

                    cmd.Parameters.Add("@Empid", SqlDbType.NChar);
                    cmd.Parameters["@Empid"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@Empid"].Value = EmpId;
                    con.Open();
                    int rowseffected = cmd.ExecuteNonQuery();
                   // con.Close();
                    if (rowseffected > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                    throw new Exception("Delete employee exception", new KeyNotFoundException());
                }
            }
            catch (Exception ex)
            {
               log.Error(ex.Message, ex);
             
             
            }

            return result;

        }
    }
}