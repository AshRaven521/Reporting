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
    public partial class reportingForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlConnection connect;

        public reportingForm()
        {
            InitializeComponent();

            //connect = new SqlConnection(connectionString);

            //employeesDataGridView.DataSource = DB.GetEmployeesFromDB(connect);
        }

        private async void connectToDBButton_Click(object sender, EventArgs e)
        {
            //connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connect = new SqlConnection(connectionString);

            try
            {
                //await connect.OpenAsync();
                var data = await DB.GetEmployeesFromDB(connect);
                //BindingSource source = new BindingSource();
                //source.DataSource = data;
                employeesDataGridView.DataSource = data.DefaultView;
                //employeesDataGridView.DataSource = data.
                //employeesDataGridView.DataMember = "Employees";

                MessageBox.Show("Подключение произошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connectToDBButton.Enabled = false;
                insertEmployeeButton.Enabled = true;
                deleteEmployeeButton.Enabled = true;
                createReportButton.Enabled = true;
                employeeJobTitleFilterLabel.Visible = true;
                employeeJobTitleFilterTextBox.Visible = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Произошла ошибка! {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void insertEmployeeButton_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            AddEmployeeForm employeeWindow = new AddEmployeeForm();

            try
            {
                employeeWindow.ShowDialog();
                var newEmployee = employeeWindow.emp;
                if (newEmployee is null)
                {
                    MessageBox.Show("Объект созданного работника был null!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //MessageBox.Show($"Информация о добавленном работнике : {testEmp.Name}", "Информация о работнике", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await DB.InsertEmployeeIntoDB(connect, newEmployee);
                    //MessageBox.Show($"{objects}");
                    //employeesDataGridView.Refresh();
                    //employeesDataGridView.Update();
                    await DB.SelectDataFromDB(connect);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Произошла ошибка! {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeeJobTitleFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            (employeesDataGridView.DataSource as DataTable).DefaultView.RowFilter 
                = String.Format("JobTitle like '{0}%'", employeeJobTitleFilterTextBox.Text);
            employeesDataGridView.Refresh();
        }
    }
}
