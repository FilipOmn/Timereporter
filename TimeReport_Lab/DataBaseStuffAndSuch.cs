using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TimeReport_Lab
{
    public class DataBaseStuffAndSuch
    {
        //The Connection string
        private string connectionString = @"Server=DESKTOP-FFB4Q97\SQLEXPRESS;Initial Catalog=TimeReport;Integrated Security=true;";

        //gets all employees from employee table
        string GetAllEmployeesString = "SELECT * FROM Employees";

        //gets all projects from projects table
        string GetAllProjectsString = "SELECT * FROM Projects";

        //method gets all employees for dropdown
        public List<string> GetAllEmployees()
        {
            List<string> returnList = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter Adapter = new SqlDataAdapter(GetAllEmployeesString, connection);

                DataSet ds = new DataSet();
                Adapter.Fill(ds, "Employees");

                if(ds != null)
                {
                    foreach(DataRow row in ds.Tables["Employees"].Rows)
                    {
                        returnList.Add((string)$"{row[1]} {row[2]}");
                    }
                }
            }

            return returnList;
        }

        //returns list with info for listbox
        public List<string> GetEmployeeInfo(int index)
        {
            List<string> returnList = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //gets relevant information about timereports for employee
                string queryString = $"SELECT Week, Hours, Employees.FirstName, Employees.LastName, Projects.ProjectName FROM TimeReports INNER JOIN Employees ON TimeReports.EmployeeID = Employees.EmployeeID INNER JOIN Projects ON TimeReports.ProjectID = Projects.ProjectID WHERE Employees.EmployeeID = {index + 1}";
                SqlDataAdapter Adapter = new SqlDataAdapter(queryString, connection);

                DataSet ds = new DataSet();
                Adapter.Fill(ds, "Employees");

                if (ds != null)
                {
                    foreach (DataRow row in ds.Tables["Employees"].Rows)
                    {
                        returnList.Add((string)$"Week:{row[0]}          Hours:{row[1]}          Project:{row[4]}");
                    }
                }
            }

            return returnList;
        }

        //method gets all projects for dropdown
        public List<string> GetAllProjects()
        {
            List<string> returnList = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter Adapter = new SqlDataAdapter(GetAllProjectsString, connection);

                DataSet ds = new DataSet();
                Adapter.Fill(ds, "Projects");

                if (ds != null)
                {
                    foreach (DataRow row in ds.Tables["Projects"].Rows)
                    {
                        returnList.Add((string)$"{row[1]}");
                    }
                }
            }

            return returnList;
        }

        //method for adding time reports
        public static void AddTimeReport(int project, int employee, int weeks, int hours)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=DESKTOP-FFB4Q97\SQLEXPRESS;Initial Catalog=TimeReport;Integrated Security=true;"))
            {   
                //inserts timereports into TimeReports table
                string AddReportsForEmployee = $"INSERT INTO TimeReports(Week, EmployeeID, ProjectID, Hours) VALUES({weeks}, {employee}, {project}, {hours});";

                SqlDataAdapter Adapter = new SqlDataAdapter(AddReportsForEmployee, connection);

                DataSet ds = new DataSet();
                Adapter.Fill(ds, "TimeReports");
            }
        }
    }
}
