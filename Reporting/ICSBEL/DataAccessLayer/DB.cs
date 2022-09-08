using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace ICSBEL.DataAccessLayer
{
    public static class DB
    {
        public static async Task<bool> ConnectToDB(string connString, SqlConnection connect)
        {
            try
            {
                connect = new SqlConnection(connString);
                await connect.OpenAsync();
                return true;
                //MessageBox.Show("Connection open successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                return false;
                //MessageBox.Show($"Something goes wrong! Exception is {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await connect.CloseAsync();
            }
        }

        public static async Task<string> GetConnectionString()
        {
            string json = "";
            using(var fs = new FileStream("config.json", FileMode.OpenOrCreate))
            {
                json = await JsonSerializer.DeserializeAsync<string>(fs);
            }
            return json;
        }
    }
}
