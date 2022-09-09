using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using ICSBEL.Models;

namespace ICSBEL.DataAccessLayer
{
    public static class DB
    {
        private static readonly string selectDataCommand = "SELECT Name, Surname, JobTitle, BirthDate, Salary from Employees";
        private static readonly string insertDataCommandFirstPart = "INSERT INTO Employees (Name, Surname, JobTitle, BirthDate, Salary) ";

        //public static async Task<bool> ConnectToDB(string connString, SqlConnection connect)
        //{
        //    try
        //    {
        //        connect = new SqlConnection(connString);
        //        await connect.OpenAsync();
        //        return true;
        //        //MessageBox.Show("Connection open successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (SqlException ex)
        //    {
        //        return false;
        //        //MessageBox.Show($"Something goes wrong! Exception is {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        await connect.CloseAsync();
        //    }
        //}

        public static async Task<DataTable> GetEmployeesFromDB(SqlConnection conn)
        {

            SqlCommand selectCommand = new SqlCommand(selectDataCommand, conn);
            SqlDataAdapter selectAdapter = new SqlDataAdapter();
            selectAdapter.SelectCommand = selectCommand;
            DataTable selectTable = new DataTable();
            //DataSet selectDataSet = new DataSet();

            using (conn)
            {
                await conn.OpenAsync();
                selectAdapter.Fill(selectTable);
            }

            return selectTable;
        }

        public static async Task InsertEmployeeIntoDB(SqlConnection conn, Employee employee)
        {
            string insertDataCommandSecondPart = "VALUES ('" + employee.Name +"', '" + employee.Surname + "', '" + employee.JobTitle + "', '" +
                employee.BirthDate + "', " + employee.Salary + ")";
            string insertDataCommand = insertDataCommandFirstPart + insertDataCommandSecondPart;

            SqlCommand insertCommand = new SqlCommand(insertDataCommand, conn);

            //await conn.OpenAsync();
            //int objNumber = insertCommand.ExecuteNonQuery();
            //await conn.CloseAsync();
            using (conn)
            {
                await conn.OpenAsync();
                int objNumber = insertCommand.ExecuteNonQuery();
            }

            //var unnecessary = GetEmployeesFromDB(conn);


        }

        public static async Task SelectDataFromDB(SqlConnection connect)
        {
            SqlCommand comm = new SqlCommand(selectDataCommand);
            SqlDataAdapter adap = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adap.SelectCommand = comm;
            
            using (connect)
            {
                await connect.OpenAsync();
                adap.Fill(dataTable);
            }
        }
    }
}
