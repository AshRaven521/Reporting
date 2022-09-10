using ICSBEL.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ICSBEL.DataAccessLayer
{
    public static class DB
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private static readonly string selectDataCommand = "SELECT Id, Name, Surname, JobTitle, BirthDate, Salary from Employees";
        private static readonly string insertDataCommandFirstPart = "INSERT INTO Employees (Name, Surname, JobTitle, BirthDate, Salary) ";
        private static readonly string deleteDataCommand = "DELETE FROM Employees WHERE Id=";
        private static readonly string getSalariesCommand = "SELECT JobTitle, AVG(Salary) AS Salary from Employees GROUP BY JobTitle";

        public static async Task<DataTable> GetEmployeesFromDB()
        {
            DataTable selectTable = new DataTable();

            using (var conn = new SqlConnection(connectionString))
            {
                SqlCommand selectCommand = new SqlCommand(selectDataCommand, conn);
                SqlDataAdapter selectAdapter = new SqlDataAdapter();
                selectAdapter.SelectCommand = selectCommand;
                await conn.OpenAsync();
                selectAdapter.Fill(selectTable);
            }

            return selectTable;
        }

        public static async Task<int> InsertEmployeeIntoDB(Employee employee)
        {
            string insertDataCommandSecondPart = "VALUES ('" + employee.Name + "', '" + employee.Surname + "', '" + employee.JobTitle + "', '" +
                employee.BirthDate + "', " + employee.Salary + ")";
            string insertDataCommand = insertDataCommandFirstPart + insertDataCommandSecondPart;

            int insertEmployee = 0;
            using (var conn = new SqlConnection(connectionString))
            {
                SqlCommand insertCommand = new SqlCommand(insertDataCommand, conn);
                await conn.OpenAsync();
                insertEmployee = insertCommand.ExecuteNonQuery();
            }
            //await conn.OpenAsync();
            //insertEmployee = insertCommand.ExecuteNonQuery();

            //var unnecessary = GetEmployeesFromDB(conn);

            return insertEmployee;
        }

        public static async Task<int> DeleteEmployeeFromDB(int id)
        {
            string deleteEmployee = deleteDataCommand + id;

            int deleteEmployeeCount = 0;

            using (var connect = new SqlConnection(connectionString))
            {
                SqlCommand deleteCommand = new SqlCommand(deleteEmployee, connect);
                await connect.OpenAsync();
                deleteEmployeeCount = deleteCommand.ExecuteNonQuery();
            }

            return deleteEmployeeCount;
        }

        public static async Task SelectDataFromDB()
        {
            DataTable dataTable = new DataTable();

            using (var connect = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand(selectDataCommand, connect);
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.SelectCommand = comm;
                await connect.OpenAsync();
                adap.Fill(dataTable);
            }
        }

        public static async Task<DataSet> GetSalariesForReport()
        {
            DataTable salaryTable = new DataTable();
            DataSet salarySet = new DataSet();

            using (var connect = new SqlConnection(connectionString))
            {
                SqlCommand salaryCommand = new SqlCommand(getSalariesCommand, connect);
                SqlDataAdapter salaryAdapter = new SqlDataAdapter();
                salaryAdapter.SelectCommand = salaryCommand;
                await connect.OpenAsync();
                salaryAdapter.Fill(salaryTable);
            }
            salarySet.Tables.Add(salaryTable);

            return salarySet;
        }
    }
}
