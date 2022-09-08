using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ICSBEL.DataAccessLayer;

namespace ICSBEL
{
    public partial class Reporting : Form
    {
        private string connectionString;
        private SqlConnection connect;

        public Reporting()
        {
            InitializeComponent();
            
        }

        private async void connectToDBButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                connect = new SqlConnection(connectionString);

                connect.Open();
                MessageBox.Show("Connection open successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something goes wrong! Exception is {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
